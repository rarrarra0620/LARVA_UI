using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EPLE.Core.Function.Interface;
using EPLE.IO;
using EPLE.App;
using EPLE.Core.Manager;
using System.Diagnostics;
using System.Threading;

namespace LARVA.Function
{
    public class F_AUTO_TOBBAB_SUPPLY : AbstractFunction
    {
        private string request_io_name = IoNameHelper.oAuto_nTobbabSupply_Req;
        private string reply_io_name = IoNameHelper.iAuto_nTobbabSupply_Reply;

        public F_AUTO_TOBBAB_SUPPLY()
        {
            this.RequestIoName = request_io_name;
            this.ReplyIoName = reply_io_name;
        }
    }
}
