using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class EnergyIndicator
    {
        public int id { get; set; }
        public string date { get; set; }
        public float consumption { get; set; }
    }
}
