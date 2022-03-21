using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalAppCore.MetaDataTypes
{
    [MetadataType(typeof(ProvinceMetaData))]
    public partial class Province { }
    public class ProvinceMetaData
    {
        [Required]
        [Display(Name = "Province")]
        public string ProvinceName;
    }
}
