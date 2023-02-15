using Shop.Model.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Model.Model
{
    public class Post :AbstractPost
    {
        [Key]
        public int ID { get; set; }
        public int CategoryID { get; set; }
        public string Content { get; set; }
        public bool HotFlag { get; set; }
        public int ViewCount { get; set; }
       
    }
}
