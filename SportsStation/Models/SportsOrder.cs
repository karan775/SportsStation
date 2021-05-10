using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SportsStation.Models
{
    public class SportsOrder
    {
        [Key]
        public int OrderID { get; set; }

        [Required]
        [StringLength(1000)]
        public string Detail { get; set; }

        public DateTime OrderDate { get; set; }

        [Required]
        [StringLength(200)]
        public string UserID { get; set; }

        [Required]
        public int Quantity { get; set; }

        [Required]
        public float Price { get; set; }

        [Required]
        public float Total { get; set; }

        [Required]
        public int SportsID { get; set; }


        [ForeignKey("SportsID")]
        [InverseProperty("SportsOrders")]
        public virtual SportsMaterial SportsMaterial { get; set; }
    }
}
