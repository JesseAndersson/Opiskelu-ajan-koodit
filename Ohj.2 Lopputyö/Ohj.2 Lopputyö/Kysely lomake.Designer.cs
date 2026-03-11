
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
            this.BtnTallenna.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BtnTallenna.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnTallenna.Location = new System.Drawing.Point(167, 155);
            this.BtnTallenna.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnTallenna.Name = "BtnTallenna";
            this.BtnTallenna.Size = new System.Drawing.Size(137, 38);
            this.BtnTallenna.TabIndex = 0;
            this.BtnTallenna.Text = "Tallenna";
            this.BtnTallenna.UseVisualStyleBackColor = false;
            this.BtnTallenna.Click += new System.EventHandler(this.BtnTallenna_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Etunimi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Sukunimi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Syntymävuosi";
            // 
            // TbEtunimi
            // 
            this.TbEtunimi.Location = new System.Drawing.Point(167, 46);
            this.TbEtunimi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TbEtunimi.Name = "TbEtunimi";
            this.TbEtunimi.Size = new System.Drawing.Size(136, 22);
            this.TbEtunimi.TabIndex = 4;
            // 
            // TbSukunimi
            // 
            this.TbSukunimi.Location = new System.Drawing.Point(167, 78);
            this.TbSukunimi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TbSukunimi.Name = "TbSukunimi";
            this.TbSukunimi.Size = new System.Drawing.Size(136, 22);
            this.TbSukunimi.TabIndex = 5;
            // 
            // TbSyntymavuosi
            // 
            this.TbSyntymavuosi.Location = new System.Drawing.Point(167, 113);
            this.TbSyntymavuosi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TbSyntymavuosi.Name = "TbSyntymavuosi";
            this.TbSyntymavuosi.Size = new System.Drawing.Size(136, 22);
            this.TbSyntymavuosi.TabIndex = 6;
            this.TbSyntymavuosi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbSyntymavuosi_KeyPress);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(379, 240);
            this.Controls.Add(this.TbSyntymavuosi);
            this.Controls.Add(this.TbSukunimi);
            this.Controls.Add(this.TbEtunimi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnTallenna);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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