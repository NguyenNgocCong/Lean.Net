using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Model.Abstract
{
    public interface IPost
    {
        [Required]
        string Name { get; set; }
        [Required]
        string Alias { get; set; }
        string Description { get; set; }
        string Image { get; set; }
        string MetaKeyword { get; set; }
        string MetaDescription { get; set; } 
        DateTime CreatedDate { get; set; }
        [MaxLength(50)]
        string CreatedBy { get; set; }
        DateTime UpdatedDate { get;set; }
        [MaxLength(50)]
        string UpdatedBy { get; set; }
        bool HomePlag { get; set; }
        [Required]
        bool Status { get; set; }
    }
}
