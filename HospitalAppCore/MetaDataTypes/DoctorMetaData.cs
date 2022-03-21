using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalAppCore.MetaDataTypes
{
    [MetadataType(typeof(DoctorMetaData))]
    public partial class Doctor { }
    public class DoctorMetaData
    {
        [Required]
        [Display(Name = "First name:")]
        public string FirstName;

        [Required]
        [Display(Name = "Last name:")]
        public string LastName;

        [Required]
        [Display(Name = "Mobile number:")]
        public string MobileNumber;
    }
}
