using Shop.Model.Abstract;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;

namespace Shop.Model.Model
{
    [Table("Product")]
    public class Products : Auditatble

    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Alias { get; set; }

        public int CategoryID { get; set; }
        public string Image { get; set; }
        public XElement MoreImage { get; set; }

        [Required]
        public decimal Price { get; set; }

        public decimal? Promotion { get; set; }
        public int? Waranty { get; set; }
        public string Description { get; set; }
        public string Content { get; set; }

        public bool? HomeFlag { get; set; }
        public bool? HotFlag { get; set; }
        public int? ViewCount { get; set; }

        [ForeignKey("CategoryID")]
        public virtual ProductCategory ProductCategory { get; set; }
        public virtual IEnumerable<ProductTags> ProductTags { get; set; }
    }
}