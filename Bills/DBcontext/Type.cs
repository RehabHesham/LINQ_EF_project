using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bills.DBcontext
{
    public class Type
    {
        [Key]
        public int Typ_id { get; set; }
        [Required]
        [StringLength(150)]
        [Index(IsUnique = true)]
        public string Typ_name { get; set; }
        [StringLength(500)]
        public string Typ_notes { get; set; }
        [Required]
        [ForeignKey("Comp")]
        public int Comp_id { get; set; }

        //Navigation Property
        public virtual Company Comp { get; set; }
    }
}
