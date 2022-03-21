using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalAppCore.MetaDataTypes
{
    [MetadataType(typeof(SuburbMetaData))]
    public partial class Suburb { }
    public class SuburbMetaData
    {
        [Required]
        [Display(Name = "Suburb")]
        public string SuburbName;
    }
}
