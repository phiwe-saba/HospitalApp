using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalAppCore.Entites
{
    public partial class Patient
    {
        public int PatientID { get; set; }
        public string FullNames { get; set; }
        public string Gender { get; set; }
        public DateTime DOB { get; set; }
        public string MobileNumber { get; set; }
        public string EmailAddress { get; set; }
        public List<Address> Addresses { get; set; } = new List<Address>();
        public List<Appointment> Appointments { get; set; } = new List<Appointment>();
        
    }
}
