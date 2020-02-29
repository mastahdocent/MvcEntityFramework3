using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Rozdzial3_C.Models
{
    [Table("Consultations")]
    public class ConsultationModel
    {
        public int ID { get; set; }
        [Required]
        public string Subject { get; set; }
        public string Description { get; set; }

        [ForeignKey("CustomerID")]
        public CustomerModel Customer { get; set; }

        public int CustomerID { get; set; }
    }
}
