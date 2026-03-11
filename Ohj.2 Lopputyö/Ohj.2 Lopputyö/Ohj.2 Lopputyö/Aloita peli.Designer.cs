
namespace Ohj._2_Lopputyö
{
    partial class Form3
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Etunimi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sukunimi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Syntymavuosi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Voitot = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Haviot = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Voittopros = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tasapelit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pelienkesto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAloita = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.cbPelaaja2 = new System.Windows.Forms.ComboBox();
            this.CbTietokone = new System.Windows.Forms.CheckBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lopetaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.apuaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnUusiPelaaja = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Etunimi,
            this.Sukunimi,
            this.Syntymavuosi,
            this.Voitot,
            this.Haviot,
            this.Voittopros,
            this.Tasapelit,
            this.Pelienkesto});
            this.dataGridView1.Location = new System.Drawing.Point(30, 148);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(877, 155);
            this.dataGridView1.TabIndex = 0;
            // 
            // Etunimi
            // 
            this.Etunimi.HeaderText = "Etunimi";
            this.Etunimi.MinimumWidth = 6;
            this.Etunimi.Name = "Etunimi";
            this.Etunimi.Width = 125;
            // 
            // Sukunimi
            // 
            this.Sukunimi.HeaderText = "Sukunimi";
            this.Sukunimi.MinimumWidth = 6;
            this.Sukunimi.Name = "Sukunimi";
            this.Sukunimi.Width = 125;
            // 
            // Syntymavuosi
            // 
            this.Syntymavuosi.HeaderText = "Syntymävuosi";
            this.Syntymavuosi.MinimumWidth = 6;
            this.Syntymavuosi.Name = "Syntymavuosi";
            this.Syntymavuosi.Width = 125;
            // 
            // Voitot
            // 
            this.Voitot.HeaderText = "Voitot";
            this.Voitot.MinimumWidth = 6;
            this.Voitot.Name = "Voitot";
            this.Voitot.Width = 80;
            // 
            // Haviot
            // 
            this.Haviot.HeaderText = "Häviöt";
            this.Haviot.MinimumWidth = 6;
            this.Haviot.Name = "Haviot";
            this.Haviot.Width = 80;
            // 
            // Voittopros
            // 
            this.Voittopros.HeaderText = "Voitto prosentti";
            this.Voittopros.MinimumWidth = 6;
            this.Voittopros.Name = "Voittopros";
            this.Voittopros.Width = 80;
            // 
            // Tasapelit
            // 
            this.Tasapelit.HeaderText = "Tasapelit";
            this.Tasapelit.MinimumWidth = 6;
            this.Tasapelit.Name = "Tasapelit";
            this.Tasapelit.Width = 80;
            // 
            // Pelienkesto
            // 
            this.Pelienkesto.HeaderText = "Pelien kesto yht.";
            this.Pelienkesto.MinimumWidth = 6;
            this.Pelienkesto.Name = "Pelienkesto";
            this.Pelienkesto.Width = 125;
            // 
            // btnAloita
            // 
            this.btnAloita.Location = new System.Drawing.Point(437, 49);
            this.btnAloita.Name = "btnAloita";
            this.btnAloita.Size = new System.Drawing.Size(153, 86);
            this.btnAloita.TabIndex = 1;
            this.btnAloita.Text = "Aloita peli";
            this.btnAloita.UseVisualStyleBackColor = true;
            this.btnAloita.Click += new System.EventHandler(this.btnAloita_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Pelaaja 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(154, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Pelaaja 2";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(30, 81);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 4;
            // 
            // cbPelaaja2
            // 
            this.cbPelaaja2.Enabled = false;
            this.cbPelaaja2.FormattingEnabled = true;
            this.cbPelaaja2.Location = new System.Drawing.Point(157, 81);
            this.cbPelaaja2.Name = "cbPelaaja2";
            this.cbPelaaja2.Size = new System.Drawing.Size(121, 24);
            this.cbPelaaja2.TabIndex = 5;
            // 
            // CbTietokone
            // 
            this.CbTietokone.AutoSize = true;
            this.CbTietokone.Checked = true;
            this.CbTietokone.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CbTietokone.Location = new System.Drawing.Point(284, 81);
            this.CbTietokone.Name = "CbTietokone";
            this.CbTietokone.Size = new System.Drawing.Size(93, 21);
            this.CbTietokone.TabIndex = 8;
            this.CbTietokone.Text = "Tietokone";
            this.CbTietokone.UseVisualStyleBackColor = true;
            this.CbTietokone.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1026, 28);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lopetaToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // lopetaToolStripMenuItem
            // 
            this.lopetaToolStripMenuItem.Name = "lopetaToolStripMenuItem";
            this.lopetaToolStripMenuItem.Size = new System.Drawing.Size(138, 26);
            this.lopetaToolStripMenuItem.Text = "Lopeta";
            this.lopetaToolStripMenuItem.Click += new System.EventHandler(this.lopetaToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Checked = true;
            this.aboutToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.apuaToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.aboutToolStripMenuItem.Text = "Help";
            // 
            // apuaToolStripMenuItem
            // 
            this.apuaToolStripMenuItem.Name = "apuaToolStripMenuItem";
            this.apuaToolStripMenuItem.Size = new System.Drawing.Size(127, 26);
            this.apuaToolStripMenuItem.Text = "Apua";
            this.apuaToolStripMenuItem.Click += new System.EventHandler(this.apuaToolStripMenuItem_Click);
            // 
            // btnUusiPelaaja
            // 
            this.btnUusiPelaaja.Location = new System.Drawing.Point(157, 111);
            this.btnUusiPelaaja.Name = "btnUusiPelaaja";
            this.btnUusiPelaaja.Size = new System.Drawing.Size(119, 31);
            this.btnUusiPelaaja.TabIndex = 10;
            this.btnUusiPelaaja.Text = "Uusi pelaaja";
            this.btnUusiPelaaja.UseVisualStyleBackColor = true;
            this.btnUusiPelaaja.Click += new System.EventHandler(this.btnUusiPelaaja_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1026, 351);
            this.Controls.Add(this.btnUusiPelaaja);
            this.Controls.Add(this.CbTietokone);
            this.Controls.Add(this.cbPelaaja2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAloita);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form3";
            this.ShowIcon = false;
            this.Text = "Aloitus";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Etunimi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sukunimi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Syntymavuosi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Voitot;
        private System.Windows.Forms.DataGridViewTextBoxColumn Haviot;
        private System.Windows.Forms.DataGridViewTextBoxColumn Voittopros;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tasapelit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pelienkesto;
        private System.Windows.Forms.Button btnAloita;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox cbPelaaja2;
        private System.Windows.Forms.CheckBox CbTietokone;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem apuaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lopetaToolStripMenuItem;
        private System.Windows.Forms.Button btnUusiPelaaja;
    }
}