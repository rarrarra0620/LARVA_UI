using Quartz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EPLE.Core;
using LARVA.Scheduler.Model;
using EPLE.Core.Manager;

namespace LARVA.Scheduler
{
    public class ScheduleQueueJob : IJob
    {
        public async Task Execute(IJobExecutionContext context)
        {
            JOB executingJob = null;

            List<JOB> jobs = new List<JOB>();

            jobs = JobManager.Instance.GetJobListAll();

            foreach (JOB job in jobs)
            {
                if (job.STATE == "QUEUED")
                {
                    if (executingJob == null || executingJob.PRIORITY < job.PRIORITY)
                    {
                        executingJob = job;
                    }          
                }
            }


            if (executingJob != null)
            {
                switch(executingJob.JOB_TYPE)
                {
                    case "TOBBAB_CHANGE":
                        object[] args = new object[] { executingJob };
                        FunctionManager.Instance.EXECUTE_FUNCTION_PARAMS_ASYNC("F_AUTO_TOBBAB_CHANGE", args, TobbabChangeResultCallback);
                        break;
                }
            }


            await Task.CompletedTask;
        }

        private void TobbabChangeResultCallback(string functionName, object result)
        {
            
        }
    }
}
