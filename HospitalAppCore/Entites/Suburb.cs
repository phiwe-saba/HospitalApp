using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalAppCore.Entites
{
    public partial class Suburb
    {
        public int SuburbID { get; set; }
        public string SuburbName { get; set; }
        public int CityID { get; set; }
        public City City { get; set; }
        public List<Address> Addresses { get; set; } = new List<Address>();
    }
}
