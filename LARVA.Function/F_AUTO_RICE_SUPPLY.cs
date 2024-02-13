using EPLE.App;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LARVA.Function
{
    public class F_AUTO_RICE_SUPPLY : AbstractFunction
    {
        private string request_io_name = IoNameHelper.oAuto_nEject_Req;
        private string reply_io_name = IoNameHelper.iAuto_nEject_Reply;

        public F_AUTO_RICE_SUPPLY()
        {
            RequestIoName = request_io_name;
            ReplyIoName = reply_io_name;
        }
    }
}
