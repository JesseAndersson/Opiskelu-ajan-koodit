using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ohelmistotuontantomokki
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ohjelmistotuotantodataset.asiakas' table. You can move, or remove it, as needed.
            this.asiakasTableAdapter.Fill(this.ohjelmistotuotantodataset.asiakas);

        }

        private void btnlisaa_Click(object sender, EventArgs e)
        {
            Validate();
            asiakasBindingSource.EndEdit();
            asiakasTableAdapter.Update(this.ohjelmistotuotantodataset);
            asiakasTableAdapter.Insert(tbetunimi.Text, tbsukunimi.Text, tbosoite.Text, tbemail.Text, tbpunro.Text, tbpostinro.Text);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
