
namespace ohelmistotuontantomokki
{
    partial class Form1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.asiakasidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.etunimiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sukunimiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lahiosoiteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.puhnroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.postipostinroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.asiakasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ohjelmistotuotantodataset = new ohelmistotuontantomokki.ohjelmistotuotantodataset();
            this.asiakasTableAdapter = new ohelmistotuontantomokki.ohjelmistotuotantodatasetTableAdapters.asiakasTableAdapter();
            this.tbetunimi = new System.Windows.Forms.TextBox();
            this.tbsukunimi = new System.Windows.Forms.TextBox();
            this.tbosoite = new System.Windows.Forms.TextBox();
            this.btnlisaa = new System.Windows.Forms.Button();
            this.tbemail = new System.Windows.Forms.TextBox();
            this.tbpunro = new System.Windows.Forms.TextBox();
            this.tbpostinro = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnnaytamokki = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.asiakasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ohjelmistotuotantodataset)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.asiakasidDataGridViewTextBoxColumn,
            this.etunimiDataGridViewTextBoxColumn,
            this.sukunimiDataGridViewTextBoxColumn,
            this.lahiosoiteDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.puhnroDataGridViewTextBoxColumn,
            this.postipostinroDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.asiakasBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(67, 226);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(721, 190);
            this.dataGridView1.TabIndex = 0;
            // 
            // asiakasidDataGridViewTextBoxColumn
            // 
            this.asiakasidDataGridViewTextBoxColumn.DataPropertyName = "Asiakasid";
            this.asiakasidDataGridViewTextBoxColumn.HeaderText = "Asiakasid";
            this.asiakasidDataGridViewTextBoxColumn.Name = "asiakasidDataGridViewTextBoxColumn";
            // 
            // etunimiDataGridViewTextBoxColumn
            // 
            this.etunimiDataGridViewTextBoxColumn.DataPropertyName = "etunimi";
            this.etunimiDataGridViewTextBoxColumn.HeaderText = "etunimi";
            this.etunimiDataGridViewTextBoxColumn.Name = "etunimiDataGridViewTextBoxColumn";
            // 
            // sukunimiDataGridViewTextBoxColumn
            // 
            this.sukunimiDataGridViewTextBoxColumn.DataPropertyName = "sukunimi";
            this.sukunimiDataGridViewTextBoxColumn.HeaderText = "sukunimi";
            this.sukunimiDataGridViewTextBoxColumn.Name = "sukunimiDataGridViewTextBoxColumn";
            // 
            // lahiosoiteDataGridViewTextBoxColumn
            // 
            this.lahiosoiteDataGridViewTextBoxColumn.DataPropertyName = "lahiosoite";
            this.lahiosoiteDataGridViewTextBoxColumn.HeaderText = "lahiosoite";
            this.lahiosoiteDataGridViewTextBoxColumn.Name = "lahiosoiteDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // puhnroDataGridViewTextBoxColumn
            // 
            this.puhnroDataGridViewTextBoxColumn.DataPropertyName = "puhnro";
            this.puhnroDataGridViewTextBoxColumn.HeaderText = "puhnro";
            this.puhnroDataGridViewTextBoxColumn.Name = "puhnroDataGridViewTextBoxColumn";
            // 
            // postipostinroDataGridViewTextBoxColumn
            // 
            this.postipostinroDataGridViewTextBoxColumn.DataPropertyName = "posti_postinro";
            this.postipostinroDataGridViewTextBoxColumn.HeaderText = "posti_postinro";
            this.postipostinroDataGridViewTextBoxColumn.Name = "postipostinroDataGridViewTextBoxColumn";
            // 
            // asiakasBindingSource
            // 
            this.asiakasBindingSource.DataMember = "asiakas";
            this.asiakasBindingSource.DataSource = this.ohjelmistotuotantodataset;
            // 
            // ohjelmistotuotantodataset
            // 
            this.ohjelmistotuotantodataset.DataSetName = "ohjelmistotuotantodataset";
            this.ohjelmistotuotantodataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // asiakasTableAdapter
            // 
            this.asiakasTableAdapter.ClearBeforeFill = true;
            // 
            // tbetunimi
            // 
            this.tbetunimi.Location = new System.Drawing.Point(138, 22);
            this.tbetunimi.Name = "tbetunimi";
            this.tbetunimi.Size = new System.Drawing.Size(221, 20);
            this.tbetunimi.TabIndex = 1;
            // 
            // tbsukunimi
            // 
            this.tbsukunimi.Location = new System.Drawing.Point(138, 66);
            this.tbsukunimi.Name = "tbsukunimi";
            this.tbsukunimi.Size = new System.Drawing.Size(221, 20);
            this.tbsukunimi.TabIndex = 2;
            // 
            // tbosoite
            // 
            this.tbosoite.Location = new System.Drawing.Point(138, 100);
            this.tbosoite.Name = "tbosoite";
            this.tbosoite.Size = new System.Drawing.Size(221, 20);
            this.tbosoite.TabIndex = 3;
            // 
            // btnlisaa
            // 
            this.btnlisaa.Location = new System.Drawing.Point(390, 22);
            this.btnlisaa.Name = "btnlisaa";
            this.btnlisaa.Size = new System.Drawing.Size(151, 57);
            this.btnlisaa.TabIndex = 4;
            this.btnlisaa.Text = "Lisää";
            this.btnlisaa.UseVisualStyleBackColor = true;
            this.btnlisaa.Click += new System.EventHandler(this.btnlisaa_Click);
            // 
            // tbemail
            // 
            this.tbemail.Location = new System.Drawing.Point(138, 137);
            this.tbemail.Name = "tbemail";
            this.tbemail.Size = new System.Drawing.Size(221, 20);
            this.tbemail.TabIndex = 5;
            // 
            // tbpunro
            // 
            this.tbpunro.Location = new System.Drawing.Point(138, 177);
            this.tbpunro.Name = "tbpunro";
            this.tbpunro.Size = new System.Drawing.Size(221, 20);
            this.tbpunro.TabIndex = 6;
            // 
            // tbpostinro
            // 
            this.tbpostinro.Location = new System.Drawing.Point(478, 177);
            this.tbpostinro.Name = "tbpostinro";
            this.tbpostinro.Size = new System.Drawing.Size(100, 20);
            this.tbpostinro.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Anna etunimi";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Anna sukunimi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Anna lähiosoite";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Anna puhelinnumero";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 137);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Anna email";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(387, 177);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Anna postinro";
            // 
            // btnnaytamokki
            // 
            this.btnnaytamokki.Location = new System.Drawing.Point(584, 22);
            this.btnnaytamokki.Name = "btnnaytamokki";
            this.btnnaytamokki.Size = new System.Drawing.Size(151, 57);
            this.btnnaytamokki.TabIndex = 15;
            this.btnnaytamokki.Text = "näytä mökki";
            this.btnnaytamokki.UseVisualStyleBackColor = true;
            this.btnnaytamokki.Click += new System.EventHandler(this.btnnaytamokki_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnnaytamokki);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbpostinro);
            this.Controls.Add(this.tbpunro);
            this.Controls.Add(this.tbemail);
            this.Controls.Add(this.btnlisaa);
            this.Controls.Add(this.tbosoite);
            this.Controls.Add(this.tbsukunimi);
            this.Controls.Add(this.tbetunimi);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.asiakasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ohjelmistotuotantodataset)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private ohjelmistotuotantodataset ohjelmistotuotantodataset;
        private System.Windows.Forms.BindingSource asiakasBindingSource;
        private ohjelmistotuotantodatasetTableAdapters.asiakasTableAdapter asiakasTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn asiakasidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn etunimiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sukunimiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lahiosoiteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn puhnroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn postipostinroDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox tbetunimi;
        private System.Windows.Forms.TextBox tbsukunimi;
        private System.Windows.Forms.TextBox tbosoite;
        private System.Windows.Forms.Button btnlisaa;
        private System.Windows.Forms.TextBox tbemail;
        private System.Windows.Forms.TextBox tbpunro;
        private System.Windows.Forms.TextBox tbpostinro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnnaytamokki;
    }
}

