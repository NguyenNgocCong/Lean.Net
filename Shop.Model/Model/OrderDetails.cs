using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Model.Model
{
    public class OrderDetails
    {
        public int OrderID { get; set; }
        public int ProductID { get; set; }
        public int Quantity { get; set; }
        [ForeignKey("OrderID")]
        public virtual Orders Orders { get; set; }
        [ForeignKey("ProductID")]
        public virtual Products Products { get; set; }
    }
}
