using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Ohj._2_Lopputyö.Model;
using Newtonsoft.Json;
using System.Runtime.Serialization.Formatters.Binary;

namespace Ohj._2_Lopputyö
{
    public partial class Form2 : Form
    {
        public Form2(Form3 f3) // saadaan tälle formille tieto että toinen formi on olemassa ja sen tietoja
        {
            InitializeComponent();
            this.f = f3;
        }

        public static List<Pelaaja> Pelaajat = new List<Pelaaja>();
        public string Filename;
        public string path = @"c:/temp/jsontiedot.json"; // = Path.Combine(Environment.CurrentDirectory, @"Data\", Filename);
        string json;
        Form3 f;

        private void BtnTallenna_Click(object sender, EventArgs e)
        {
            Filename = TbEtunimi.Text + " " + TbSukunimi.Text;
            //path = Path.Combine(Environment.CurrentDirectory, @"Data\", Filename); // saataisiin tiettyyn paikkaan ohjelman sisällä olevaan kansioon BIN

            DirectoryInfo drInfo = new DirectoryInfo(@"c:/temp");
            if (drInfo.Exists != true)
            {
                drInfo.Create();
            }

            Pelaaja p = new Pelaaja();

            if (Form3.Pelaajat != null || Pelaajat.Count != 0)
            {
                Pelaajat = DeserializeJSON();
            }

            if (TbEtunimi.Text == string.Empty)
            {
                TbEtunimi.Text = "Esimerkki";
            }
            if (TbSukunimi.Text == string.Empty)
            {
                TbSukunimi.Text = "Esimerkki";
            }
            if (TbSyntymavuosi.Text == string.Empty)
            {
                TbSyntymavuosi.Text = "1954";
            }

            p.Etunimi = TbEtunimi.Text;
            p.Sukunimi = TbSukunimi.Text;
            p.Syntymavuosi = int.Parse(TbSyntymavuosi.Text);
            p.Voitot = 0;
            p.Haviot = 0;
            p.Tasapelit = 0;
            p.PelienKesto = "00:00:00";

            Pelaajat.Add(p);

            SerializeJSON(Pelaajat);

            f.populatePelaajatDgv(Pelaajat); // kutsuu toisen formin tätä fuktiota

            Close();
        }


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


        public void SerializeJSON(List<Pelaaja> input)
        {
            try
            {
                json = JsonConvert.SerializeObject(input);
                File.Delete(path);
                File.AppendAllText(path, json);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void TbSyntymavuosi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && (e.KeyChar != '\b'))
            {
                e.Handled = true;
            }
        }
    }
}
