using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Rozdzial3_C.Models
{
    public class AddressModel
    {
        public int ID { get; set; }
        [Required]
        public string Street { get; set; }
        [Required]
        public string PostalCode { get; set; }
        [Required]
        public string City { get; set; }

        [ForeignKey("ID")]
        public CustomerModel Customer { get; set; }
    }
}
