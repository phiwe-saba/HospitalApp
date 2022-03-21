using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalAppCore.MetaDataTypes
{
    [MetadataType(typeof(AddressMetaData))]
    public partial class Address { }
    public class AddressMetaData
    {
        [Required]
        [Display(Name = "Address Line 1:")]
        public string AddressLine1;

        [Required]
        [Display(Name = "Address Line 2:")]
        public string AddressLine2;

        [Required]
        [Display(Name = "Suburb:")]
        public string SuburbName;

        [Required]
        [Display(Name = "City:")]
        public string CityName;

        [Required]
        [Display(Name = "Province:")]
        public string ProvinceName;

        [Required]
        [Display(Name = "Postal code:")]
        public string PostalCode;
    }
}
