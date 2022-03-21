using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalAppCore.Entites
{
    public partial class Address
    {
        public int AddressID { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public int PatientID { get; set; }
        public Patient Patient { get; set; }
        public int SuburbID { get; set; }
        public Suburb Suburb { get; set; }
    }
}
