using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class User
    {
        public int id { get; set; }
        public string surname { get; set; }
        public string name { get; set; }
        public string patronimyc { get; set; }
        public string email { get; set; }
        public string phoneNumber { get; set; }
        public IEnumerable<House> houses { get; set; }


    }
}
