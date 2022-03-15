using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bills.UI
{
    public partial class MainForm : Form
    {
        MainForm mainForm;
        public MainForm()
        {
            InitializeComponent();
            mainForm = this;
            home_img home = new home_img() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            mainForm.pan_content.Controls.Add(home);
            home.Show();
        }


        private void MainForm_Load(object sender, EventArgs e)
        {
            Form myForm = sender as Form;
            if(myForm != mainForm)
            {
                mainForm.pan_content.Controls.Clear();
                myForm.AutoScroll = true;
                mainForm.pan_content.Controls.Add(myForm);
                myForm.Show();
            }
        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            MainForm_Load(new home_img() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true }, null);
        }

        private void btn_company_Click(object sender, EventArgs e)
        {
            MainForm_Load(new companyForm() { Dock = DockStyle.Fill,TopLevel=false,TopMost=true}, null);
        }
    }
}
