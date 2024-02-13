using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.Mvvm.CodeGenerators;
using DevExpress.Xpf.Core;
using DevExpress.Xpf.Editors;
using EPLE.App;
using EPLE.IO;

namespace LARVA_UI.ViewModels
{
    public partial class SettingsViewModel
    {
        [GenerateProperty]
        private string servoState_XAxis;
        [GenerateProperty]
        private string servoState_YAxis;
        [GenerateProperty]
        private string servoState_ZAxis;
        [GenerateProperty]
        private string servoState_TAxis;
        [GenerateProperty]
        private string servoReady_XAxis;
        [GenerateProperty]
        private string servoReady_YAxis;
        [GenerateProperty]
        private string servoReady_ZAxis;
        [GenerateProperty]
        private string servoReady_TAxis;
        [GenerateProperty]
        private string servoNotMoving_XAxis;

        private string ServoNotMoving(int axis)
        {
            bool result = true;
            string isNotMoving = "0";


            switch (axis)
            {
                case 1:
                    {
                        bool val = DataManager.Instance.GET_BOOL_DATA(IoNameHelper.iXAxis_nStatus_IsNotMove, out result);
                        if (result)
                            isNotMoving = val ? "1" : "0";
                        else
                            isNotMoving = "0";
                    }
                    break;
            }

            return isNotMoving;
        }

        private string ServoReady(int axis)
        {
            bool result = true;
            string isReady = "0";

            switch (axis)
            {
                case 1:
                    {
                        bool val = DataManager.Instance.GET_BOOL_DATA(IoNameHelper.iXAxis_nStatus_IsReady, out result);
                        if (result)
                            isReady = val ? "1" : "0";
                        else
                            isReady = "0";
                    }
                    break;
            }

            return isReady;
        }

        private string ServoStateConverter(int axis)
        {
            string returnState = "";
            bool result = true;
            bool isDisable = false;
            bool isCalibrate = false;
            bool isError = false;

            switch (axis)
            {
                case 1:
                    {
                        if (result)
                            isDisable = DataManager.Instance.GET_BOOL_DATA(IoNameHelper.iXAxis_nStatus_IsDisabled, out result);
                        else
                            return "2";
                        if (result)
                            isCalibrate = DataManager.Instance.GET_BOOL_DATA(IoNameHelper.iXAxis_nStatus_IsCalibrated, out result);
                        else
                            return "2";

                        if (result)
                            isError = DataManager.Instance.GET_BOOL_DATA(IoNameHelper.iXAxis_nStatus_HasErr, out result);
                        else
                            return "2";
                    }
                    break;
                case 2:
                    {
                        if (result)
                            isDisable = DataManager.Instance.GET_BOOL_DATA(IoNameHelper.iYAxis_nStatus_IsDisabled, out result);
                        else
                            return "2";
                        if (result)
                            isCalibrate = DataManager.Instance.GET_BOOL_DATA(IoNameHelper.iYAxis_nStatus_IsCalibrated, out result);
                        else
                            return "2";

                        if (result)
                            isError = DataManager.Instance.GET_BOOL_DATA(IoNameHelper.iYAxis_nStatus_HasErr, out result);
                        else
                            return "2";
                    }
                    break;
                case 3:
                    {
                        if (result)
                            isDisable = DataManager.Instance.GET_BOOL_DATA(IoNameHelper.iZAxis_nStatus_IsDisabled, out result);
                        else
                            return "2";
                        if (result)
                            isCalibrate = DataManager.Instance.GET_BOOL_DATA(IoNameHelper.iZAxis_nStatus_IsCalibrated, out result);
                        else
                            return "2";

                        if (result)
                            isError = DataManager.Instance.GET_BOOL_DATA(IoNameHelper.iZAxis_nStatus_HasErr, out result);
                        else
                            return "2";
                    }
                    break;
                case 4:
                    {
                        if (result)
                            isDisable = DataManager.Instance.GET_BOOL_DATA(IoNameHelper.iTAxis_nStatus_IsDisabled, out result);
                        else
                            return "2";
                        if (result)
                            isCalibrate = DataManager.Instance.GET_BOOL_DATA(IoNameHelper.iTAxis_nStatus_IsCalibrated, out result);
                        else
                            return "2";

                        if (result)
                            isError = DataManager.Instance.GET_BOOL_DATA(IoNameHelper.iTAxis_nStatus_HasErr, out result);
                        else
                            return "2";
                    }
                    break;
            }

            if (isDisable == false)
            {
                returnState = "0";
            }
            else
            {
                returnState = "1";
            }

            if (isCalibrate == false)
            {
                returnState = "2";
            }

            if (isError == true)
            {
                returnState = "1";
            }

            return returnState;

        }

    }
}
