using Microsoft.Build.Evaluation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalAppCore.MetaDataTypes
{
    [MetadataType(typeof(PatientMetaData))]
    public partial class Patient { }
    public class PatientMetaData
    {
        [Required]
        [Display(Name = "Full names:")]
        public string FullNames;

        [Required]
        [Display(Name = "Gender:")]
        public string Gender;

        [Required]
        [Display(Name = "Date of birth:")]
        public DateTime DOB;

        [Required]
        [Display(Name = "Mobile number:")]
        public string MobileNumber;

        [Required]
        [Display(Name = "Email address:")]
        public string EmailAddress;

    }
}
