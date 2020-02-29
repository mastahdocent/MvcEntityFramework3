using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Rozdzial3_C.Models
{
    public class TransactionModel
    {
        public int ID { get; set; }
        public DateTime Date { get; set; }

        public int CustomerID { get; set; }

        [ForeignKey("CustomerID")]
        public CustomerModel Customer { get; set; }

        public int ProductID { get; set; }
        [ForeignKey("ProductID")]
        public ProductModel Product { get; set; }
    }
}
