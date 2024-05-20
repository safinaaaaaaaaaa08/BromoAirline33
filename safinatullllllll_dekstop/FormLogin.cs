using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace safinatullllllll_dekstop
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            FormDaftarAkun form2 = new FormDaftarAkun();
            form2.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
            
        {
            this.Hide();
            FormCustomerMain form9 = new FormCustomerMain();
            form9.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }
    }
}
