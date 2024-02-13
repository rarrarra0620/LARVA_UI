using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EPLE.Core.Function.Interface;
using EPLE.IO;
using EPLE.App;
using System.Diagnostics;
using System.Threading;

namespace LARVA.Function
{
    public abstract class AbstractFunction : IFunction
    {
        public readonly string F_RESULT_SUCCESS = "SUCCESS";
        public readonly string F_RESULT_FAIIL = "FAIL";
        public readonly string F_RESULT_TIMEOUT = "TIMEOUT";
        public readonly string F_RESULT_ABORT = "ABORT";

        public string RequestIoName { get; set; }
        public string ReplyIoName { get; set; }

        public bool IsProcessing { get; set; }
        public bool Abort { get; set; }
        public int TimeoutMiliseconds { get; set; }

        public AbstractFunction()
        {
            Abort = false;
            IsProcessing = false;
            TimeoutMiliseconds = 1000;
        }

        public virtual bool CanExecute()
        {
            return AvailableStatus();  
        }


        public virtual string Execute(object[] args = null)
        {
            bool result = false;
            if (DataManager.Instance.SET_INT_DATA(RequestIoName, (int)eOnOff.ON))
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
                        return this.F_RESULT_TIMEOUT;
                    }
                    else if (DataManager.Instance.GET_INT_DATA(ReplyIoName, out result) == (int)eOnOff.ON)
                    {
                        Abort = false;
                        IsProcessing = false;
                        DataManager.Instance.SET_INT_DATA(RequestIoName, (int)eOnOff.OFF);
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

        public virtual void ExecuteWhenSimulate()
        {
            throw new NotImplementedException();
        }

        public virtual void PostExecute()
        {
            DataManager.Instance.SET_INT_DATA(RequestIoName, (int)eOnOff.OFF);
        }

        public virtual bool AvailableStatus()
        {
            bool result = false;
            int available = DataManager.Instance.GET_INT_DATA(IoNameHelper.iEqp_nAvailable_Status, out result);
            int accessMode = DataManager.Instance.GET_INT_DATA(IoNameHelper.iEqp_nOp_Mode, out result);


            if (!result || available == (int)eAvailable.DOWN || accessMode != (int)eAccessMode.AUTO)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
