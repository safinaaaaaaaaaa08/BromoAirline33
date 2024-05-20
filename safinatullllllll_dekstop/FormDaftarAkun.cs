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
    public partial class FormDaftarAkun : Form
    {
        public FormDaftarAkun()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormAdminMain form3 = new FormAdminMain();
            form3.ShowDialog();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            FormLogin form1 = new FormLogin();  
            form1.ShowDialog();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
           
        }
    }
}
