using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalAppCore.MetaDataTypes
{
    [MetadataType(typeof(AppointmentMetaData))]
    public partial class Appointment { }
    public class AppointmentMetaData
    {
        [Required]
        [Display(Name = "Appointment date:")]
        public DateTime AppDate;

        [Required]
        [Display(Name = "Consultation time:")]
        public DateTime AppTime;

        public string AppStatus;
    }
}
