using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTO
{
    public class EnergyIndicatorDTO
    {
        public int Id { get; set; }
        public string Date { get; set; }
        public float Consumption { get; set; }
    }
}
