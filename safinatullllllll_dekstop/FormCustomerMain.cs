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
    public partial class FormCustomerMain : Form
    {
        public FormCustomerMain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormListPenerbangan form10 = new FormListPenerbangan();
            form10.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormLogin form1 = new FormLogin();
            form1.ShowDialog();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            FormTiketSaya form12 = new FormTiketSaya();
            form12.ShowDialog();
        }
    }
}
