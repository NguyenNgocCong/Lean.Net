using System;
using System.ComponentModel.DataAnnotations;

namespace Shop.Model.Abstract
{
    public interface IAuditable
    {
         DateTime? CreatedDate { get; set; }
        [MaxLength(256)]
        String CreatedBy { get; set; }
         DateTime? UpdatedDate { get; set; }
        [MaxLength(256)]
        String UpdateBy { get; set; }
        [MaxLength(256)]
        String MetaKeyWord { get; set; }
        [MaxLength(256)]
        String MetaDescription { get; set; }
        bool Status { get; set; }
    }
}