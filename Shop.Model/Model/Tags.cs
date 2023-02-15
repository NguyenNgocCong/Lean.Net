using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Model.Model
{
    [Table("Tags")]
    public class Tags
    {
        [Key]
        [MaxLength(50)]
        public String ID { get; set; }
        [Required]
        [MaxLength(50)]
        public String Name { get; set; }
        [Required]
        [MaxLength(50)]
        public String Type { get; set; }
        public virtual IEnumerable<ProductTags> ProductTags { get; set; }
        public virtual IEnumerable<PostTags> PostTags { get; set; }
    }
}
