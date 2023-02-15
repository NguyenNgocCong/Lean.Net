using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Shop.Model.Model
{
    [Table("ProductTags")]
    public class ProductTags
    {
        [Key]
        public int ProductID { get; set; }
        [Key]
        [Column(TypeName = "varchar")]
        [MaxLength(50)]
        public int TagID { get; set; }

        [ForeignKey("ProductID")]
        public virtual Products Products { get; set; }

        [ForeignKey("TagID")]
        public virtual Tags Tags { get; set; }
    }
}