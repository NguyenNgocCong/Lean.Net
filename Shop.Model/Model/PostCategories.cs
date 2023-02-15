using Shop.Model.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Model.Model
{
    [Table("PostCategories")]
    public  class PostCategories :AbstractPost
    {
        [Key]
        public int ID { get; set; }
        public int ParentID { get; set; }
        public int DisplayOrder { get; set; }
        public virtual IEnumerable<Post> Post { get; set; }
    }
}
