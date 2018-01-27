namespace frmMenu
{
    partial class frmAffichageParProgrommation
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
            this.btnAfficherLesEmployes = new System.Windows.Forms.Button();
            this.listBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnAfficherLesEmployes
            // 
            this.btnAfficherLesEmployes.Location = new System.Drawing.Point(12, 31);
            this.btnAfficherLesEmployes.Name = "btnAfficherLesEmployes";
            this.btnAfficherLesEmployes.Size = new System.Drawing.Size(339, 23);
            this.btnAfficherLesEmployes.TabIndex = 0;
            this.btnAfficherLesEmployes.Text = "Afficher Les Employes";
            this.btnAfficherLesEmployes.UseVisualStyleBackColor = true;
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 16;
            this.listBox.Location = new System.Drawing.Point(43, 72);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(148, 20);
            this.listBox.TabIndex = 1;
            // 
            // frmAffichageParProgrommation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 255);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.btnAfficherLesEmployes);
            this.Name = "frmAffichageParProgrommation";
            this.Text = "frmAffichageParProgrommation";
            this.Load += new System.EventHandler(this.frmAffichageParProgrommation_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAfficherLesEmployes;
        private System.Windows.Forms.ListBox listBox;
    }
}