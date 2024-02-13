using EPLE.App;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LARVA.Function
{
    public class F_AUTO_UNLOAD : AbstractFunction
    {
        private string request_io_name = IoNameHelper.oAuto_nUnload_Req;
        private string reply_io_name = IoNameHelper.iAuto_nUnload_Reply;

        public F_AUTO_UNLOAD()
        {
            this.RequestIoName = request_io_name;
            this.ReplyIoName = reply_io_name;
        }
    }
}
