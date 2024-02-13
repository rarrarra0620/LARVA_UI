using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EPLE.Core.Manager;
using EPLE.IO;

namespace EPLE.App
{
    public class DataChangedEvent
    {
        public static void DataManager_DataChangedEvent(object sender, DataChangedEventHandlerArgs args)
        {
            //switch (args.Data.Name)
            //{
                //case IoNameHelper.IN_DBL_PMAC_X_VELOCITY:
                //case IoNameHelper.IN_DBL_PMAC_Y_VELOCITY:
                //    {
                //        if ((double)args.Data.Value > 0)
                //        {
                //            DataManager.Instance.SET_INT_DATA(IoNameHelper.OUT_INT_PMAC_TOWERLAMP_GREEN, 1);
                //            DataManager.Instance.SET_INT_DATA(IoNameHelper.OUT_INT_PMAC_TOWERLAMP_YELLOW, 0);
                //        }
                //        else
                //        {
                //            DataManager.Instance.SET_INT_DATA(IoNameHelper.OUT_INT_PMAC_TOWERLAMP_GREEN, 0);
                //            DataManager.Instance.SET_INT_DATA(IoNameHelper.OUT_INT_PMAC_TOWERLAMP_YELLOW, 1);
                //        }
                //    }
                //    break;
            //}
        }

        public static void DataManager_AlarmChangedEvent(object sender, DataChangedEventHandlerArgs args)
        {
            if(args.Data.Group == "ALARM")
            {
                if (Convert.ToBoolean(args.Data.Value) == true)
                {
                    string alarmId = ((string[])args.Data.Name.Split('.'))[1];

                    AlarmManager.Instance.SetAlarm(alarmId);
                }
                else if (Convert.ToBoolean(args.Data.Value) == false)
                {
                    
                    string alarmId = ((string[])args.Data.Name.Split('.'))[1];

                    if (AlarmManager.Instance.GetCurrentAlarmAsList().First((alarm) =>
                    {
                        if (alarm.ID == alarmId)
                        {
                            return true;
                        }
                        else 
                        { 
                            return false; 
                        }
                    }) != null)
                    {
                        AlarmManager.Instance.ResetAlarm(alarmId);
                    }
                }
            }
        }
    }
}
