using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTO
{
    public class OperationalIndicatorDTO
    {
        public int Id { get; set; }
        public string Date { get; set; }
        public float MinConsReq { get; set; }
        public float EstimCons { get; set; }
    }
}
