using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace RpsTest
{
    public class Requester
    {
        private HttpClient _client;
        private readonly string _url;
        private readonly int _tasks;
        private readonly bool _keepAlive;
        private long _count;
        private int _asyncCnt = 0;
        public long Count
        {
            get { return _count; }
            set { _count = value; }
        }

        public long LastResult { get; set; }

        public Action<Exception> ExceptionHandler { get; set; } 

        public Requester(string url, int tasks, bool keepAlive)
        {
            _client = new HttpClient()
            {
                Timeout = TimeSpan.FromMilliseconds(5000)
            };
            _count = 0;
            LastResult = 0;
            _url = url;
            _tasks = tasks;
            _keepAlive = keepAlive;
        }

        private HttpWebRequest CreateWebRequest()
        {
            var request = (HttpWebRequest)WebRequest.Create(_url);
            request.Method = "GET";
            request.KeepAlive = _keepAlive;
            request.Timeout = 5000;
            return request;
        }

        public Task Start(CancellationToken ct)
        {
            var tasks = new Task[_tasks];
            for (int i=0; i<_tasks; i++)
            {
                tasks[i] = Task.Run(() =>
                {

                        int cnt = 0;
                        while (!ct.IsCancellationRequested)
                        {
                            try
                            {
                                cnt++;
                                var result = Get();
                                int value = 0;
                                if (int.TryParse(result, out value))
                                {
                                    LastResult = value;
                                }
                                Interlocked.Increment(ref _count);
                            }
                            catch (Exception ex)
                            {
                                if (ExceptionHandler != null)
                                    ExceptionHandler(ex);
                            }
                        }

                }, ct);
            }
            return Task.WhenAll(tasks);

        }

        public Task StartAsync(CancellationToken cancellationToken)
        {
            var t = Task.Run(() =>
            {
                while (!cancellationToken.IsCancellationRequested)
                {
                    RequestAsync(cancellationToken);
                }
            }, cancellationToken);
            return t;
        }

        private async Task RequestAsync(CancellationToken cancellationToken)
        {
            try
            {
                if (_asyncCnt < _tasks || _tasks == 0)
                {
                    Interlocked.Increment(ref _asyncCnt);
                    using (var request = new HttpRequestMessage(){RequestUri = new Uri(_url), Method = HttpMethod.Get})
                    {
                        if (!_keepAlive)
                        {
                            request.Headers.Add("Connection", new[] { "close" });
                        }
                        using (var result = await _client.SendAsync(request, cancellationToken).ConfigureAwait(false))
                        {
                            try
                            {
                                var response = await result.Content.ReadAsStringAsync().ConfigureAwait(false);
                                int value = 0;
                                if (int.TryParse(response, out value))
                                {
                                    LastResult = value;
                                }
                            }
                            finally
                            {
                                Interlocked.Increment(ref _count);
                                Interlocked.Decrement(ref _asyncCnt);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                if (ExceptionHandler != null)
                    ExceptionHandler(ex);
            }
        }

        public string Get()
        {
            HttpWebResponse response = null;
            var request = CreateWebRequest();
            try
            {
                response = (HttpWebResponse)request.GetResponse();
                using (var sr = new StreamReader(response.GetResponseStream()))
                {
                    var result = sr.ReadToEnd();
                    response.Close();
                    return result;
                }
                
            }
            finally
            {
                if (response != null) response.Close();
            }
        }


    }
}
