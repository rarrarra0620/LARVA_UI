using EPLE.App;
using EPLE.Core;
using EPLE.Core.Manager;
using EPLE.IO;
using LARVA.Scheduler;
using LARVA.Scheduler.Model;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LARVA.Function
{
    public class F_AUTO_TOBBAB_CHANGE : AbstractFunction
    {
        private string request_io_name = IoNameHelper.oAuto_nTobbabChange_Req;
        private string reply_io_name = IoNameHelper.iAuto_nTobbabChange_Reply;

        private string job_id;

        public override bool CanExecute()
        {
            return AvailableStatus();
        }

        public override string Execute(object[] args = null)
        {
            JOB job = (JOB)args[0];
            job_id = job.ID;

            bool result = false;

            if(int.TryParse(job.ORIGIN_LOCATION, out int locationId))
            {
                DataManager.Instance.SET_INT_DATA(IoNameHelper.oParam_nTargetBox_LocationId, locationId);
            }  
            else
            {
                DataManager.Instance.SET_INT_DATA(IoNameHelper.oParam_nTargetBox_LocationId, 0);
            }

            JobManager.Instance.UpdateJobStart(job_id);


            if (DataManager.Instance.SET_INT_DATA(request_io_name, (int)eOnOff.ON))
            {
                Stopwatch stopwatch = new Stopwatch();
                stopwatch.Start();

                while (true)
                {
                    Thread.Sleep(100);

                    if (Abort)
                    {
                        return F_RESULT_ABORT;
                    }
                    else if (stopwatch.ElapsedMilliseconds > TimeoutMiliseconds)
                    {
                        Abort = false;
                        IsProcessing = false;
                        DataManager.Instance.SET_INT_DATA(request_io_name, (int)eOnOff.OFF);
                        return this.F_RESULT_TIMEOUT;
                    }
                    else if (DataManager.Instance.GET_INT_DATA(reply_io_name, out result) == (int)eOnOff.ON)
                    {
                        Abort = false;
                        IsProcessing = false;
                        DataManager.Instance.SET_INT_DATA(request_io_name, (int)eOnOff.OFF);
                        return this.F_RESULT_SUCCESS;
                    }
                    else
                    {
                        IsProcessing = true;
                        continue;
                    }
                }
            }
            else
            {
                return this.F_RESULT_FAIIL;
            }
        }

        public override void ExecuteWhenSimulate()
        {
            throw new NotImplementedException();
        }

        public override void PostExecute()
        {
            while (DataManager.Instance.GET_INT_DATA(IoNameHelper.iAuto_nTobbabChange_Busy, out bool result) == (int)eOnOff.ON)
            {
                Thread.SpinWait(100);
            }

            JobManager.Instance.DeleteJob(job_id);
        }
    }
}
