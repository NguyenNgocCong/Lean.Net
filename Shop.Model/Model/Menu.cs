using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Shop.Model.Model
{
    [Table("Menu")]
    public class Menu
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Required]
        [MaxLength(50)]
        public String Name { get; set; }

        [Required]
        [MaxLength(256)]
        public String URL { get; set; }

        public int? DisplayOrder { get; set; }

        [Required]
        public int GroupID { get; set; }
        [ForeignKey("GroupID")]
        public virtual MenuGroup MenuGroup { get; set; }
        [MaxLength(10)]
        public String Target { get; set; }

        [Required]
        public bool Status { get; set; }
    }
}