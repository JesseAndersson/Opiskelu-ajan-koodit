using Ohj._2_Lopputyö.Model;
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

        public Form1(Form3 f3)
        {
            InitializeComponent();

            this.f = f3;

            timer1 = new Timer();
            timer1.Interval = 1000;
            timer1.Tick += new EventHandler(timer1_Tick);

            StartTime = DateTime.Now;
            timer1.Start();
        }

        Form3 f;

        int Vuorot = 0; // montako vuoroa on kulunut
        int Vuoro = 0; // 0 = risti, 1 = nolla

        int[] ristinolla = { -1, -1, -1, -1, -1, -1, -1, -1, -1 };
        // 9 alkioinen taulukko, kaikki valitsematta
        // -1 = valitsematta
        // 0 = risti
        // 1 = nolla

        int Pelaaja_X = 0; // lasketaan voitot pelaajille
        int Pelaaja_0 = 0;
        int Tasapeli = 0;

        bool VoittajaX = false;
        bool Voittaja0 = false;

        Random rnd = new Random();

        Timer timer1;

        DateTime StartTime = DateTime.MinValue; // laskee aikaa kuinka kauan peli lomake on ollut auki, pelaa tai ei
        TimeSpan CurrentElapsedTime = TimeSpan.Zero;
        TimeSpan TotalElapsedTime = TimeSpan.Zero;

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

        private void Tietokonepelaaja() // helppo
        {
            if (Vuorot % 2 != 0) // tietokone pelaa toisena eli parittomilla
            {
                int index = rnd.Next(0, 9); // valitaan paneli randomisti johon piirretään

                while (ristinolla[index] != -1) // tarkistetaan onko jo piirretty
                {
                    index = rnd.Next(0, 9);
                }

                System.Drawing.SolidBrush PensseliSeta = new System.Drawing.SolidBrush(System.Drawing.Color.Red);
                System.Drawing.Graphics formGraphics;
                Pen p = new Pen(PensseliSeta, 3);

                switch (index)
                {
                    case 0:
                        {
                            Panel panel = panel0;
                            formGraphics = panel.CreateGraphics();
                            formGraphics.DrawEllipse(p, new Rectangle(25, 25, 75 - 25, 75 - 25));
                            formGraphics.Dispose();
                            panel0.Enabled = false;
                            break;
                        }
                    case 1:
                        {
                            Panel panel = panel1;
                            formGraphics = panel.CreateGraphics();
                            formGraphics.DrawEllipse(p, new Rectangle(25, 25, 75 - 25, 75 - 25));
                            formGraphics.Dispose();
                            panel1.Enabled = false;
                            break;
                        }
                    case 2:
                        {
                            Panel panel = panel2;
                            formGraphics = panel.CreateGraphics();
                            formGraphics.DrawEllipse(p, new Rectangle(25, 25, 75 - 25, 75 - 25));
                            formGraphics.Dispose();
                            panel2.Enabled = false;
                            break;
                        }
                    case 3:
                        {
                            Panel panel = panel3;
                            formGraphics = panel.CreateGraphics();
                            formGraphics.DrawEllipse(p, new Rectangle(25, 25, 75 - 25, 75 - 25));
                            formGraphics.Dispose();
                            panel3.Enabled = false;
                            break;
                        }
                    case 4:
                        {
                            Panel panel = panel4;
                            formGraphics = panel.CreateGraphics();
                            formGraphics.DrawEllipse(p, new Rectangle(25, 25, 75 - 25, 75 - 25));
                            formGraphics.Dispose();
                            panel4.Enabled = false;
                            break;
                        }
                    case 5:
                        {
                            Panel panel = panel5;
                            formGraphics = panel.CreateGraphics();
                            formGraphics.DrawEllipse(p, new Rectangle(25, 25, 75 - 25, 75 - 25));
                            formGraphics.Dispose();
                            panel5.Enabled = false;
                            break;
                        }
                    case 6:
                        {
                            Panel panel = panel6;
                            formGraphics = panel.CreateGraphics();
                            formGraphics.DrawEllipse(p, new Rectangle(25, 25, 75 - 25, 75 - 25));
                            formGraphics.Dispose();
                            panel6.Enabled = false;
                            break;
                        }
                    case 7:
                        {
                            Panel panel = panel7;
                            formGraphics = panel.CreateGraphics();
                            formGraphics.DrawEllipse(p, new Rectangle(25, 25, 75 - 25, 75 - 25));
                            formGraphics.Dispose();
                            panel7.Enabled = false;
                            break;
                        }
                    case 8:
                        {
                            Panel panel = panel8;
                            formGraphics = panel.CreateGraphics();
                            formGraphics.DrawEllipse(p, new Rectangle(25, 25, 75 - 25, 75 - 25));
                            formGraphics.Dispose();
                            panel8.Enabled = false;
                            break;
                        }
                }

                PensseliSeta.Dispose();

                ristinolla[index] = Vuoro;
                Vuoro = Vuoro == 0 ? 1 : 0;
                Vuorot++;
                Refresh();
                Tarkistus();
            }
        }

        private void Tietokone_Vaikea()
        {

            if (Vuorot % 2 != 0) // tietokone pelaa toisena eli parittomilla
            {
                /*  Ristinolla taulukko
                    0,1,2
                    3,4,5
                    6,7,8
                */

                int index = -1;

                if (Vuorot == 1) // eka vuoro
                {
                    if (ristinolla[4] == 0)
                    {
                        index = 0;
                    }
                    else
                    {
                        index = 4;
                    }
                }

                if (Vuorot != 1)
                {
                    if (ristinolla[0] == 1 && ristinolla[1] == 1 && ristinolla[2] == -1) // tarkistetaan onko tietokoneella voitto mahdollisuus
                    {
                        ristinolla[2] = 1;
                        index = 2;
                    }
                    else if (ristinolla[0] == 1 && ristinolla[3] == 1 && ristinolla[6] == -1)
                    {
                        ristinolla[6] = 1;
                        index = 6;
                    }
                    else if (ristinolla[2] == 1 && ristinolla[1] == 1 && ristinolla[0] == -1)
                    {
                        ristinolla[0] = 1;
                        index = 0;
                    }
                    else if (ristinolla[2] == 1 && ristinolla[5] == 1 && ristinolla[8] == -1)
                    {
                        ristinolla[8] = 1;
                        index = 8;
                    }
                    else if (ristinolla[3] == 1 && ristinolla[6] == 1 && ristinolla[0] == -1)
                    {
                        ristinolla[0] = 1;
                        index = 0;
                    }
                    else if (ristinolla[6] == 1 && ristinolla[7] == 1 && ristinolla[8] == -1)
                    {
                        ristinolla[8] = 1;
                        index = 8;
                    }
                    else if (ristinolla[7] == 1 && ristinolla[8] == 1 && ristinolla[6] == -1)
                    {
                        ristinolla[6] = 1;
                        index = 6;
                    }
                    else if (ristinolla[8] == 1 && ristinolla[5] == 1 && ristinolla[2] == -1)
                    {
                        ristinolla[2] = 1;
                        index = 2;
                    }
                    else if (ristinolla[4] == 1 && ristinolla[1] == 1 && ristinolla[7] == -1)
                    {
                        ristinolla[7] = 1;
                        index = 7;
                    }
                    else if (ristinolla[4] == 1 && ristinolla[3] == 1 && ristinolla[5] == -1)
                    {
                        ristinolla[5] = 1;
                        index = 7;
                    }
                    else if (ristinolla[4] == 1 && ristinolla[7] == 1 && ristinolla[1] == -1)
                    {
                        ristinolla[1] = 1;
                        index = 1;
                    }
                    else if (ristinolla[4] == 1 && ristinolla[5] == 1 && ristinolla[3] == -1)
                    {
                        ristinolla[3] = 1;
                        index = 3;
                    }
                    else if (ristinolla[0] == 1 && ristinolla[4] == 1 && ristinolla[8] == -1)
                    {
                        ristinolla[8] = 1;
                        index = 8;
                    }
                    else if (ristinolla[8] == 1 && ristinolla[4] == 1 && ristinolla[0] == -1)
                    {
                        ristinolla[0] = 1;
                        index = 0;
                    }
                    else if (ristinolla[2] == 1 && ristinolla[4] == 1 && ristinolla[6] == -1)
                    {
                        ristinolla[6] = 1;
                        index = 6;
                    }
                    else if (ristinolla[6] == 1 && ristinolla[4] == 1 && ristinolla[2] == -1)
                    {
                        ristinolla[2] = 1;
                        index = 2;
                    }
                    else
                    {
                        // pelaajan voiton tarkistus ja tiettyjen blockaus
                        if (ristinolla[0] == 0 && ristinolla[1] == 0 && ristinolla[2] == -1) // ylä rivi vasen >>
                        {
                            ristinolla[2] = 0;
                            index = 2;
                        }
                        else if (ristinolla[0] == 0 && ristinolla[3] == 0 && ristinolla[6] == -1) // vasen alas
                        {
                            ristinolla[6] = 0;
                            index = 6;
                        }
                        else if (ristinolla[2] == 0 && ristinolla[1] == 0 && ristinolla[0] == -1) // ylä rivi oikea<<
                        {
                            ristinolla[0] = 1;
                            index = 0;
                        }
                        else if (ristinolla[2] == 0 && ristinolla[5] == 0 && ristinolla[8] == -1) // oikea alas
                        {
                            ristinolla[8] = 1;
                            index = 8;
                        }
                        else if (ristinolla[3] == 0 && ristinolla[6] == 0 && ristinolla[0] == -1) // vasen ylös
                        {
                            ristinolla[0] = 1;
                            index = 0;
                        }
                        else if (ristinolla[6] == 0 && ristinolla[7] == 0 && ristinolla[8] == -1) //ala rivi vasen >>
                        {
                            ristinolla[8] = 1;
                            index = 8;
                        }
                        else if (ristinolla[7] == 0 && ristinolla[8] == 0 && ristinolla[6] == -1) // ala rivi oikea<<
                        {
                            ristinolla[6] = 1;
                            index = 6;
                        }
                        else if (ristinolla[8] == 0 && ristinolla[5] == 0 && ristinolla[2] == -1) // oikea ylös
                        {
                            ristinolla[2] = 1;
                            index = 2;
                        }
                        else if (ristinolla[4] == 0 && ristinolla[1] == 0 && ristinolla[7] == -1) // keski alas
                        {
                            ristinolla[7] = 1;
                            index = 7;
                        }
                        else if (ristinolla[4] == 0 && ristinolla[3] == 0 && ristinolla[5] == -1) // keski vasen>>
                        {
                            ristinolla[5] = 1;
                            index = 7;
                        }
                        else if (ristinolla[4] == 0 && ristinolla[7] == 0 && ristinolla[1] == -1) //keski ylös
                        {
                            ristinolla[1] = 1;
                            index = 1;
                        }
                        else if (ristinolla[4] == 0 && ristinolla[5] == 0 && ristinolla[3] == -1) //keski oikea <<
                        {
                            ristinolla[3] = 1;
                            index = 3;
                        }
                        else // jos pelaajalla ei voittoriviä eikä tietokoneella otetaan ensimmäinen vapaa
                        {
                            if (ristinolla[0] == -1)
                            {
                                ristinolla[0] = 0;
                                index = 0;
                            }
                            else if (ristinolla[1] == -1)
                            {
                                ristinolla[1] = 0;
                                index = 1;
                            }
                            else if (ristinolla[2] == -1)
                            {
                                ristinolla[2] = 1;
                                index = 2;
                            }
                            else if (ristinolla[3] == -1)
                            {
                                ristinolla[3] = 1;
                                index = 3;
                            }
                            else if (ristinolla[4] == -1)
                            {
                                ristinolla[4] = 1;
                                index = 4;
                            }
                            else if (ristinolla[5] == -1)
                            {
                                ristinolla[5] = 1;
                                index = 5;
                            }
                            else if (ristinolla[6] == -1)
                            {
                                ristinolla[6] = 1;
                                index = 6;
                            }
                            else if (ristinolla[7] == -1)
                            {
                                ristinolla[7] = 1;
                                index = 7;
                            }
                            else if (ristinolla[8] == -1)
                            {
                                ristinolla[8] = 1;
                                index = 8;
                            }
                        }
                    }
                }

                System.Drawing.SolidBrush PensseliSeta = new System.Drawing.SolidBrush(System.Drawing.Color.Red);
                System.Drawing.Graphics formGraphics;
                Pen p = new Pen(PensseliSeta, 3);

                switch (index) // piirto pysyy samanlaisena
                {
                    case 0:
                        {
                            Panel panel = panel0;
                            formGraphics = panel.CreateGraphics();
                            formGraphics.DrawEllipse(p, new Rectangle(25, 25, 75 - 25, 75 - 25));
                            formGraphics.Dispose();
                            panel0.Enabled = false;
                            break;
                        }
                    case 1:
                        {
                            Panel panel = panel1;
                            formGraphics = panel.CreateGraphics();
                            formGraphics.DrawEllipse(p, new Rectangle(25, 25, 75 - 25, 75 - 25));
                            formGraphics.Dispose();
                            panel1.Enabled = false;
                            break;
                        }
                    case 2:
                        {
                            Panel panel = panel2;
                            formGraphics = panel.CreateGraphics();
                            formGraphics.DrawEllipse(p, new Rectangle(25, 25, 75 - 25, 75 - 25));
                            formGraphics.Dispose();
                            panel2.Enabled = false;
                            break;
                        }
                    case 3:
                        {
                            Panel panel = panel3;
                            formGraphics = panel.CreateGraphics();
                            formGraphics.DrawEllipse(p, new Rectangle(25, 25, 75 - 25, 75 - 25));
                            formGraphics.Dispose();
                            panel3.Enabled = false;
                            break;
                        }
                    case 4:
                        {
                            Panel panel = panel4;
                            formGraphics = panel.CreateGraphics();
                            formGraphics.DrawEllipse(p, new Rectangle(25, 25, 75 - 25, 75 - 25));
                            formGraphics.Dispose();
                            panel4.Enabled = false;
                            break;
                        }
                    case 5:
                        {
                            Panel panel = panel5;
                            formGraphics = panel.CreateGraphics();
                            formGraphics.DrawEllipse(p, new Rectangle(25, 25, 75 - 25, 75 - 25));
                            formGraphics.Dispose();
                            panel5.Enabled = false;
                            break;
                        }
                    case 6:
                        {
                            Panel panel = panel6;
                            formGraphics = panel.CreateGraphics();
                            formGraphics.DrawEllipse(p, new Rectangle(25, 25, 75 - 25, 75 - 25));
                            formGraphics.Dispose();
                            panel6.Enabled = false;
                            break;
                        }
                    case 7:
                        {
                            Panel panel = panel7;
                            formGraphics = panel.CreateGraphics();
                            formGraphics.DrawEllipse(p, new Rectangle(25, 25, 75 - 25, 75 - 25));
                            formGraphics.Dispose();
                            panel7.Enabled = false;
                            break;
                        }
                    case 8:
                        {
                            Panel panel = panel8;
                            formGraphics = panel.CreateGraphics();
                            formGraphics.DrawEllipse(p, new Rectangle(25, 25, 75 - 25, 75 - 25));
                            formGraphics.Dispose();
                            panel8.Enabled = false;
                            break;
                        }

                }

                PensseliSeta.Dispose();

                ristinolla[index] = Vuoro;
                Vuoro = Vuoro == 0 ? 1 : 0;
                Vuorot++;
                Refresh();
                Tarkistus();
            }
        }

        private void Tietokone_Mahdoton()
        {
            if (Vuorot % 2 != 0) // tietokone pelaa toisena eli parittomilla
            {

                int index = -1;

                if (Vuorot == 1)
                {
                    //eka vuoro
                    if (ristinolla[0] == 0 && ristinolla[1] == -1 && ristinolla[3] == -1) // vasen ylä
                    {
                        ristinolla[4] = 1;
                        index = 4;
                    }
                    else if (ristinolla[2] == 0 && ristinolla[1] == -1 && ristinolla[5] == -1) // oikea ylä
                    {
                        ristinolla[4] = 1;
                        index = 4;
                    }
                    else if (ristinolla[6] == 0 && ristinolla[7] == -1 && ristinolla[3] == -1) // vasen ala
                    {
                        ristinolla[4] = 1;
                        index = 4;
                    }
                    else if (ristinolla[8] == 0 && ristinolla[7] == -1 && ristinolla[5] == -1) // oikea ala
                    {
                        ristinolla[4] = 1;
                        index = 4;
                    }
                    else if (ristinolla[4] == 0 && ristinolla[5] == -1 && ristinolla[3] == -1 && ristinolla[1] == -1 && ristinolla[7] == -1) //keski
                    {
                        ristinolla[0] = 1;
                        index = 0;
                    }
                    else if (ristinolla[0] == -1 && ristinolla[1] == 0 && ristinolla[3] == -1) // ylä keski
                    {
                        ristinolla[4] = 1;
                        index = 4;
                    }
                    else if (ristinolla[0] == -1 && ristinolla[1] == -1 && ristinolla[3] == 0) // keski vasen
                    {
                        ristinolla[4] = 1;
                        index = 4;
                    }
                    else if (ristinolla[1] == -1 && ristinolla[2] == -1 && ristinolla[5] == 0) // keski oikea
                    {
                        ristinolla[4] = 1;
                        index = 4;
                    }
                    else if (ristinolla[3] == -1 && ristinolla[6] == -1 && ristinolla[7] == 0) // keski ala
                    {
                        ristinolla[4] = 1;
                        index = 4;
                    }
                }

                if (Vuorot != 1)
                {
                    if (ristinolla[0] == 1 && ristinolla[1] == 1 && ristinolla[2] == -1) // tarkistetaan onko tietokoneella voittomahdollisuus
                    {
                        ristinolla[2] = 1;
                        index = 2;
                    }
                    else if (ristinolla[2] == 1 && ristinolla[1] == 1 && ristinolla[0] == -1)
                    {
                        ristinolla[0] = 1;
                        index = 0;
                    }
                    else if (ristinolla[0] == 1 && ristinolla[3] == 1 && ristinolla[6] == -1)
                    {
                        ristinolla[6] = 1;
                        index = 6;
                    }
                    else if (ristinolla[6] == 1 && ristinolla[3] == 1 && ristinolla[0] == -1)
                    {
                        ristinolla[0] = 1;
                        index = 0;
                    }
                    else if (ristinolla[6] == 1 && ristinolla[7] == 1 && ristinolla[8] == -1)
                    {
                        ristinolla[8] = 1;
                        index = 8;
                    }
                    else if (ristinolla[8] == 1 && ristinolla[7] == 1 && ristinolla[6] == -1)
                    {
                        ristinolla[6] = 1;
                        index = 6;
                    }
                    else if (ristinolla[2] == 1 && ristinolla[5] == 1 && ristinolla[8] == -1)
                    {
                        ristinolla[8] = 1;
                        index = 8;
                    }
                    else if (ristinolla[8] == 1 && ristinolla[5] == 1 && ristinolla[2] == -1)
                    {
                        ristinolla[2] = 1;
                        index = 2;
                    }
                    else if (ristinolla[3] == 1 && ristinolla[4] == 1 && ristinolla[5] == -1)
                    {
                        ristinolla[5] = 1;
                        index = 5;
                    }
                    else if (ristinolla[5] == 1 && ristinolla[4] == 1 && ristinolla[3] == -1)
                    {
                        ristinolla[3] = 1;
                        index = 3;
                    }
                    else if (ristinolla[1] == 1 && ristinolla[4] == 1 && ristinolla[7] == -1)
                    {
                        ristinolla[7] = 1;
                        index = 7;
                    }
                    else if (ristinolla[7] == 1 && ristinolla[4] == 1 && ristinolla[1] == -1)
                    {
                        ristinolla[1] = 1;
                        index = 1;
                    }
                    else if (ristinolla[0] == 1 && ristinolla[4] == 1 && ristinolla[8] == -1)
                    {
                        ristinolla[8] = 1;
                        index = 8;
                    }
                    else if (ristinolla[8] == 1 && ristinolla[4] == 1 && ristinolla[0] == -1)
                    {
                        ristinolla[0] = 1;
                        index = 0;
                    }
                    else if (ristinolla[2] == 1 && ristinolla[4] == 1 && ristinolla[6] == -1)
                    {
                        ristinolla[6] = 1;
                        index = 6;
                    }
                    else if (ristinolla[6] == 1 && ristinolla[4] == 1 && ristinolla[2] == -1)
                    {
                        ristinolla[2] = 1;
                        index = 2;
                    }
                    else if (ristinolla[0] == 1 && ristinolla[2] == 1 && ristinolla[1] == -1)
                    {
                        ristinolla[1] = 1;
                        index = 1;
                    }
                    else if (ristinolla[3] == 1 && ristinolla[5] == 1 && ristinolla[4] == -1)
                    {
                        ristinolla[4] = 1;
                        index = 4;
                    }
                    else if (ristinolla[6] == 1 && ristinolla[8] == 1 && ristinolla[7] == -1)
                    {
                        ristinolla[7] = 1;
                        index = 7;
                    }
                    else if (ristinolla[0] == 1 && ristinolla[6] == 1 && ristinolla[3] == -1)
                    {
                        ristinolla[3] = 1;
                        index = 3;
                    }
                    else if (ristinolla[1] == 1 && ristinolla[7] == 1 && ristinolla[4] == -1)
                    {
                        ristinolla[4] = 1;
                        index = 4;
                    }
                    else if (ristinolla[2] == 1 && ristinolla[8] == 1 && ristinolla[5] == -1)
                    {
                        ristinolla[5] = 1;
                        index = 5;
                    }
                    else if (ristinolla[0] == 1 && ristinolla[8] == 1 && ristinolla[4] == -1)
                    {
                        ristinolla[4] = 1;
                        index = 4;
                    }
                    else if (ristinolla[2] == 1 && ristinolla[6] == 1 && ristinolla[4] == -1)
                    {
                        ristinolla[4] = 1;
                        index = 4;
                    }
                    else
                    {
                        if (ristinolla[0] == 0 && ristinolla[1] == 0 && ristinolla[2] == -1) // tarkistetaan onko pelaajalla voittomahdollisuus ja blokataan
                        {
                            ristinolla[2] = 1;
                            index = 2;
                        }
                        else if (ristinolla[2] == 0 && ristinolla[1] == 0 && ristinolla[0] == -1)
                        {
                            ristinolla[0] = 1;
                            index = 0;
                        }
                        else if (ristinolla[0] == 0 && ristinolla[3] == 0 && ristinolla[6] == -1)
                        {
                            ristinolla[6] = 1;
                            index = 6;
                        }
                        else if (ristinolla[6] == 0 && ristinolla[3] == 0 && ristinolla[0] == -1)
                        {
                            ristinolla[0] = 1;
                            index = 0;
                        }
                        else if (ristinolla[6] == 0 && ristinolla[7] == 0 && ristinolla[8] == -1)
                        {
                            ristinolla[8] = 1;
                            index = 8;
                        }
                        else if (ristinolla[8] == 0 && ristinolla[7] == 0 && ristinolla[6] == -1)
                        {
                            ristinolla[6] = 1;
                            index = 6;
                        }
                        else if (ristinolla[2] == 0 && ristinolla[5] == 0 && ristinolla[8] == -1)
                        {
                            ristinolla[8] = 1;
                            index = 8;
                        }
                        else if (ristinolla[8] == 0 && ristinolla[5] == 0 && ristinolla[2] == -1)
                        {
                            ristinolla[2] = 1;
                            index = 2;
                        }
                        else if (ristinolla[3] == 0 && ristinolla[4] == 0 && ristinolla[5] == -1)
                        {
                            ristinolla[5] = 1;
                            index = 5;
                        }
                        else if (ristinolla[5] == 0 && ristinolla[4] == 0 && ristinolla[3] == -1)
                        {
                            ristinolla[3] = 1;
                            index = 3;
                        }
                        else if (ristinolla[1] == 0 && ristinolla[4] == 0 && ristinolla[7] == -1)
                        {
                            ristinolla[7] = 1;
                            index = 7;
                        }
                        else if (ristinolla[7] == 0 && ristinolla[4] == 0 && ristinolla[1] == -1)
                        {
                            ristinolla[1] = 1;
                            index = 1;
                        }
                        else if (ristinolla[0] == 0 && ristinolla[4] == 0 && ristinolla[8] == -1)
                        {
                            ristinolla[8] = 1;
                            index = 8;
                        }
                        else if (ristinolla[8] == 0 && ristinolla[4] == 0 && ristinolla[0] == -1)
                        {
                            ristinolla[0] = 1;
                            index = 0;
                        }
                        else if (ristinolla[2] == 0 && ristinolla[4] == 0 && ristinolla[6] == -1)
                        {
                            ristinolla[6] = 1;
                            index = 6;
                        }
                        else if (ristinolla[6] == 0 && ristinolla[4] == 0 && ristinolla[2] == -1)
                        {
                            ristinolla[2] = 1;
                            index = 2;
                        }
                        else if (ristinolla[0] == 0 && ristinolla[2] == 0 && ristinolla[1] == -1)
                        {
                            ristinolla[1] = 1;
                            index = 1;
                        }
                        else if (ristinolla[3] == 0 && ristinolla[5] == 0 && ristinolla[4] == -1)
                        {
                            ristinolla[4] = 1;
                            index = 4;
                        }
                        else if (ristinolla[6] == 0 && ristinolla[8] == 0 && ristinolla[7] == -1)
                        {
                            ristinolla[7] = 1;
                            index = 7;
                        }
                        else if (ristinolla[0] == 0 && ristinolla[6] == 0 && ristinolla[3] == -1)
                        {
                            ristinolla[3] = 1;
                            index = 3;
                        }
                        else if (ristinolla[1] == 0 && ristinolla[7] == 0 && ristinolla[4] == -1)
                        {
                            ristinolla[4] = 1;
                            index = 4;
                        }
                        else if (ristinolla[2] == 0 && ristinolla[8] == 0 && ristinolla[5] == -1)
                        {
                            ristinolla[5] = 1;
                            index = 5;
                        }
                        else if (ristinolla[0] == 0 && ristinolla[8] == 0 && ristinolla[4] == -1)
                        {
                            ristinolla[4] = 1;
                            index = 4;
                        }
                        else if (ristinolla[2] == 0 && ristinolla[6] == 0 && ristinolla[4] == -1)
                        {
                            ristinolla[4] = 1;
                            index = 4;
                        }
                        else
                        {
                            if (ristinolla[2] == 0 && ristinolla[6] == 0 && ristinolla[4] == 1 && Vuorot == 3)
                            {
                                ristinolla[1] = 1;
                                index = 1;
                            }
                            else if (ristinolla[0] == 0 && ristinolla[8] == 0 && ristinolla[4] == 1 && Vuorot == 3)
                            {
                                ristinolla[1] = 1;
                                index = 1;
                            }
                            else if (ristinolla[4] == 0 && ristinolla[8] == 0 && ristinolla[0] == 1 && Vuorot == 3)
                            {
                                ristinolla[2] = 1;
                                index = 2;
                            }
                            else if (ristinolla[0] == -1)
                            {
                                ristinolla[0] = 1;
                                index = 0;
                            }
                            else if (ristinolla[1] == -1)
                            {
                                ristinolla[1] = 1;
                                index = 1;
                            }
                            else if (ristinolla[2] == -1)
                            {
                                ristinolla[2] = 1;
                                index = 2;
                            }
                            else if (ristinolla[3] == -1)
                            {
                                ristinolla[3] = 1;
                                index = 3;
                            }
                            else if (ristinolla[4] == -1)
                            {
                                ristinolla[4] = 1;
                                index = 4;
                            }
                            else if (ristinolla[5] == -1)
                            {
                                ristinolla[5] = 1;
                                index = 5;
                            }
                            else if (ristinolla[6] == -1)
                            {
                                ristinolla[6] = 1;
                                index = 6;
                            }
                            else if (ristinolla[7] == -1)
                            {
                                ristinolla[7] = 1;
                                index = 7;
                            }
                            else if (ristinolla[8] == -1)
                            {
                                ristinolla[8] = 1;
                                index = 8;
                            }
                        }
                    }
                }

                System.Drawing.SolidBrush PensseliSeta = new System.Drawing.SolidBrush(System.Drawing.Color.Red);
                System.Drawing.Graphics formGraphics;

                Pen p = new Pen(PensseliSeta, 3);

                switch (index) // piirto pysyy samanlaisena
                {
                    case 0:
                        {
                            Panel panel = panel0;
                            formGraphics = panel.CreateGraphics();
                            formGraphics.DrawEllipse(p, new Rectangle(25, 25, 75 - 25, 75 - 25));
                            formGraphics.Dispose();
                            panel0.Enabled = false;
                            break;
                        }
                    case 1:
                        {
                            Panel panel = panel1;
                            formGraphics = panel.CreateGraphics();
                            formGraphics.DrawEllipse(p, new Rectangle(25, 25, 75 - 25, 75 - 25));
                            formGraphics.Dispose();
                            panel1.Enabled = false;
                            break;
                        }
                    case 2:
                        {
                            Panel panel = panel2;
                            formGraphics = panel.CreateGraphics();
                            formGraphics.DrawEllipse(p, new Rectangle(25, 25, 75 - 25, 75 - 25));
                            formGraphics.Dispose();
                            panel2.Enabled = false;
                            break;
                        }
                    case 3:
                        {
                            Panel panel = panel3;
                            formGraphics = panel.CreateGraphics();
                            formGraphics.DrawEllipse(p, new Rectangle(25, 25, 75 - 25, 75 - 25));
                            formGraphics.Dispose();
                            panel3.Enabled = false;
                            break;
                        }
                    case 4:
                        {
                            Panel panel = panel4;
                            formGraphics = panel.CreateGraphics();
                            formGraphics.DrawEllipse(p, new Rectangle(25, 25, 75 - 25, 75 - 25));
                            formGraphics.Dispose();
                            panel4.Enabled = false;
                            break;
                        }
                    case 5:
                        {
                            Panel panel = panel5;
                            formGraphics = panel.CreateGraphics();
                            formGraphics.DrawEllipse(p, new Rectangle(25, 25, 75 - 25, 75 - 25));
                            formGraphics.Dispose();
                            panel5.Enabled = false;
                            break;
                        }
                    case 6:
                        {
                            Panel panel = panel6;
                            formGraphics = panel.CreateGraphics();
                            formGraphics.DrawEllipse(p, new Rectangle(25, 25, 75 - 25, 75 - 25));
                            formGraphics.Dispose();
                            panel6.Enabled = false;
                            break;
                        }
                    case 7:
                        {
                            Panel panel = panel7;
                            formGraphics = panel.CreateGraphics();
                            formGraphics.DrawEllipse(p, new Rectangle(25, 25, 75 - 25, 75 - 25));
                            formGraphics.Dispose();
                            panel7.Enabled = false;
                            break;
                        }
                    case 8:
                        {
                            Panel panel = panel8;
                            formGraphics = panel.CreateGraphics();
                            formGraphics.DrawEllipse(p, new Rectangle(25, 25, 75 - 25, 75 - 25));
                            formGraphics.Dispose();
                            panel8.Enabled = false;
                            break;
                        }
                }

                PensseliSeta.Dispose();

                ristinolla[index] = Vuoro;
                Vuoro = Vuoro == 0 ? 1 : 0;
                Vuorot++;
                Refresh();
                Tarkistus();
            }
        }

        private void Tarkistus()
        {

            if (Vuoro == 0 && Form3.BTietokone == true)
            {
                LbVuoro.Text = Form3.Currentplayers[0].Etunimi.ToString();
            }
            else if (Vuoro == 1 && Form3.BTietokone == true)
            {
                LbVuoro.Text = "Tietokone";
            }
            else if (Vuoro == 0 && Form3.BTietokone == false)
            {
                LbVuoro.Text = Form3.Currentplayers[0].Etunimi.ToString();
            }
            else if (Vuoro == 1 && Form3.BTietokone == false)
            {
                LbVuoro.Text = Form3.Currentplayers[1].Etunimi.ToString();
            }

            if (ristinolla[0] == 1 && ristinolla[1] == 1 && ristinolla[2] == 1) //eka rivi 0
            {
                panel0.BackColor = Color.ForestGreen;
                panel1.BackColor = Color.ForestGreen;
                panel2.BackColor = Color.ForestGreen;

                Pelaaja_0++;

                timer1.Stop();
                Voittaja0 = true;
            }
            else if (ristinolla[3] == 1 && ristinolla[4] == 1 && ristinolla[5] == 1) //toka rivi 0
            {
                panel3.BackColor = Color.ForestGreen;
                panel4.BackColor = Color.ForestGreen;
                panel5.BackColor = Color.ForestGreen;

                Pelaaja_0++;

                timer1.Stop();
                Voittaja0 = true;
            }
            else if (ristinolla[6] == 1 && ristinolla[7] == 1 && ristinolla[8] == 1) //kolmas rivi 0
            {
                panel6.BackColor = Color.ForestGreen;
                panel7.BackColor = Color.ForestGreen;
                panel8.BackColor = Color.ForestGreen;

                Pelaaja_0++;

                timer1.Stop();
                Voittaja0 = true;
            }
            else if (ristinolla[0] == 1 && ristinolla[3] == 1 && ristinolla[6] == 1) // eka pysty 0
            {
                panel0.BackColor = Color.ForestGreen;
                panel3.BackColor = Color.ForestGreen;
                panel6.BackColor = Color.ForestGreen;

                Pelaaja_0++;

                timer1.Stop();
                Voittaja0 = true;
            }
            else if (ristinolla[1] == 1 && ristinolla[4] == 1 && ristinolla[7] == 1) // toka pysty 0
            {
                panel1.BackColor = Color.ForestGreen;
                panel4.BackColor = Color.ForestGreen;
                panel7.BackColor = Color.ForestGreen;

                Pelaaja_0++;

                timer1.Stop();
                Voittaja0 = true;
            }
            else if (ristinolla[2] == 1 && ristinolla[5] == 1 && ristinolla[8] == 1) // kolmas pysty 0
            {
                panel2.BackColor = Color.ForestGreen;
                panel5.BackColor = Color.ForestGreen;
                panel8.BackColor = Color.ForestGreen;

                Pelaaja_0++;

                timer1.Stop();
                Voittaja0 = true;
            }
            else if (ristinolla[0] == 1 && ristinolla[4] == 1 && ristinolla[8] == 1) // vasen ylä oikea ala 0
            {
                panel0.BackColor = Color.ForestGreen;
                panel4.BackColor = Color.ForestGreen;
                panel8.BackColor = Color.ForestGreen;

                Pelaaja_0++;

                timer1.Stop();
                Voittaja0 = true;
            }
            else if (ristinolla[2] == 1 && ristinolla[4] == 1 && ristinolla[6] == 1) // oikea ylä vasen ala 0
            {
                panel2.BackColor = Color.ForestGreen;
                panel4.BackColor = Color.ForestGreen;
                panel6.BackColor = Color.ForestGreen;

                Pelaaja_0++;

                timer1.Stop();
                Voittaja0 = true;
            }
            else if (ristinolla[0] == 0 && ristinolla[1] == 0 && ristinolla[2] == 0) // eka rivi X
            {
                panel0.BackColor = Color.ForestGreen;
                panel1.BackColor = Color.ForestGreen;
                panel2.BackColor = Color.ForestGreen;

                Pelaaja_X++;

                timer1.Stop();
                VoittajaX = true;
            }
            else if (ristinolla[3] == 0 && ristinolla[4] == 0 && ristinolla[5] == 0) // toka rivi X
            {
                panel3.BackColor = Color.ForestGreen;
                panel4.BackColor = Color.ForestGreen;
                panel5.BackColor = Color.ForestGreen;

                Pelaaja_X++;

                timer1.Stop();
                VoittajaX = true;
            }
            else if (ristinolla[6] == 0 && ristinolla[7] == 0 && ristinolla[8] == 0) // kolmas rivi X
            {
                panel6.BackColor = Color.ForestGreen;
                panel7.BackColor = Color.ForestGreen;
                panel8.BackColor = Color.ForestGreen;

                Pelaaja_X++;

                timer1.Stop();
                VoittajaX = true;
            }
            else if (ristinolla[0] == 0 && ristinolla[3] == 0 && ristinolla[6] == 0) // eka pysty X
            {
                panel0.BackColor = Color.ForestGreen;
                panel3.BackColor = Color.ForestGreen;
                panel6.BackColor = Color.ForestGreen;

                Pelaaja_X++;

                timer1.Stop();
                VoittajaX = true;
            }
            else if (ristinolla[1] == 0 && ristinolla[4] == 0 && ristinolla[7] == 0) // toka pysty X
            {
                panel1.BackColor = Color.ForestGreen;
                panel4.BackColor = Color.ForestGreen;
                panel7.BackColor = Color.ForestGreen;

                Pelaaja_X++;

                timer1.Stop();
                VoittajaX = true;
            }
            else if (ristinolla[2] == 0 && ristinolla[5] == 0 && ristinolla[8] == 0) // kolmas pysty X
            {
                panel2.BackColor = Color.ForestGreen;
                panel5.BackColor = Color.ForestGreen;
                panel8.BackColor = Color.ForestGreen;

                Pelaaja_X++;

                timer1.Stop();
                VoittajaX = true;
            }
            else if (ristinolla[0] == 0 && ristinolla[4] == 0 && ristinolla[8] == 0) // vasen ylä oikea ala X
            {
                panel0.BackColor = Color.ForestGreen;
                panel4.BackColor = Color.ForestGreen;
                panel8.BackColor = Color.ForestGreen;

                Pelaaja_X++;

                timer1.Stop();
                VoittajaX = true;
            }
            else if (ristinolla[2] == 0 && ristinolla[4] == 0 && ristinolla[6] == 0) // oikea ylä vasen ala X
            {
                panel2.BackColor = Color.ForestGreen;
                panel4.BackColor = Color.ForestGreen;
                panel6.BackColor = Color.ForestGreen;

                Pelaaja_X++;

                timer1.Stop();
                VoittajaX = true;
            }
            else if (Vuorot == 9)
            {
                Tasapeli++;

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
                        LopetaPeli();
                    }
                }
            }

            if (Voittaja0 == true)
            {
                panel0.Enabled = false;
                panel1.Enabled = false;
                panel2.Enabled = false;
                panel3.Enabled = false;
                panel4.Enabled = false;
                panel5.Enabled = false;
                panel6.Enabled = false;
                panel7.Enabled = false;
                panel8.Enabled = false;

                timer1.Stop();

                DialogResult DR;
                DR = MessageBox.Show("0 VOITTI! Winner winner chicken dinner :D ", "VOITIT");
                if (DR == DialogResult.OK)
                {
                    DR = MessageBox.Show("Pelataanko uudestaan?", "Jatketaanko", MessageBoxButtons.YesNo);

                    if (DR == DialogResult.Yes)
                    {
                        Uusipeli();
                    }
                    else if (DR == DialogResult.No)
                    {
                        LopetaPeli();
                    }
                }
            }
            else if (VoittajaX == true)
            {

                panel0.Enabled = false;
                panel1.Enabled = false;
                panel2.Enabled = false;
                panel3.Enabled = false;
                panel4.Enabled = false;
                panel5.Enabled = false;
                panel6.Enabled = false;
                panel7.Enabled = false;
                panel8.Enabled = false;

                timer1.Stop();

                DialogResult DR;
                DR = MessageBox.Show("X VOITTI! Winner winner chicken dinner :D ", "VOITIT");
                if (DR == DialogResult.OK)
                {
                    DR = MessageBox.Show("Pelataanko uudestaan?", "Jatketaanko", MessageBoxButtons.YesNo);

                    if (DR == DialogResult.Yes)
                    {
                        Uusipeli();
                    }
                    else if (DR == DialogResult.No)
                    {
                        LopetaPeli();
                    }
                }
            }
        }

        private void lopetaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LopetaPeli();
        }

        private void LopetaPeli()
        {
            DialogResult Vastaus;
            Vastaus = MessageBox.Show("Haluatko varmasti lopettaa?", "Lopetetaanko?", MessageBoxButtons.YesNo);

            Pelaaja p = new Pelaaja();
            Form3.Pelaajat = p.DeserializeJSON();

            if (Vastaus == DialogResult.Yes)
            {
                for (int i = 0; i < Form3.Currentplayers.Count(); i++)
                {
                    if (i == 0) // pelaaja 1
                    {
                        Form3.Currentplayers[i].Voitot = Pelaaja_X;
                        Form3.Currentplayers[i].Tasapelit = Tasapeli;
                        Form3.Currentplayers[i].Haviot = Pelaaja_0;
                        Form3.Currentplayers[i].PelienKesto = CurrentElapsedTime.ToString();
                    }

                    if (i == 1) // pelaaja 2 jos ei tietokone
                    {
                        Form3.Currentplayers[i].Voitot = Pelaaja_0;
                        Form3.Currentplayers[i].Tasapelit = Tasapeli;
                        Form3.Currentplayers[i].Haviot = Pelaaja_X;
                        Form3.Currentplayers[i].PelienKesto = CurrentElapsedTime.ToString();
                    }
                }

                for (int i = 0; i < Form3.Currentplayers.Count(); i++)
                {
                    if (Form3.Pelaajat != null)
                    {
                        for (int j = 0; j < Form3.Pelaajat.Count(); j++)
                        {
                            if (Form3.Currentplayers[i].Etunimi == Form3.Pelaajat[j].Etunimi)
                            {
                                if (i == 0)
                                {
                                    Form3.Pelaajat[j].Voitot += Pelaaja_X;
                                    Form3.Pelaajat[j].Tasapelit += Tasapeli;
                                    Form3.Pelaajat[j].Haviot += Pelaaja_0;

                                    string[] luvut = Form3.Pelaajat[j].PelienKesto.Split(':');
                                    TimeSpan ts = new TimeSpan(int.Parse(luvut[0]), int.Parse(luvut[1]), int.Parse(luvut[2]));
                                    TimeSpan yhteiskesto = CurrentElapsedTime + ts;

                                    Form3.Pelaajat[j].PelienKesto = yhteiskesto.ToString();

                                }

                                if (i == 1)
                                {
                                    Form3.Pelaajat[j].Voitot += Pelaaja_0;
                                    Form3.Pelaajat[j].Tasapelit += Tasapeli;
                                    Form3.Pelaajat[j].Haviot += Pelaaja_X;

                                    string[] luvut = Form3.Pelaajat[j].PelienKesto.Split(':');
                                    TimeSpan ts = new TimeSpan(int.Parse(luvut[0]), int.Parse(luvut[1]), int.Parse(luvut[2]));
                                    TimeSpan yhteiskesto = CurrentElapsedTime + ts;

                                    Form3.Pelaajat[j].PelienKesto = yhteiskesto.ToString();
                                }
                            }
                        }
                    }
                }

                p.SerializeJSON(Form3.Pelaajat);

                f.populatePelaajatDgv(Form3.Pelaajat);

                Close();

            }
            else
            {
                return;
            }
        }

        private void panel_MouseClick(object sender, MouseEventArgs e)
        {
            bool Tietokone = Form3.BTietokone; // saadaan onko tietokone nappi painettu aloitus formissa

            if (Tietokone == checked(true) && Vuorot % 2 == 0)
            {
                int index = int.Parse(((Panel)sender).Tag.ToString());
                Vuorot++;

                if (ristinolla[index] == -1)
                {
                    ristinolla[index] = Vuoro;
                    Vuoro = Vuoro == 0 ? 1 : 0; // tarkistetaan onko 1 vai 0 ja vaihdetaan toiseksi
                    ((Panel)sender).Refresh(); // kutsuu panel_paint automaattisesti
                    ((Panel)sender).Enabled = false; // lukitaan paneli jotta ei voida painaa siitä uudelleen ja sekoittaa peliä
                }

                Tarkistus();

                if (Tietokone == checked(true) && Vuorot < 9)
                {
                    TietokoneMiettii.Interval = rnd.Next(500, 2001);
                    TietokoneMiettii.Start();
                }
            }
            else if (Tietokone == checked(false))
            {
                int index = int.Parse(((Panel)sender).Tag.ToString());
                Vuorot++;

                if (ristinolla[index] == -1)
                {
                    ristinolla[index] = Vuoro;
                    Vuoro = Vuoro == 0 ? 1 : 0; // tarkistetaan onko 1 vai 0 ja vaihdetaan toiseksi
                    ((Panel)sender).Refresh(); // kutsuu panel_paint automaattisesti
                    ((Panel)sender).Enabled = false; // lukitaan paneli jotta ei voida painaa siitä uudelleen ja sekoittaa peliä
                }

                Tarkistus();
            }
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
            VoittajaX = false;
            Voittaja0 = false;

            panel0.Enabled = true;
            panel1.Enabled = true;
            panel2.Enabled = true;
            panel3.Enabled = true;
            panel4.Enabled = true;
            panel5.Enabled = true;
            panel6.Enabled = true;
            panel7.Enabled = true;
            panel8.Enabled = true;

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

            timer1.Start();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Apua a = new Apua();
            a.ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            var TimeSinceStartTime = DateTime.Now - StartTime;
            TimeSinceStartTime = new TimeSpan(TimeSinceStartTime.Hours, TimeSinceStartTime.Minutes, TimeSinceStartTime.Seconds);

            CurrentElapsedTime = TimeSinceStartTime + TotalElapsedTime;

            LbKello.Text = CurrentElapsedTime.ToString();
        }

        private void TietokoneMiettii_Tick(object sender, EventArgs e)
        {
            TietokoneMiettii.Stop();
            bool Tietokone = Form3.BTietokone; // saadaan onko tietokone nappi painettu aloitus formissa
            bool TietokoneVaikea = Form3.TietokoneVaikea; // tarkistetaan onko valittu vaikea taso
            bool TietokoneMahdoton = Form3.TietokoneMahdoton;

            if (VoittajaX != true && Voittaja0 != true)
            {
                if (Tietokone == checked(true) && TietokoneVaikea == checked(false) && TietokoneMahdoton == checked(false))
                {
                    Tietokonepelaaja();
                }
                else if (Tietokone == checked(true) && TietokoneVaikea == checked(true) && TietokoneMahdoton == checked(false))
                {
                    Tietokone_Vaikea();
                }
                else if (Tietokone == checked(true) && TietokoneMahdoton == checked(true))
                {
                    Tietokone_Mahdoton();
                }
            }
        }
    }
}