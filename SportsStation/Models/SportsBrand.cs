using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SportsStation.Models
{
    public class SportsBrand
    {
        [Key]
        public int SportsBrandID { get; set; }

        [Required]
        [StringLength(100)]
        public string SportsBrandName { get; set; }

        public virtual ICollection<SportsMaterial> SportsBrandSportsMaterial { get; set; }
    }
}
