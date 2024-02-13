using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LARVA_UI.Models
{
    public class CurrentAlarmDisplay
    {
        public string ID { get; set; }
        public string NAME { get; set; }
        public string DESCRIPTION { get; set; }
        public string LEVEL { get; set; }
        public DateTime SETTIME { get; set; }
    }
}
