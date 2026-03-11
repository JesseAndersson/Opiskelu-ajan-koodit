using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ohj._2_Lopputyö.Model;
using Newtonsoft.Json;
using System.IO;

namespace Ohj._2_Lopputyö
{
    public partial class Form3 : Form
    {

        // Tekijät: Susanna Inkiläinen ETA21SP & Jesse Andersson ETA21SP

        public static List<Pelaaja> Pelaajat = new List<Pelaaja>();
        public static List<Pelaaja> Currentplayers = new List<Pelaaja>();

        public Form3()
        {
            InitializeComponent();

            if (cbPelaaja1.Text != string.Empty)
            {
                btnAloita.Enabled = true;
            }
            else if (cbPelaaja1.Text == string.Empty)
            {
                btnAloita.Enabled = false;
            }


            Pelaajat = DeserializeJSON();

            populatePelaajatDgv(Pelaajat);
            
        }

        public static bool BTietokone;
        public static bool TietokoneVaikea;
        public static bool TietokoneMahdoton;

        public string path = @"c:/temp/jsontiedot.json";

        public string json;

        public List<Pelaaja> DeserializeJSON()
        {
            try
            {
                if (File.Exists(path))
                {
                    using (StreamReader sr = new StreamReader(path))
                    {
                        json = sr.ReadToEnd();

                        return JsonConvert.DeserializeObject<List<Pelaaja>>(json);
                    }
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        private void cbxTietokone_CheckedChanged(object sender, EventArgs e) // Tarkistetaan onko tietokone pelaaja painettuna ja vaikeustaso
        {
            if (cbPelaaja2.Enabled == true)
            {
                cbPelaaja2.Enabled = false;
            }
            else if (cbPelaaja2.Enabled == false)
            {
                cbPelaaja2.Enabled = true;
            }

            if (CbxTietokone.Checked == true && CbxVaikea.Checked == false && cbxMahdoton.Checked == false)
            {
                CbxHelppo.Checked = true;
            }
            else if (CbxTietokone.Checked == false)
            {
                CbxHelppo.Checked = false;
                CbxVaikea.Checked = false;
                cbxMahdoton.Checked = false;
            }
        }
        private void CbxHelppo_CheckedChanged(object sender, EventArgs e)
        {
            if (CbxHelppo.Checked == true && CbxTietokone.Checked == true)
            {
                CbxVaikea.Checked = false;
                cbxMahdoton.Checked = false;
            }

            if (CbxHelppo.Checked == true && CbxTietokone.Checked == false)
            {
                CbxTietokone.Checked = true;
            }
        }
        private void CbxVaikea_CheckedChanged(object sender, EventArgs e)
        {
            if (CbxVaikea.Checked == true && CbxTietokone.Checked == true)
            {
                CbxHelppo.Checked = false;
                cbxMahdoton.Checked = false;
            }

            if (CbxVaikea.Checked == true && CbxTietokone.Checked == false)
            {
                CbxTietokone.Checked = true;
            }
        }
        private void cbxMahdoton_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxMahdoton.Checked == true && CbxTietokone.Checked == true)
            {
                CbxHelppo.Checked = false;
                CbxVaikea.Checked = false;
            }

            if (cbxMahdoton.Checked == true && CbxTietokone.Checked == false)
            {
                CbxTietokone.Checked = true;
            }
        }

        private void btnAloita_Click(object sender, EventArgs e)
        {
            Currentplayers.Clear();

            BTietokone = CbxTietokone.Checked; // otetaan tieto tietokone checkboxista talteen

            Pelaaja p1 = new Pelaaja();
            p1.Etunimi = cbPelaaja1.Text;
            p1.Voitot = 0;
            p1.Haviot = 0;
            p1.Tasapelit = 0;
            p1.PelienKesto = "00:00:00";

            Currentplayers.Add(p1);

            if (BTietokone == false)
            {
                Pelaaja p2 = new Pelaaja();
                p2.Etunimi = cbPelaaja2.Text;
                p2.Voitot = 0;
                p2.Haviot = 0;
                p2.Tasapelit = 0;
                p2.PelienKesto = "00:00:00";

                Currentplayers.Add(p2);
            }


            TietokoneVaikea = CbxVaikea.Checked;
            TietokoneMahdoton = cbxMahdoton.Checked;
            Form1 Peli = new Form1(this);
            Peli.ShowDialog();
        }
        private void lopetaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void btnUusiPelaaja_Click(object sender, EventArgs e)
        {
            Form2 Kysely = new Form2(this);
            Kysely.ShowDialog();
        }

        public void populatePelaajatDgv(List<Pelaaja> Pelaajat) // lisätään listan sisältö DGV
        {
            BindingSource source = new BindingSource();
            source.DataSource = Pelaajat;
            dgvPelaajat.DataSource = source;
        }

        private void HelpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Apua a = new Apua();
            a.ShowDialog();
        }

        private void cbPelaaja1_MouseClick(object sender, MouseEventArgs e)
        {
            cbPelaaja1.Items.Clear();
            foreach (DataGridViewRow row in dgvPelaajat.Rows) // tällä tuodaan DGV:stä tiedot
            {
                cbPelaaja1.Items.Add(row.Cells[0].Value.ToString()); // Valitaan DGV:n palsta, josta tieto poimitaan.
            }
        }

        private void cbPelaaja2_MouseClick(object sender, MouseEventArgs e) // toistetaan sama kuin yläpuolella.
        {
            cbPelaaja2.Items.Clear();
            foreach (DataGridViewRow row in dgvPelaajat.Rows)
            {
                cbPelaaja2.Items.Add(row.Cells[0].Value.ToString());
            }
        }

        private void cbPelaaja1_SelectedIndexChanged(object sender, EventArgs e) // ei voida aloittaa ilman että on pelaaja valittuna
        {
            if (cbPelaaja1.Text != string.Empty)
            {
                btnAloita.Enabled = true;
            }
            else if (cbPelaaja1.Text == string.Empty)
            {
                btnAloita.Enabled = false;
            }
        }
    }
}
