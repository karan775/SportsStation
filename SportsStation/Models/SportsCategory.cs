using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SportsStation.Models
{
    public class SportsCategory
    {
        [Key]
        public int SportsCategoryID { get; set; }

        [Required]
        [StringLength(100)]
        public string SportsCategoryName { get; set; }

        public virtual ICollection<SportsMaterial> SportsCategorySportsMaterial { get; set; }
    }
}
