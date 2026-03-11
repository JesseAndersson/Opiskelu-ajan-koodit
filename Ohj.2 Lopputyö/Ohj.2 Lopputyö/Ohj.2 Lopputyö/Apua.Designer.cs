
namespace Ohj._2_Lopputyö
{
    partial class Apua
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Apua));
            this.tbApua = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tbApua
            // 
            this.tbApua.BackColor = System.Drawing.SystemColors.ButtonShadow;
            resources.ApplyResources(this.tbApua, "tbApua");
            this.tbApua.Name = "tbApua";
            this.tbApua.ReadOnly = true;
            this.tbApua.TabStop = false;
            // 
            // Apua
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tbApua);
            this.MaximizeBox = false;
            this.Name = "Apua";
            this.ShowIcon = false;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbApua;
    }
}