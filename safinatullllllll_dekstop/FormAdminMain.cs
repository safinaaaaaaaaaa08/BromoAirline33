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
    public partial class FormAdminMain : Form
    {
        public FormAdminMain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (menuStrip1.Visible==false)
            {
                menuStrip1.Visible = true;
            }
            else
            { menuStrip1.Visible = false; }
        }

        private void masterBandaraToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            FormMasterBandara form = new FormMasterBandara();
            form.ShowDialog();


        }

        private void masterMaskapaiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            FormMasterMaskapai form = new FormMasterMaskapai();
            form.ShowDialog();
        }

        private void masterKodePromoToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            FormMasterKodePromo form = new FormMasterKodePromo();
            form.ShowDialog();
        }

        private void masterJadwalPenerbanganToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            FormJadwalPenerbangan form = new FormJadwalPenerbangan();
            form.ShowDialog();
        }

        private void ubahStatusPenerbanganToolStripMenuItem_Click(object sender, EventArgs e)
        {
         
            FormUbahStatusP form = new FormUbahStatusP();
            form.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
           FormLogin formLogin = new FormLogin();
            formLogin.ShowDialog();
        }
    }
}
