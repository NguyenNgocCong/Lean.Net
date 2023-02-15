using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Model.Model
{
    [Table("VisitorStatistics")]
    public class VisitorStatistics
    {
        [Key]
        public Guid ID { get; set; }
        [Required]
        public DateTime VisitedDate { get; set; }
        [Required]
        [MaxLength(50)]
        public string IPAdress { get; set; }
    }
}
