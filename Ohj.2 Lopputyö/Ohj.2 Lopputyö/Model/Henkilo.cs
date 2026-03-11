using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ohj._2_Lopputyö.Model
{
    public class Pelaaja
    {
        public string Etunimi { get; set; }
        public string Sukunimi { get; set; }
        public int Syntymavuosi { get; set; }
        public int Voitot { get; set; }
        public int Haviot { get; set; }
        public int Tasapelit { get; set; }
        public string PelienKesto { get; set; }

        public List<Pelaaja> DeserializeJSON()
        {
            try
            {
                if (File.Exists(path))
                {
                    using (StreamReader sr = new StreamReader(path))
                    {
                      
                        string json = sr.ReadToEnd();

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

        private string path = @"c:/temp/jsontiedot.json";

        public void SerializeJSON(List<Pelaaja> input)
        {
            try
            {
                string json = JsonConvert.SerializeObject(input);

                File.WriteAllText(path, json);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
