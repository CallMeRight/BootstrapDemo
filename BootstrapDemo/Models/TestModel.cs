using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BootstrapDemo.Models
{
    [Table("")]
    public class TestModel
    {
        [Required]
        public int MyProperty1 { get; set; }
        [Required]
        public string MyProperty2 { get; set; }
        [Required]
        public string MyProperty3 { get; set; }
        
    }
}
