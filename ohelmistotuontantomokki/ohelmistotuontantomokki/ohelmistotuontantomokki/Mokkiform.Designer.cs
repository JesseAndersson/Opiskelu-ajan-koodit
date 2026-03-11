
namespace ohelmistotuontantomokki
{
    partial class Mokkiform
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbmokkinimi = new System.Windows.Forms.TextBox();
            this.tbmokkiosoite = new System.Windows.Forms.TextBox();
            this.tbpostinro = new System.Windows.Forms.TextBox();
            this.tbalue = new System.Windows.Forms.TextBox();
            this.tbkuvaus = new System.Windows.Forms.TextBox();
            this.tbvarustelu = new System.Windows.Forms.TextBox();
            this.tbhlomaara = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnlisaa = new System.Windows.Forms.Button();
            this.ohjelmistotuotantodataset = new ohelmistotuontantomokki.ohjelmistotuotantodataset();
            this.ohjelmistotuotantodatasetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mokkiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mokkiTableAdapter = new ohelmistotuontantomokki.ohjelmistotuotantodatasetTableAdapters.mokkiTableAdapter();
            this.mokkiidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mokkinimiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.katuosoiteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hintaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kuvausDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.henkilomaaraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.varusteluDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.postipostinroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aluealueidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label8 = new System.Windows.Forms.Label();
            this.tbhinta = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ohjelmistotuotantodataset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ohjelmistotuotantodatasetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mokkiBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mökin nimi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Katuosoite";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Postinumero";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Alue";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 221);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Kuvaus";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 266);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Varustelu";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(28, 310);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Henkilömäärä";
            // 
            // tbmokkinimi
            // 
            this.tbmokkinimi.Location = new System.Drawing.Point(153, 46);
            this.tbmokkinimi.Name = "tbmokkinimi";
            this.tbmokkinimi.Size = new System.Drawing.Size(160, 20);
            this.tbmokkinimi.TabIndex = 7;
            // 
            // tbmokkiosoite
            // 
            this.tbmokkiosoite.Location = new System.Drawing.Point(153, 88);
            this.tbmokkiosoite.Name = "tbmokkiosoite";
            this.tbmokkiosoite.Size = new System.Drawing.Size(160, 20);
            this.tbmokkiosoite.TabIndex = 8;
            // 
            // tbpostinro
            // 
            this.tbpostinro.Location = new System.Drawing.Point(153, 126);
            this.tbpostinro.Name = "tbpostinro";
            this.tbpostinro.Size = new System.Drawing.Size(100, 20);
            this.tbpostinro.TabIndex = 9;
            // 
            // tbalue
            // 
            this.tbalue.Location = new System.Drawing.Point(153, 172);
            this.tbalue.Name = "tbalue";
            this.tbalue.Size = new System.Drawing.Size(100, 20);
            this.tbalue.TabIndex = 10;
            // 
            // tbkuvaus
            // 
            this.tbkuvaus.Location = new System.Drawing.Point(153, 221);
            this.tbkuvaus.Name = "tbkuvaus";
            this.tbkuvaus.Size = new System.Drawing.Size(231, 20);
            this.tbkuvaus.TabIndex = 11;
            // 
            // tbvarustelu
            // 
            this.tbvarustelu.Location = new System.Drawing.Point(153, 266);
            this.tbvarustelu.Name = "tbvarustelu";
            this.tbvarustelu.Size = new System.Drawing.Size(231, 20);
            this.tbvarustelu.TabIndex = 12;
            // 
            // tbhlomaara
            // 
            this.tbhlomaara.Location = new System.Drawing.Point(153, 310);
            this.tbhlomaara.Name = "tbhlomaara";
            this.tbhlomaara.Size = new System.Drawing.Size(100, 20);
            this.tbhlomaara.TabIndex = 13;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mokkiidDataGridViewTextBoxColumn,
            this.mokkinimiDataGridViewTextBoxColumn,
            this.katuosoiteDataGridViewTextBoxColumn,
            this.hintaDataGridViewTextBoxColumn,
            this.kuvausDataGridViewTextBoxColumn,
            this.henkilomaaraDataGridViewTextBoxColumn,
            this.varusteluDataGridViewTextBoxColumn,
            this.postipostinroDataGridViewTextBoxColumn,
            this.aluealueidDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.mokkiBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(421, 39);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(586, 284);
            this.dataGridView1.TabIndex = 14;
            // 
            // btnlisaa
            // 
            this.btnlisaa.Location = new System.Drawing.Point(421, 362);
            this.btnlisaa.Name = "btnlisaa";
            this.btnlisaa.Size = new System.Drawing.Size(120, 54);
            this.btnlisaa.TabIndex = 15;
            this.btnlisaa.Text = "Lisää";
            this.btnlisaa.UseVisualStyleBackColor = true;
            this.btnlisaa.Click += new System.EventHandler(this.btnlisaa_Click);
            // 
            // ohjelmistotuotantodataset
            // 
            this.ohjelmistotuotantodataset.DataSetName = "ohjelmistotuotantodataset";
            this.ohjelmistotuotantodataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ohjelmistotuotantodatasetBindingSource
            // 
            this.ohjelmistotuotantodatasetBindingSource.DataSource = this.ohjelmistotuotantodataset;
            this.ohjelmistotuotantodatasetBindingSource.Position = 0;
            // 
            // mokkiBindingSource
            // 
            this.mokkiBindingSource.DataMember = "mokki";
            this.mokkiBindingSource.DataSource = this.ohjelmistotuotantodataset;
            // 
            // mokkiTableAdapter
            // 
            this.mokkiTableAdapter.ClearBeforeFill = true;
            // 
            // mokkiidDataGridViewTextBoxColumn
            // 
            this.mokkiidDataGridViewTextBoxColumn.DataPropertyName = "mokkiid";
            this.mokkiidDataGridViewTextBoxColumn.HeaderText = "mokkiid";
            this.mokkiidDataGridViewTextBoxColumn.Name = "mokkiidDataGridViewTextBoxColumn";
            // 
            // mokkinimiDataGridViewTextBoxColumn
            // 
            this.mokkinimiDataGridViewTextBoxColumn.DataPropertyName = "mokkinimi";
            this.mokkinimiDataGridViewTextBoxColumn.HeaderText = "mokkinimi";
            this.mokkinimiDataGridViewTextBoxColumn.Name = "mokkinimiDataGridViewTextBoxColumn";
            // 
            // katuosoiteDataGridViewTextBoxColumn
            // 
            this.katuosoiteDataGridViewTextBoxColumn.DataPropertyName = "katuosoite";
            this.katuosoiteDataGridViewTextBoxColumn.HeaderText = "katuosoite";
            this.katuosoiteDataGridViewTextBoxColumn.Name = "katuosoiteDataGridViewTextBoxColumn";
            // 
            // hintaDataGridViewTextBoxColumn
            // 
            this.hintaDataGridViewTextBoxColumn.DataPropertyName = "hinta";
            this.hintaDataGridViewTextBoxColumn.HeaderText = "hinta";
            this.hintaDataGridViewTextBoxColumn.Name = "hintaDataGridViewTextBoxColumn";
            // 
            // kuvausDataGridViewTextBoxColumn
            // 
            this.kuvausDataGridViewTextBoxColumn.DataPropertyName = "kuvaus";
            this.kuvausDataGridViewTextBoxColumn.HeaderText = "kuvaus";
            this.kuvausDataGridViewTextBoxColumn.Name = "kuvausDataGridViewTextBoxColumn";
            // 
            // henkilomaaraDataGridViewTextBoxColumn
            // 
            this.henkilomaaraDataGridViewTextBoxColumn.DataPropertyName = "henkilomaara";
            this.henkilomaaraDataGridViewTextBoxColumn.HeaderText = "henkilomaara";
            this.henkilomaaraDataGridViewTextBoxColumn.Name = "henkilomaaraDataGridViewTextBoxColumn";
            // 
            // varusteluDataGridViewTextBoxColumn
            // 
            this.varusteluDataGridViewTextBoxColumn.DataPropertyName = "varustelu";
            this.varusteluDataGridViewTextBoxColumn.HeaderText = "varustelu";
            this.varusteluDataGridViewTextBoxColumn.Name = "varusteluDataGridViewTextBoxColumn";
            // 
            // postipostinroDataGridViewTextBoxColumn
            // 
            this.postipostinroDataGridViewTextBoxColumn.DataPropertyName = "posti_postinro";
            this.postipostinroDataGridViewTextBoxColumn.HeaderText = "posti_postinro";
            this.postipostinroDataGridViewTextBoxColumn.Name = "postipostinroDataGridViewTextBoxColumn";
            // 
            // aluealueidDataGridViewTextBoxColumn
            // 
            this.aluealueidDataGridViewTextBoxColumn.DataPropertyName = "alue_alueid";
            this.aluealueidDataGridViewTextBoxColumn.HeaderText = "alue_alueid";
            this.aluealueidDataGridViewTextBoxColumn.Name = "aluealueidDataGridViewTextBoxColumn";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(28, 350);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Hinta";
            // 
            // tbhinta
            // 
            this.tbhinta.Location = new System.Drawing.Point(153, 350);
            this.tbhinta.Name = "tbhinta";
            this.tbhinta.Size = new System.Drawing.Size(100, 20);
            this.tbhinta.TabIndex = 17;
            // 
            // Mokkiform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1019, 450);
            this.Controls.Add(this.tbhinta);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnlisaa);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tbhlomaara);
            this.Controls.Add(this.tbvarustelu);
            this.Controls.Add(this.tbkuvaus);
            this.Controls.Add(this.tbalue);
            this.Controls.Add(this.tbpostinro);
            this.Controls.Add(this.tbmokkiosoite);
            this.Controls.Add(this.tbmokkinimi);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Mokkiform";
            this.Text = "Mokkiform";
            this.Load += new System.EventHandler(this.Mokkiform_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ohjelmistotuotantodataset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ohjelmistotuotantodatasetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mokkiBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbmokkinimi;
        private System.Windows.Forms.TextBox tbmokkiosoite;
        private System.Windows.Forms.TextBox tbpostinro;
        private System.Windows.Forms.TextBox tbalue;
        private System.Windows.Forms.TextBox tbkuvaus;
        private System.Windows.Forms.TextBox tbvarustelu;
        private System.Windows.Forms.TextBox tbhlomaara;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnlisaa;
        private System.Windows.Forms.BindingSource ohjelmistotuotantodatasetBindingSource;
        private ohjelmistotuotantodataset ohjelmistotuotantodataset;
        private System.Windows.Forms.BindingSource mokkiBindingSource;
        private ohjelmistotuotantodatasetTableAdapters.mokkiTableAdapter mokkiTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn mokkiidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mokkinimiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn katuosoiteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hintaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kuvausDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn henkilomaaraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn varusteluDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn postipostinroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aluealueidDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbhinta;
    }
}