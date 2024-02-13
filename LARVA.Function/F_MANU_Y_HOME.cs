using EPLE.App;
using EPLE.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LARVA.Function
{
    public class F_MANU_Y_HOME : AbstractFunction
    {
        private string request_io_name = IoNameHelper.oMot_nYHome_Req;
        private string reply_io_name = IoNameHelper.iMot_nYHome_Reply;

        public F_MANU_Y_HOME()
        {
            this.RequestIoName = request_io_name;
            this.ReplyIoName = reply_io_name;
        }

        public override bool AvailableStatus()
        {
            bool result = false;
            int available = DataManager.Instance.GET_INT_DATA(IoNameHelper.iEqp_nAvailable_Status, out result);
            int accessMode = DataManager.Instance.GET_INT_DATA(IoNameHelper.iEqp_nOp_Mode, out result);


            if (!result || available == (int)eAvailable.DOWN || accessMode != (int)eAccessMode.MANUAL)
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
