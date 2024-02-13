using EPLE.App;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LARVA.Function
{
    public class F_AUTO_EJECT : AbstractFunction
    {
        private string request_io_name = IoNameHelper.oAuto_nEject_Req;
        private string reply_io_name = IoNameHelper.iAuto_nEject_Reply;

        public F_AUTO_EJECT()
        {
            this.RequestIoName = request_io_name;
            this.ReplyIoName = reply_io_name;
        }
    }
}
