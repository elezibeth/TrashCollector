using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TrashCollector.Models
{
    public class PauseService
    {

        [Key]
        public int Id { get; set; }

        [Display(Name = "Pause Service Start and End Dates")]
        [DataType(DataType.Duration)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        

        [ForeignKey("Customer")]
        public int CustomerZip { get; set; }
        public Customer Customer { get; set; }

 

    }
}
