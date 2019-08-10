using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TransportSchedule
{
    public class Trip
    {
        public Trip()
        {

        }
        public string  time { get; set; }
        public int capacity { get; set; }
        public string vehicle { get; set; }
        public string day { get; set; }
        public string notes { get; set; }
        
        
    }
}
