using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Microsoft.Owin.Hosting;
using RpsTest.Properties;
using Timer = System.Windows.Forms.Timer;

namespace RpsTest
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            
        }

        private CancellationTokenSource cts = new CancellationTokenSource();
        private AvgQueue _lastRequests;
        private long _lastCount;
        private long _lastServerCount;
        private int _samples;
        private int _secondsPassed;

        private void FormMain_Load(object sender, EventArgs e)
        {
            int minWorker, minIOC;
            ThreadPool.GetMinThreads(out minWorker, out minIOC);
            ThreadPool.SetMaxThreads(300, 300);
            ThreadPool.SetMinThreads(100, minIOC);

            ServicePointManager.DefaultConnectionLimit = (int)maxConnections.Value;
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            cts.Cancel();
            Settings.Default.Save();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            DisableControls();
            if (rbServer.Checked)
            {

                Log("Server starting");
                StartServer();
            }
            else
            {
                Log("Client starting");
                StartClient();
            }
        }

        private void DisableControls()
        {
            foreach (Control c in panelButtons.Controls)
            {
                if (c.Name != "btnStartAb")
                    c.Enabled = false;
            }
        }

        private void StartClient()
        {
            chart.Series["Series1"].LegendText = "Requests per interval";
            chart.Series["Series2"].LegendText = "Server count";
            _lastCount = 0;
            _samples = 0;
            _secondsPassed = 0;
            _lastServerCount = 0;
            int samplesPerSecond = (int)(1000 / chartInterval.Value);
            _lastRequests = new AvgQueue(samplesPerSecond*2);
            var requester = new Requester(tbUrl.Text, (int)tasksCount.Value, cbKeepAlive.Checked);
            requester.ExceptionHandler += exception =>
            {
                this.Invoke((MethodInvoker)delegate
                {
                    Log("Ex: {0},",exception.ToString());
                });
            };

            if (rbClientAsync.Checked)
            {
                requester.StartAsync(cts.Token);
            }
            else
            {
                requester.Start(cts.Token);
            }
            Log("Client started requesting " + tbUrl.Text);
            chart.Series["Series2"].IsXValueIndexed = false;
            chart.Series["Series1"].IsXValueIndexed = false;
            var timer = new Timer() { Interval = (int)chartInterval.Value };
            timer.Tick += (o, args) =>
            {
                _samples++;
                var count = requester.Count;
                var serverCount = requester.LastResult;
                if (_samples == 1)
                    _lastServerCount = serverCount;
                labelCnt.Text = @"Total: " + count.ToString();
                var countPerPeriod = count - _lastCount;
                _lastRequests.Add(countPerPeriod);
                if (_samples % samplesPerSecond == 0) //each second
                {
                    var avg = _lastRequests.Avg();
                    _secondsPassed++;
                    Log2("Avg per {0}ms: {1:0.00}", chartInterval.Value, avg);
                }
                if (_samples > 4 || serverCount - _lastServerCount < 3000)
                {
                    chart.Series["Series1"].Points.Add(countPerPeriod);
                    chart.Series["Series2"].Points.Add(serverCount - _lastServerCount);
                }

                _lastServerCount = serverCount;
                _lastCount = count;

            };
            timer.Start();


        }
      

        private void StartServer()
        {
            WebApp.Start<Startup>(url: tbServerBinding.Text);
            Log("Server started on " + tbServerBinding.Text);
            _lastCount = 0;
            _samples = 0;
            _secondsPassed = 0;
            int samplesPerSecond = (int)(1000 / chartInterval.Value);
            _lastRequests = new AvgQueue(samplesPerSecond*2);
            //var ca = chart.ChartAreas.First();
            //ca.AxisX.IntervalAutoMode = IntervalAutoMode.FixedCount;
            chart.Series["Series1"].LegendText = "Requests per interval";
            chart.Series["Series2"].LegendText = "Avg requests";
            //chart.Series["BarSeries"].YValuesPerPoint = samplesPerSecond;
            var timer = new Timer() {Interval = (int) chartInterval.Value};
            timer.Tick += (o, args) =>
            {
                _samples++;
                var count = Startup.Counter;
                labelCnt.Text = @"Total: " + count.ToString();
                var countPerPeriod = count - _lastCount;
                _lastRequests.Add(countPerPeriod);
                var avg = _lastRequests.Avg();
                if (_samples % samplesPerSecond == 0) //each second
                {
                    _secondsPassed++;
                    Log2("Avg per {0}ms: {1:0.00}", chartInterval.Value, avg);
                }
                chart.Series["Series2"].Points.Add(avg);
                chart.Series["Series1"].Points.Add(countPerPeriod);


                _lastCount = count;

            };
            timer.Start();

            
        }



        private void Log(string message, params object[] p)
        {
            tbLog.AppendText(string.Format(message, p) + Environment.NewLine);
        }
        private void Log2(string message, params object[] p)
        {
            tbLog2.AppendText(string.Format(message, p) + Environment.NewLine);
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            ServicePointManager.DefaultConnectionLimit = (int)maxConnections.Value;
        }

        private void btnStartAb_Click(object sender, EventArgs e)
        {
            var path = System.Reflection.Assembly.GetExecutingAssembly().Location;
            Log("Launching ab.exe from {0}", path);
            path = Path.Combine(Path.GetDirectoryName(path), "ab.exe");
            try
            {
                var url = tbUrl.Text;
                if (!url.EndsWith("/"))
                    url += "/";
                System.Diagnostics.Process.Start(path, string.Format("-n 1000000 -c {0} -k {1}", (int) tasksCount.Value, url));
            }
            catch(Exception ex)
            {
                Log(ex.ToString());
            }


        }

        private void tasksCount_ValueChanged(object sender, EventArgs e)
        {

        }


    }
}
