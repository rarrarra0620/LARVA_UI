using Quartz.Impl;
using Quartz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Quartz.Logging;

namespace LARVA.Scheduler
{
    public class JobScheduler
    {
        private StdSchedulerFactory factory = new StdSchedulerFactory();
        private IScheduler scheduler = null;

        public async Task Start()
        {
            scheduler = await factory.GetScheduler();
            // and start it off
            await scheduler.Start();

            // some sleep to show what's happening
            await Task.Delay(TimeSpan.FromSeconds(10));

            // define the job and tie it to our HelloJob class
            IJobDetail job = JobBuilder.Create<ScheduleQueueJob>()
             .WithIdentity("job1", "group1")
             .Build();

            // Trigger the job to run now, and then repeat every 10 seconds
            ITrigger trigger = TriggerBuilder.Create()
             .WithIdentity("trigger1", "group1")
             .StartNow()
             .WithSimpleSchedule(x => x
              .WithIntervalInSeconds(5)
              .RepeatForever())
             .Build();

            // Tell Quartz to schedule the job using our trigger
            await scheduler.ScheduleJob(job, trigger);

            // You could also schedule multiple triggers for the same job with
            // await scheduler.ScheduleJob(job, new List<ITrigger>() { trigger1, trigger2 }, replace: true);
        }

        public async Task Stop()
        {
            await scheduler.Shutdown();
        }
    }
}
