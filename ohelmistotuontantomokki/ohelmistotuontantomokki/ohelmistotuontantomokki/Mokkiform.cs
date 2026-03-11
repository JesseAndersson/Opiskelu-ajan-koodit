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
    public partial class Mokkiform : Form
    {
        public Mokkiform(Form1 form1)
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Mokkiform_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ohjelmistotuotantodataset.mokki' table. You can move, or remove it, as needed.
            this.mokkiTableAdapter.Fill(this.ohjelmistotuotantodataset.mokki);

        }

        private void btnlisaa_Click(object sender, EventArgs e)
        {
            Validate();
            mokkiBindingSource.EndEdit();
            mokkiTableAdapter.Update(this.ohjelmistotuotantodataset);
            mokkiTableAdapter.Insert(tbmokkinimi.Text, tbmokkiosoite.Text,double.Parse( tbhinta.Text), tbkuvaus.Text, int.Parse( tbhlomaara.Text), tbvarustelu.Text, tbpostinro.Text, int.Parse( tbalue.Text));
               
        }
    }
}
