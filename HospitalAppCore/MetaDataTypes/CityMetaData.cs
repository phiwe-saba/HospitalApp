using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalAppCore.MetaDataTypes
{
    [MetadataType(typeof(CityMetaData))]
    public partial class City { }
    public class CityMetaData
    {
        [Required]
        [Display(Name = "City")]
        public string CityName;
    }
}
