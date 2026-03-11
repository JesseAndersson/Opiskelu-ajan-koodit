using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ohj._2_Lopputyö
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        public static bool BTietokone;

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (cbPelaaja2.Enabled == true)
            {
                cbPelaaja2.Enabled = false;
            }
            else if (cbPelaaja2.Enabled == false)
            {
                cbPelaaja2.Enabled = true;
            }
        }

        private void btnAloita_Click(object sender, EventArgs e)
        {
            BTietokone = CbTietokone.Checked; // otetaan tieto tietokone checkboxista talteen
            Form1 Peli = new Form1();
            Peli.ShowDialog();
            
        }
        private void lopetaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void apuaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Apua a = new Apua();
            a.ShowDialog();
        }

        private void btnUusiPelaaja_Click(object sender, EventArgs e)
        {
            Form2 Kysely = new Form2();
            Kysely.ShowDialog();
        }
    }
}
