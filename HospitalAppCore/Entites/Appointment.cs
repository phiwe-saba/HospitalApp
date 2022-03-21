using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalAppCore.Entites
{
    public partial class Appointment
    {
        public int AppointmentID { get; set; }
        public DateTime AppDate { get; set; }
        public DateTime AppTime { get; set; }
        public string AppStatus { get; set; }
        public int PatientID { get; set; }
        public Patient Patient { get; set; }
        public int DoctorID { get; set; }
        public Doctor Doctor { get; set; }
    }
}
