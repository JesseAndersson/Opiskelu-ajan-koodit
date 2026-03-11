
namespace Ohj._2_Lopputyö
{
    partial class Form2
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
            this.BtnTallenna = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TbEtunimi = new System.Windows.Forms.TextBox();
            this.TbSukunimi = new System.Windows.Forms.TextBox();
            this.TbSyntymavuosi = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BtnTallenna
            // 
            this.BtnTallenna.Location = new System.Drawing.Point(167, 155);
            this.BtnTallenna.Name = "BtnTallenna";
            this.BtnTallenna.Size = new System.Drawing.Size(136, 26);
            this.BtnTallenna.TabIndex = 0;
            this.BtnTallenna.Text = "Tallenna";
            this.BtnTallenna.UseVisualStyleBackColor = true;
            this.BtnTallenna.Click += new System.EventHandler(this.BtnTallenna_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Etunimi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Sukunimi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Syntymävuosi";
            // 
            // TbEtunimi
            // 
            this.TbEtunimi.Location = new System.Drawing.Point(167, 46);
            this.TbEtunimi.Name = "TbEtunimi";
            this.TbEtunimi.Size = new System.Drawing.Size(136, 22);
            this.TbEtunimi.TabIndex = 4;
            // 
            // TbSukunimi
            // 
            this.TbSukunimi.Location = new System.Drawing.Point(167, 78);
            this.TbSukunimi.Name = "TbSukunimi";
            this.TbSukunimi.Size = new System.Drawing.Size(136, 22);
            this.TbSukunimi.TabIndex = 5;
            // 
            // TbSyntymavuosi
            // 
            this.TbSyntymavuosi.Location = new System.Drawing.Point(167, 113);
            this.TbSyntymavuosi.Name = "TbSyntymavuosi";
            this.TbSyntymavuosi.Size = new System.Drawing.Size(136, 22);
            this.TbSyntymavuosi.TabIndex = 6;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 240);
            this.Controls.Add(this.TbSyntymavuosi);
            this.Controls.Add(this.TbSukunimi);
            this.Controls.Add(this.TbEtunimi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnTallenna);
            this.Name = "Form2";
            this.Text = "Tietojen kysyminen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnTallenna;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TbEtunimi;
        private System.Windows.Forms.TextBox TbSukunimi;
        private System.Windows.Forms.TextBox TbSyntymavuosi;
    }
}