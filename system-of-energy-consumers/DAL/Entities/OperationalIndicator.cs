using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class OperationalIndicator
    {
        public int id { get; set; }
        public string date { get; set; }
        public float minConsReq { get; set; }
        public float estimCons { get; set; }
    }
}
