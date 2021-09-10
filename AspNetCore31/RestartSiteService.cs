using System;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Hosting;

namespace AspNetCore31
{
    internal class RestartSiteService : BackgroundService
    {
        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            var rand = new Random();
            int intRandomMinutes = rand.Next(5, 15);
            var sleepTimeSpan = new TimeSpan(1, intRandomMinutes, 0);

            while (!stoppingToken.IsCancellationRequested)
            {
                await Task.Delay(sleepTimeSpan, stoppingToken);
                Environment.FailFast("Restarting the process");
            }
        }
    }
}