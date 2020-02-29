using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Rozdzial3_C.Models
{
    public class CustomerModel
    {
        public int ID { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        public int Age { get; set; }
        public DateTime DateAdded { get; set; }
        public DateTime? DateUpdated { get; set; }

        public AddressModel Address { get; set; }
        public ICollection<ConsultationModel> Consultations { get; set; }
        public ICollection<TransactionModel> Transactions { get; set; }
    }
}
