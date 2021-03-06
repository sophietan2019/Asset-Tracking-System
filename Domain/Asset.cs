﻿
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Domain
{

    [Table("Asset")]
    public class Asset
    {
        [Required]
        public int Id { get; set; }
        
        [Required] [Display (Name ="Tag Number")]
        public string TagNumber { get; set; }

        [Required] [Display(Name="Asset Type")]
        public int AssetTypeId { get; set; }


        [Required]
        public string Manufacturer { get; set; }
     
        public string? Model { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]  [Display(Name = "Serial Number")]
        public string SerialNumber { get; set; }

        //navigation property
        public AssetType AssetType { get; set; }



    }
 
}
