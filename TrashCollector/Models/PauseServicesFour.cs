using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TrashCollector.Models
{
    public class PauseServicesFour
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Pause Service Start and End Dates")]
        [DataType(DataType.Duration)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        [Display(Name = "Enter your zip code.")]
        public int CustomerZip { get; set; }
        [Display(Name = "First Name:")]
        public string CustomerFirstName { get; set; }
        [Display(Name = "Last Name:")]
        public string CustomerLastName { get; set; }

        public int CustomerId { get; set; }

    }
}
