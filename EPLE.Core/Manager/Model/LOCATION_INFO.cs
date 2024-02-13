using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPLE.Core.Manager.Model
{
    public class LOCATION_INFO
    {
        public long LOCATION_ID { get; set; }
        public string LOCATION_NAME { get; set; }
        public double X_POS {  get; set; }
        public double Y_IN_POS { get; set; }
        public double Y_OUT_POS { get;set; }
        public double Z_UP_POS { get; set; }
        public double Z_DOWN_POS { get; set; }
        public string TRANSFER_HAND { get; set; }
        public string LOCATION_TYPE { get; set; }
        public string LEVEL { get; set; }
        public string COL {  get; set; }
        public string FLOOR { get; set; }
        public string ORDER { get; set; }

    }
}
