using System;
using System.Net.Configuration;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Owin;
using Owin;


[assembly: OwinStartup(typeof(RpsTest.Startup))]
namespace RpsTest
{
    public class Startup
    {
        public static long Counter = 0;
        public void Configuration(IAppBuilder app)
        {
            // New code:
            app.Run(context =>
            {
                context.Response.ContentType = "text/json";
                return context.Response.WriteAsync(Interlocked.Increment(ref Counter).ToString());
            });
        }
    }
}