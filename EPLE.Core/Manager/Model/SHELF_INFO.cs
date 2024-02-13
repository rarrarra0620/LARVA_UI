using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EPLE.Core;

namespace EPLE.Core.Manager.Model
{
    public enum eLARVALEVEL
    {
        None = 0,
        Adult = 1,
        Egg = 2,
        FirstSecond = 3,
        Third = 4,
        ThirdFasting = 5,
        ThirdShip = 6,
        Cocoon = 7
    }
    public class SHELF_INFO
    {
        public int Id {  get; set; }
        public string BoxName { get; set; }
        public eLARVALEVEL Boxlevel { get; set; }
        public string Description { get; set; }
        
    }
}
