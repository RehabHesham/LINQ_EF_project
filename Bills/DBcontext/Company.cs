using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bills.DBcontext
{
    public class Company
    {
        [Key]
        public int Comp_id { get; set; }
        [Required]
        [StringLength(150)]
        [Index(IsUnique = true)]
        public string Comp_name { get; set; }
        [StringLength(500)]
        public string Comp_notes { get; set; }
    }
}
