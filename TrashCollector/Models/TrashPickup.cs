using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TrashCollector.Models
{
    public class TrashPickup
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "One time pickup date")]
        public int Date { get; set; }
        public int Time { get; set; }
        [ForeignKey("Customer")]
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
        
    }
}
