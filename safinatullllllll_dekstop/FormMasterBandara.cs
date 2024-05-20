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
    public partial class FormMasterBandara : Form
    {
        public FormMasterBandara()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void menuStrip1_ItemClicked_1(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void masterBandaraToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add("Abdul", "MLG", "Malang", "Indonesia", "2", "Malang");
            dataGridView1.Rows.Add("Abresso", "RSK", "Manokwari", "Indonesia", "2", "Manokwari");
            dataGridView1.Rows.Add("Achmad Yani", "SRG", "Semarang", "Indonesia", "2", "Semarang");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void menuStrip1_ItemClicked_2(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            comboBox1.Text = "";
            numericUpDown1.Text = "";
            textBox4.Text = "";
        }
    }
}
