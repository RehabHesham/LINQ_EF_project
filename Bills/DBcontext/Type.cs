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
        public int typ_id { get; set; }
        [Required]
        [StringLength(150)]
        [Index(IsUnique = true)]
        public string typ_name { get; set; }
        [StringLength(500)]
        public string typ_notes { get; set; }
        [Required]
        [ForeignKey("type_comp")]
        public int comp_id { get; set; }

        //Navigation Property
        public virtual Company type_comp { get; set; }
        public virtual ICollection<Item> type_items { get; set; }
    }
}
