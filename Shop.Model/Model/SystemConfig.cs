using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Model.Model
{
    public class SystemConfig
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public string Code { get; set; }
        public string ValueString { get; set; }
        public int ValueInt { get; set; }
    }
}
