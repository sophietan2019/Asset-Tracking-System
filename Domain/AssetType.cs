using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Domain
{
    [Table("AssetType")]
    public class AssetType
    {
        public int Id { get; set; }

        [Required] [Display(Name = "Asset Type")]
        public string Name { get; set; }
        
        public ICollection<Asset>  Assets { get; set; }        //navigation property
    }
}
