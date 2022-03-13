using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bills.ItemForm
{
    public partial class Item_Form : Form
    {
        public Item_Form()
        {
            InitializeComponent();
            Spliter.Panel2Collapsed = true;
            Spliter.Panel1Collapsed = false;
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
