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
        public int comp_id { get; set; }
        [Required]
        [StringLength(150)]
        [Index(IsUnique = true)]
        public string comp_name { get; set; }
        [StringLength(500)]
        public string comp_notes { get; set; }

        //Navigation Property
        public virtual ICollection<Type> comp_types { get; set; }
        public virtual ICollection<Item> comp_items { get; set; }

    }
}
