using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LARVA.Scheduler.Model
{
    public class JOB
    {
        public string ID { get; set; }
        public long PRIORITY { get; set; }
        public string STATE { get; set; }
        public string JOB_TYPE { get; set; }
        public string CARRIER_ID {  get; set; }
        public string STEP_ID { get; set; }
        public string ORIGIN_LOCATION { get; set; }
        public DateTime CREATED_TIME { get; set; }
        public DateTime QUEUED_TIME { get; set; }
        public DateTime STARTED_TIME { get; set; }
        public DateTime COMPLETED_TIME { get; set; }
        public string CREATOR { get; set; }
    }
}
