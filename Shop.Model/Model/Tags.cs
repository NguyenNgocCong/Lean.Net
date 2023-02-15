using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Model.Model
{
    public class Tags
    {
        [Key]
        public String ID { get; set; }
        [Required]
        public String Name { get; set; }
        public String Type { get; set; }
        public virtual IEnumerable<ProductTags> ProductTags { get; set; }
        public virtual IEnumerable<PostTags> PostTags { get; set; }
    }
}
