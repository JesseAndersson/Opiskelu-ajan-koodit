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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            timer1.Start(); // alotetaan kello varmaan samantien kun avataan peli ?
            //tarvii ehkä kutsua tota tietokone fuktiota
        }

        int Vuorot = 0;
        int Vuoro = 0; // 0 = risti, 1 = nolla

        int[] ristinolla = {-1, -1, -1, -1, -1, -1, -1, -1, -1};
        // 9 alkioinen taulukko, kaikki valitsematta
        // -1 = valitsematta
        // 0 = nolla
        // 1 = risti
        Random rnd = new Random();

        private void DrawElements(Panel panel)
        {
            System.Drawing.SolidBrush PensseliSeta = new System.Drawing.SolidBrush(System.Drawing.Color.Red);
            System.Drawing.Graphics formGraphics;
            formGraphics = panel.CreateGraphics();

            int index = int.Parse(panel.Tag.ToString());
            Pen p = new Pen(PensseliSeta, 3);

            if (ristinolla[index] == 0) // Pelaaja 1
            {
                formGraphics.DrawLine(p, 25, 25, 75, 75); //viiva
                formGraphics.DrawLine(p, 75, 25, 25, 75); //toinen viiva vastakkaiseen suuntaan
            }
            else if (ristinolla[index] == 1) // Pelaaja 2
            {
                formGraphics.DrawEllipse(p, new Rectangle(25, 25, 75 - 25, 75 - 25)); // Pallo eiiiku PYMPYRÄ eiku PYLPYRÄ
            }

            PensseliSeta.Dispose();
            formGraphics.Dispose();
        }

        private void Tietokone(object sender, EventArgs e)
        {
            bool Tietokone = Form3.BTietokone; // saadaan onko tietokone nappi painettu aloitus formissa

            if (Tietokone == checked(true))
            {
                Tietokonepelaaja();
            }
        }

        private void Tietokonepelaaja()
        {
            // ei toimi varmastikkaan vielä, pitää jatkaa tätä
            if (Vuorot % 2 != 0) // tietokone pelaa toisena eli parittomilla
            {
                int index = rnd.Next(0, 9);

                while (ristinolla[index] == -1)
                {
                    index = rnd.Next(0, 9);
                }
                
                ristinolla[index] = Vuoro;
                Vuoro = Vuoro == 0 ? 1 : 0;
                Refresh();
            }
        }

        private void Tarkistus()
        {
            // vaihdetaan panelien back color kun tulee voitto, pitää keksiä iffin ehto DONE

            if (ristinolla[0] == 1 && ristinolla[1] == 1 && ristinolla[2] == 1) //eka rivi X
            {
                panel0.BackColor = Color.ForestGreen; // päätetään joku väri sitten yhessä et mikä ois hyvä =)
                panel1.BackColor = Color.ForestGreen;
                panel2.BackColor = Color.ForestGreen;

                timer1.Stop(); // pysäytetään kello (toki se pitää laittaa joskus käytiin)
                DialogResult DR;
                DR = MessageBox.Show("Winner winner chicken dinner :D ", "VOITIT");
                if (DR == DialogResult.OK)
                {
                    DR = MessageBox.Show("Pelataanko uudestaan?", "Jatketaanko", MessageBoxButtons.YesNo);
                    
                    if (DR == DialogResult.Yes)
                    {
                        Uusipeli();
                    }
                    else if (DR == DialogResult.No)
                    {
                        Close(); // tai vaihdetaan return niin palaa pei formiin jolloin voi jäädä tarkastelemaan sitä 
                    }
                }
            }
            else if (ristinolla[3] == 1 && ristinolla[4] == 1 && ristinolla[5] == 1) //toka rivi X
            {
                panel3.BackColor = Color.ForestGreen;
                panel4.BackColor = Color.ForestGreen;
                panel5.BackColor = Color.ForestGreen;

                timer1.Stop();
                DialogResult DR;
                DR = MessageBox.Show("Winner winner chicken dinner :D ", "VOITIT");
                if (DR == DialogResult.OK)
                {
                    DR = MessageBox.Show("Pelataanko uudestaan?", "Jatketaanko", MessageBoxButtons.YesNo);

                    if (DR == DialogResult.Yes)
                    {
                        Uusipeli();
                    }
                    else if (DR == DialogResult.No)
                    {
                        Close();
                    }
                }
            }
            else if(ristinolla[6] == 1 && ristinolla[7] == 1 && ristinolla[8] == 1) //kolmas rivi X
            {
                panel6.BackColor = Color.ForestGreen;
                panel7.BackColor = Color.ForestGreen;
                panel8.BackColor = Color.ForestGreen;

                timer1.Stop();
                DialogResult DR;
                DR = MessageBox.Show("Winner winner chicken dinner :D ", "VOITIT");
                if (DR == DialogResult.OK)
                {
                    DR = MessageBox.Show("Pelataanko uudestaan?", "Jatketaanko", MessageBoxButtons.YesNo);

                    if (DR == DialogResult.Yes)
                    {
                        Uusipeli();
                    }
                    else if (DR == DialogResult.No)
                    {
                        Close();
                    }
                }
            }
            else if(ristinolla[0] == 1 && ristinolla[3] == 1 && ristinolla[6] == 1) // eka pysty X
            {
                panel0.BackColor = Color.ForestGreen;
                panel3.BackColor = Color.ForestGreen;
                panel6.BackColor = Color.ForestGreen;

                timer1.Stop();
                DialogResult DR;
                DR = MessageBox.Show("Winner winner chicken dinner :D ", "VOITIT");
                if (DR == DialogResult.OK)
                {
                    DR = MessageBox.Show("Pelataanko uudestaan?", "Jatketaanko", MessageBoxButtons.YesNo);

                    if (DR == DialogResult.Yes)
                    {
                        Uusipeli();
                    }
                    else if (DR == DialogResult.No)
                    {
                        Close();
                    }
                }
            }
            else if(ristinolla[1] == 1 && ristinolla[4] == 1 && ristinolla[7] == 1) // toka pysty X
            {
                panel1.BackColor = Color.ForestGreen;
                panel4.BackColor = Color.ForestGreen;
                panel7.BackColor = Color.ForestGreen;

                timer1.Stop();
                DialogResult DR;
                DR = MessageBox.Show("Winner winner chicken dinner :D ", "VOITIT");
                if (DR == DialogResult.OK)
                {
                    DR = MessageBox.Show("Pelataanko uudestaan?", "Jatketaanko", MessageBoxButtons.YesNo);

                    if (DR == DialogResult.Yes)
                    {
                        Uusipeli();
                    }
                    else if (DR == DialogResult.No)
                    {
                        Close();
                    }
                }
            }
            else if(ristinolla[2] == 1 && ristinolla[5] == 1 && ristinolla[8] == 1) // kolmas pysty X
            {
                panel2.BackColor = Color.ForestGreen;
                panel5.BackColor = Color.ForestGreen;
                panel8.BackColor = Color.ForestGreen;

                timer1.Stop();
                DialogResult DR;
                DR = MessageBox.Show("Winner winner chicken dinner :D ", "VOITIT");
                if (DR == DialogResult.OK)
                {
                    DR = MessageBox.Show("Pelataanko uudestaan?", "Jatketaanko", MessageBoxButtons.YesNo);

                    if (DR == DialogResult.Yes)
                    {
                        Uusipeli();
                    }
                    else if (DR == DialogResult.No)
                    {
                        Close();
                    }
                }
            }
            else if(ristinolla[0] == 1 && ristinolla[4] == 1 && ristinolla[8] == 1) // vasen ylä oikea ala X
            {
                panel0.BackColor = Color.ForestGreen;
                panel4.BackColor = Color.ForestGreen;
                panel8.BackColor = Color.ForestGreen;

                timer1.Stop();
                DialogResult DR;
                DR = MessageBox.Show("Winner winner chicken dinner :D ", "VOITIT");
                if (DR == DialogResult.OK)
                {
                    DR = MessageBox.Show("Pelataanko uudestaan?", "Jatketaanko", MessageBoxButtons.YesNo);

                    if (DR == DialogResult.Yes)
                    {
                        Uusipeli();
                    }
                    else if (DR == DialogResult.No)
                    {
                        Close();
                    }
                }
            }
            else if(ristinolla[2] == 1 && ristinolla[4] == 1 && ristinolla[6] == 1) // oikea ylä vasen ala X
            {
                panel2.BackColor = Color.ForestGreen;
                panel4.BackColor = Color.ForestGreen;
                panel6.BackColor = Color.ForestGreen;

                timer1.Stop();
                DialogResult DR;
                DR = MessageBox.Show("Winner winner chicken dinner :D ", "VOITIT");
                if (DR == DialogResult.OK)
                {
                    DR = MessageBox.Show("Pelataanko uudestaan?", "Jatketaanko", MessageBoxButtons.YesNo);

                    if (DR == DialogResult.Yes)
                    {
                        Uusipeli();
                    }
                    else if (DR == DialogResult.No)
                    {
                        Close();
                    }
                }
            }
            else if(ristinolla[0] == 0 && ristinolla[1] == 0 && ristinolla[2] == 0) // eka rivi 0
            {
                panel0.BackColor = Color.ForestGreen;
                panel1.BackColor = Color.ForestGreen;
                panel2.BackColor = Color.ForestGreen;

                timer1.Stop();
                DialogResult DR;
                DR = MessageBox.Show("Winner winner chicken dinner :D ", "VOITIT");
                if (DR == DialogResult.OK)
                {
                    DR = MessageBox.Show("Pelataanko uudestaan?", "Jatketaanko", MessageBoxButtons.YesNo);

                    if (DR == DialogResult.Yes)
                    {
                        Uusipeli();
                    }
                    else if (DR == DialogResult.No)
                    {
                        Close();
                    }
                }
            }
            else if(ristinolla[3] == 0 && ristinolla[4] == 0 && ristinolla[5] == 0) // toka rivi 0
            { 
                panel3.BackColor = Color.ForestGreen;
                panel4.BackColor = Color.ForestGreen;
                panel5.BackColor = Color.ForestGreen;

                timer1.Stop();
                DialogResult DR;
                DR = MessageBox.Show("Winner winner chicken dinner :D ", "VOITIT");
                if (DR == DialogResult.OK)
                {
                    DR = MessageBox.Show("Pelataanko uudestaan?", "Jatketaanko", MessageBoxButtons.YesNo);

                    if (DR == DialogResult.Yes)
                    {
                        Uusipeli();
                    }
                    else if (DR == DialogResult.No)
                    {
                        Close();
                    }
                }
            }
            else if(ristinolla[6] == 0 && ristinolla[7] == 0 && ristinolla[8] == 0) // kolmas rivi 0
            {
                panel6.BackColor = Color.ForestGreen;
                panel7.BackColor = Color.ForestGreen;
                panel8.BackColor = Color.ForestGreen;

                timer1.Stop();
                DialogResult DR;
                DR = MessageBox.Show("Winner winner chicken dinner :D ", "VOITIT");
                if (DR == DialogResult.OK)
                {
                    DR = MessageBox.Show("Pelataanko uudestaan?", "Jatketaanko", MessageBoxButtons.YesNo);

                    if (DR == DialogResult.Yes)
                    {
                        Uusipeli();
                    }
                    else if (DR == DialogResult.No)
                    {
                        Close();
                    }
                }
            }
            else if(ristinolla[0] == 0 && ristinolla[3] == 0 && ristinolla[6] == 0) // eka pysty 0
            {
                panel0.BackColor = Color.ForestGreen;
                panel3.BackColor = Color.ForestGreen;
                panel6.BackColor = Color.ForestGreen;

                timer1.Stop();
                DialogResult DR;
                DR = MessageBox.Show("Winner winner chicken dinner :D ", "VOITIT");
                if (DR == DialogResult.OK)
                {
                    DR = MessageBox.Show("Pelataanko uudestaan?", "Jatketaanko", MessageBoxButtons.YesNo);

                    if (DR == DialogResult.Yes)
                    {
                        Uusipeli();
                    }
                    else if (DR == DialogResult.No)
                    {
                        Close();
                    }
                }
            }
            else if(ristinolla[1] == 0 && ristinolla[4] == 0 && ristinolla[7] == 0) // toka pysty 0
            {
                panel1.BackColor = Color.ForestGreen;
                panel4.BackColor = Color.ForestGreen;
                panel7.BackColor = Color.ForestGreen;

                timer1.Stop();
                DialogResult DR;
                DR = MessageBox.Show("Winner winner chicken dinner :D ", "VOITIT");
                if (DR == DialogResult.OK)
                {
                    DR = MessageBox.Show("Pelataanko uudestaan?", "Jatketaanko", MessageBoxButtons.YesNo);

                    if (DR == DialogResult.Yes)
                    {
                        Uusipeli();
                    }
                    else if (DR == DialogResult.No)
                    {
                        Close();
                    }
                }
            }
            else if(ristinolla[2] == 0 && ristinolla[5] == 0 && ristinolla[8] == 0) // kolmas pysty 0
            {
                panel2.BackColor = Color.ForestGreen;
                panel5.BackColor = Color.ForestGreen;
                panel8.BackColor = Color.ForestGreen;

                timer1.Stop();
                DialogResult DR;
                DR = MessageBox.Show("Winner winner chicken dinner :D ", "VOITIT");
                if (DR == DialogResult.OK)
                {
                    DR = MessageBox.Show("Pelataanko uudestaan?", "Jatketaanko", MessageBoxButtons.YesNo);

                    if (DR == DialogResult.Yes)
                    {
                        Uusipeli();
                    }
                    else if (DR == DialogResult.No)
                    {
                        Close();
                    }
                }
            }
            else if(ristinolla[0] == 0 && ristinolla[4] == 0 && ristinolla[8] == 0) // vasen ylä oikea ala 0
            {
                panel0.BackColor = Color.ForestGreen;
                panel4.BackColor = Color.ForestGreen;
                panel8.BackColor = Color.ForestGreen;

                timer1.Stop();
                DialogResult DR;
                DR = MessageBox.Show("Winner winner chicken dinner :D ", "VOITIT");
                if (DR == DialogResult.OK)
                {
                    DR = MessageBox.Show("Pelataanko uudestaan?", "Jatketaanko", MessageBoxButtons.YesNo);

                    if (DR == DialogResult.Yes)
                    {
                        Uusipeli();
                    }
                    else if (DR == DialogResult.No)
                    {
                        Close();
                    }
                }
            }
            else if(ristinolla[2] == 0 && ristinolla[4] == 0 && ristinolla[6] == 0) // oikea ylä vasen ala 0
            {
                panel2.BackColor = Color.ForestGreen;
                panel4.BackColor = Color.ForestGreen;
                panel6.BackColor = Color.ForestGreen;

                timer1.Stop();
                DialogResult DR;
                DR = MessageBox.Show("Winner winner chicken dinner :D ", "VOITIT");
                if (DR == DialogResult.OK)
                {
                    DR = MessageBox.Show("Pelataanko uudestaan?", "Jatketaanko", MessageBoxButtons.YesNo);

                    if (DR == DialogResult.Yes)
                    {
                        Uusipeli();
                    }
                    else if (DR == DialogResult.No)
                    {
                        Close();
                    }
                }
            }
            else if (Vuorot == 9)
            {
                timer1.Stop();
                DialogResult DR;
                DR = MessageBox.Show("Tasapeli paskiaiset xP ", "TASAPELI");
                if (DR == DialogResult.OK)
                {
                    DR = MessageBox.Show("Pelataanko uudestaan?", "Jatketaanko", MessageBoxButtons.YesNo);

                    if (DR == DialogResult.Yes)
                    {
                        Uusipeli();
                    }
                    else if (DR == DialogResult.No)
                    {
                        Close();
                    }
                }
            }
            
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Apua a = new Apua();
            a.ShowDialog();
        }

        private void lopetaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult Vastaus;
            Vastaus = MessageBox.Show("Haluatko varmasti lopettaa?", "Lopetetaanko?", MessageBoxButtons.YesNo);

            if (Vastaus == DialogResult.Yes)
            {
                DialogResult Tallennetaanko;
                Tallennetaanko = MessageBox.Show("Haluatko tallentaa?", "Tallennetaanko?", MessageBoxButtons.YesNo);

                if (Tallennetaanko == DialogResult.Yes)
                {
                    //Tallennus
                    Close();
                }
                else
                {
                    Close();
                }
            }
            else
            {
                return;
            }

        }

        private void panel_MouseClick(object sender, MouseEventArgs e)
        {

            int index = int.Parse(((Panel)sender).Tag.ToString());
            Vuorot++;

            if (ristinolla[index] == -1)
            {
                ristinolla[index] = Vuoro;
                Vuoro = Vuoro == 0 ? 1 : 0; // tarkistetaan onko 1 vai 0 ja vaihdetaan toiseksi
                ((Panel)sender).Refresh(); // kutsuu panel_paint automaattisesti
            }

            Tarkistus();
        }

        private void panel_Paint(object sender, PaintEventArgs e)
        {
            DrawElements((Panel)sender);
        }

        private void uusiPeliToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Uusipeli();
        }

        private void Uusipeli()
        {
            // tyhjennetään ruudut
            panel0.Invalidate();
            panel1.Invalidate();
            panel2.Invalidate();
            panel3.Invalidate();
            panel4.Invalidate();
            panel5.Invalidate();
            panel6.Invalidate();
            panel7.Invalidate();
            panel8.Invalidate();

            panel0.BackColor = Color.White;
            panel1.BackColor = Color.Black;
            panel2.BackColor = Color.White;
            panel3.BackColor = Color.Black;
            panel4.BackColor = Color.White;
            panel5.BackColor = Color.Black;
            panel6.BackColor = Color.White;
            panel7.BackColor = Color.Black;
            panel8.BackColor = Color.White;

            for (int i = 0; i < 9; i++)
            {
                ristinolla[i] = -1;
            }

            Vuoro = 0;
            Vuorot = 0;
        }

    }
}
