using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class House
    {
        public int id { get; set; }
        public IEnumerable<EnergyIndicator> energyIndicators { get; set; }
        public IEnumerable<OperationalIndicator> operationalIndicators { get; set; }
        public string address { get; set; }
        public string email { get; set; }
        public string phoneNumber { get; set; }
        
    }
}
