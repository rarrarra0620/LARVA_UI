using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EPLE.Core;

namespace EPLE.Core.Manager.Model
{

    public enum eUserLevel
    {
        ADMIN,
        ENGINEER,
        OPERATOR,
        GUEST,
        UNKNOWN
    }
    public class USER_INFO
    {
        public string UserId { get; set; }
        public string Password { get; set; }
        public string Description { get; set; }
        public eUserLevel UserLevel { get; set; }
    }
}
