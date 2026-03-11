
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
            this.dgvPelaajat = new System.Windows.Forms.DataGridView();
            this.btnAloita = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbPelaaja1 = new System.Windows.Forms.ComboBox();
            this.cbPelaaja2 = new System.Windows.Forms.ComboBox();
            this.CbxTietokone = new System.Windows.Forms.CheckBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lopetaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnUusiPelaaja = new System.Windows.Forms.Button();
            this.CbxHelppo = new System.Windows.Forms.CheckBox();
            this.CbxVaikea = new System.Windows.Forms.CheckBox();
            this.cbxMahdoton = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPelaajat)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvPelaajat
            // 
            this.dgvPelaajat.AllowUserToAddRows = false;
            this.dgvPelaajat.AllowUserToDeleteRows = false;
            this.dgvPelaajat.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dgvPelaajat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPelaajat.GridColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dgvPelaajat.Location = new System.Drawing.Point(29, 169);
            this.dgvPelaajat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvPelaajat.Name = "dgvPelaajat";
            this.dgvPelaajat.ReadOnly = true;
            this.dgvPelaajat.RowHeadersWidth = 51;
            this.dgvPelaajat.RowTemplate.Height = 24;
            this.dgvPelaajat.Size = new System.Drawing.Size(1026, 155);
            this.dgvPelaajat.TabIndex = 0;
            // 
            // btnAloita
            // 
            this.btnAloita.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnAloita.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAloita.Location = new System.Drawing.Point(619, 48);
            this.btnAloita.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAloita.Name = "btnAloita";
            this.btnAloita.Size = new System.Drawing.Size(288, 86);
            this.btnAloita.TabIndex = 1;
            this.btnAloita.Text = "Aloita peli";
            this.btnAloita.UseVisualStyleBackColor = false;
            this.btnAloita.Click += new System.EventHandler(this.btnAloita_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Pelaaja 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(155, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Pelaaja 2";
            // 
            // cbPelaaja1
            // 
            this.cbPelaaja1.FormattingEnabled = true;
            this.cbPelaaja1.Location = new System.Drawing.Point(29, 81);
            this.cbPelaaja1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbPelaaja1.Name = "cbPelaaja1";
            this.cbPelaaja1.Size = new System.Drawing.Size(121, 24);
            this.cbPelaaja1.TabIndex = 4;
            this.cbPelaaja1.SelectedIndexChanged += new System.EventHandler(this.cbPelaaja1_SelectedIndexChanged);
            this.cbPelaaja1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cbPelaaja1_MouseClick);
            // 
            // cbPelaaja2
            // 
            this.cbPelaaja2.Enabled = false;
            this.cbPelaaja2.FormattingEnabled = true;
            this.cbPelaaja2.Location = new System.Drawing.Point(157, 81);
            this.cbPelaaja2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbPelaaja2.Name = "cbPelaaja2";
            this.cbPelaaja2.Size = new System.Drawing.Size(121, 24);
            this.cbPelaaja2.TabIndex = 5;
            this.cbPelaaja2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cbPelaaja2_MouseClick);
            // 
            // CbxTietokone
            // 
            this.CbxTietokone.AutoSize = true;
            this.CbxTietokone.Checked = true;
            this.CbxTietokone.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CbxTietokone.Location = new System.Drawing.Point(323, 63);
            this.CbxTietokone.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CbxTietokone.Name = "CbxTietokone";
            this.CbxTietokone.Size = new System.Drawing.Size(93, 21);
            this.CbxTietokone.TabIndex = 8;
            this.CbxTietokone.Text = "Tietokone";
            this.CbxTietokone.UseVisualStyleBackColor = true;
            this.CbxTietokone.CheckedChanged += new System.EventHandler(this.cbxTietokone_CheckedChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.HelpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1081, 28);
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
            this.lopetaToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.lopetaToolStripMenuItem.Size = new System.Drawing.Size(191, 26);
            this.lopetaToolStripMenuItem.Text = "Lopeta";
            this.lopetaToolStripMenuItem.Click += new System.EventHandler(this.lopetaToolStripMenuItem_Click);
            // 
            // HelpToolStripMenuItem
            // 
            this.HelpToolStripMenuItem.Checked = true;
            this.HelpToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem";
            this.HelpToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.HelpToolStripMenuItem.Text = "Help";
            this.HelpToolStripMenuItem.Click += new System.EventHandler(this.HelpToolStripMenuItem_Click);
            // 
            // btnUusiPelaaja
            // 
            this.btnUusiPelaaja.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnUusiPelaaja.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUusiPelaaja.Location = new System.Drawing.Point(29, 111);
            this.btnUusiPelaaja.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUusiPelaaja.Name = "btnUusiPelaaja";
            this.btnUusiPelaaja.Size = new System.Drawing.Size(251, 42);
            this.btnUusiPelaaja.TabIndex = 10;
            this.btnUusiPelaaja.Text = "Uusi pelaaja";
            this.btnUusiPelaaja.UseVisualStyleBackColor = false;
            this.btnUusiPelaaja.Click += new System.EventHandler(this.btnUusiPelaaja_Click);
            // 
            // CbxHelppo
            // 
            this.CbxHelppo.AutoSize = true;
            this.CbxHelppo.Checked = true;
            this.CbxHelppo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CbxHelppo.Location = new System.Drawing.Point(323, 89);
            this.CbxHelppo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CbxHelppo.Name = "CbxHelppo";
            this.CbxHelppo.Size = new System.Drawing.Size(75, 21);
            this.CbxHelppo.TabIndex = 11;
            this.CbxHelppo.Text = "Helppo";
            this.CbxHelppo.UseVisualStyleBackColor = true;
            this.CbxHelppo.CheckedChanged += new System.EventHandler(this.CbxHelppo_CheckedChanged);
            // 
            // CbxVaikea
            // 
            this.CbxVaikea.AutoSize = true;
            this.CbxVaikea.Location = new System.Drawing.Point(323, 111);
            this.CbxVaikea.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CbxVaikea.Name = "CbxVaikea";
            this.CbxVaikea.Size = new System.Drawing.Size(73, 21);
            this.CbxVaikea.TabIndex = 12;
            this.CbxVaikea.Text = "Vaikea";
            this.CbxVaikea.UseVisualStyleBackColor = true;
            this.CbxVaikea.CheckedChanged += new System.EventHandler(this.CbxVaikea_CheckedChanged);
            // 
            // cbxMahdoton
            // 
            this.cbxMahdoton.AutoSize = true;
            this.cbxMahdoton.Location = new System.Drawing.Point(323, 134);
            this.cbxMahdoton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxMahdoton.Name = "cbxMahdoton";
            this.cbxMahdoton.Size = new System.Drawing.Size(145, 21);
            this.cbxMahdoton.TabIndex = 13;
            this.cbxMahdoton.Text = "Melkein mahdoton";
            this.cbxMahdoton.UseVisualStyleBackColor = true;
            this.cbxMahdoton.CheckedChanged += new System.EventHandler(this.cbxMahdoton_CheckedChanged);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1081, 337);
            this.Controls.Add(this.cbxMahdoton);
            this.Controls.Add(this.CbxVaikea);
            this.Controls.Add(this.CbxHelppo);
            this.Controls.Add(this.btnUusiPelaaja);
            this.Controls.Add(this.CbxTietokone);
            this.Controls.Add(this.cbPelaaja2);
            this.Controls.Add(this.cbPelaaja1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAloita);
            this.Controls.Add(this.dgvPelaajat);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form3";
            this.ShowIcon = false;
            this.Text = "Aloitus";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPelaajat)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPelaajat;
        private System.Windows.Forms.Button btnAloita;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbPelaaja1;
        private System.Windows.Forms.ComboBox cbPelaaja2;
        private System.Windows.Forms.CheckBox CbxTietokone;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem HelpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lopetaToolStripMenuItem;
        private System.Windows.Forms.Button btnUusiPelaaja;
        private System.Windows.Forms.CheckBox CbxHelppo;
        private System.Windows.Forms.CheckBox CbxVaikea;
        private System.Windows.Forms.CheckBox cbxMahdoton;
    }
}