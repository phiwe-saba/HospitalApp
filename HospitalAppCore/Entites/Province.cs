using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalAppCore.Entites
{
    public partial class Province
    {
        public int ProvinceID { get; set; }
        public string ProvinceName { get; set; }
        public List<City> Cities { get; set; } = new List<City>();
    }
}
