using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bills.DBcontext
{
    public class Item
    {
        [Key]
        public int it_id { get; set; }
        [Required(ErrorMessage = "ITEM NAME is Required")]
        [StringLength(150)]
        [Index(IsUnique = true)]
        public string it_name { get; set; }
        [StringLength(500)]
        public string it_notes { get; set; }
        [Range(0,double.MaxValue)]
        [Column(TypeName ="money")]
        public double buy_price { get; set; }
        [Range(0, double.MaxValue)]
        [Column(TypeName = "money")]
        public double sell_price { get; set; }

        [Required(ErrorMessage = "COMPANY NAME is Required")]
        [ForeignKey("item_comp")]
        public int comp_id { get; set; }
        [Required(ErrorMessage = "TYPE NAME is Required")]
        [ForeignKey("item_type")]
        public int type_id { get; set; }

        //Navigation Property
        public virtual Company item_comp { get; set; }
        public virtual Type item_type { get; set; }
    }
}
