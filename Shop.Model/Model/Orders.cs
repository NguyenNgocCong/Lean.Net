using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Model.Model
{
    public class Orders
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public string CustomerName { get; set; }
        [Required]
        public string CustomerAddress { get; set; }
        [Required]
        public string CustomerEmail { get; set; }
        [Required]
        public string CustomerMobile { get; set; }
        public string CustomerMessage { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public string PaymentMethod { get; set; }
        [MaxLength(50)]
        public string PaymentStatus { get; set; }
        [Required]
        public bool Status { get; set; }
        public virtual IEnumerable<OrderDetails> OrderDetails { get; set; }

    }
}
