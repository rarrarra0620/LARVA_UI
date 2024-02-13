using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LARVA_UI.Models
{
    public class LocationDisplay
    {
        public string NAME { get; set; }
        public string LOCATION_ID { get; set; }
        public double X_POS { get; set; }
        public double Y_POS_OUT { get; set;}
        public double Y_POS_IN { get; set; }
        public double Z_POS_UP { get; set; }
        public double Z_POS_DOWN { get; set; }

        public string HAND_LEFT_RIGHT { get; set; }
        public string BOX_ID { get; set; }
        public string LOC_TYPE { get; set; }
    }
}
