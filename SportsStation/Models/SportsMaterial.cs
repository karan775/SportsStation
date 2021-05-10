using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SportsStation.Models
{
    public class SportsMaterial
    {
        [Key]
        public int SportsID { get; set; }

        [Required]
        [StringLength(200)]
        public string ProductName { get; set; }

        [Required]
        [StringLength(1000)]
        public string Detail { get; set; }

        [Required]
        [StringLength(20)]
        public string Extension { get; set; }

        [Required]
        public float Price { get; set; }


        [Required]
        public int SportsBrandID { get; set; }

        [Required]
        public int SportsCategoryID { get; set; }

        [ForeignKey("SportsBrandID")]
        [InverseProperty("SportsBrandSportsMaterial")]
        public virtual SportsBrand SportsBrand { get; set; }

        [ForeignKey("SportsCategoryID")]
        [InverseProperty("SportsCategorySportsMaterial")]
        public virtual SportsCategory SportsCategorySportsMaterial { get; set; }

        public virtual ICollection<SportsOrder> SportsOrders { get; set; }

        [NotMapped]
        public SingleFileUpload File { get; set; }

    }

    public class SingleFileUpload
    {
        [Required]
        [Display(Name = "File")]
        public IFormFile FormFile { get; set; }
    }
}
