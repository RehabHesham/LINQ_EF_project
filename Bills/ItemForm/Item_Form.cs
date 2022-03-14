using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bills.DBcontext;

namespace Bills.ItemForm
{
    public partial class Item_Form : Form
    {
        public Item_Form()
        {
            InitializeComponent();
            Spliter.Panel2Collapsed = true;
            Spliter.Panel1Collapsed = false;
            BillSystemDB billSystem = new BillSystemDB();
            Company c = new Company();
           // DBcontext.Type type = new DBcontext.Type();
            //type.type_comp_obj.compan_id = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Spliter.Panel2Collapsed = false;
            Spliter.Panel1Collapsed = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Spliter.Panel2Collapsed = true;
            Spliter.Panel1Collapsed = false;
        }
    }
}
