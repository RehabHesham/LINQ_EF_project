using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bills.DBcontext
{
    public class Client
    {
        [Key]
        public int client_id{ get; set; }
        [Required(ErrorMessage = "“CLIENT NAME is Required")]
        [StringLength(150)]
        [Index(IsUnique = true)]
        public string client_name { get; set; }
        [Required(ErrorMessage = "Address is Required")]
        [StringLength(250)]
        public string client_address { get; set;}
        [Required(ErrorMessage = "PHONE is Required")]
        [MinLength(14),MaxLength(14)]
        [DataType(DataType.PhoneNumber)]
        public String client_phone { get; set; }

        //Navigation Property
        public virtual ICollection<Sales_Invoice> client_sales_Invoices { get;}
    }
}
