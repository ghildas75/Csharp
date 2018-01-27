namespace labo41
{
    partial class FrmAffichageParProgrammation
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
            this.btnAfficherEmployes = new System.Windows.Forms.Button();
            this.lstEmploye = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnAfficherEmployes
            // 
            this.btnAfficherEmployes.Location = new System.Drawing.Point(12, 12);
            this.btnAfficherEmployes.Name = "btnAfficherEmployes";
            this.btnAfficherEmployes.Size = new System.Drawing.Size(258, 23);
            this.btnAfficherEmployes.TabIndex = 0;
            this.btnAfficherEmployes.Text = "Afficher les Employes";
            this.btnAfficherEmployes.UseVisualStyleBackColor = true;
            this.btnAfficherEmployes.Click += new System.EventHandler(this.btnAfficherEmployes_Click);
            // 
            // lstEmploye
            // 
            this.lstEmploye.FormattingEnabled = true;
            this.lstEmploye.ItemHeight = 16;
            this.lstEmploye.Location = new System.Drawing.Point(-2, 37);
            this.lstEmploye.Name = "lstEmploye";
            this.lstEmploye.Size = new System.Drawing.Size(286, 212);
            this.lstEmploye.TabIndex = 1;
            // 
            // FrmAffichageParProgrammation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 255);
            this.Controls.Add(this.lstEmploye);
            this.Controls.Add(this.btnAfficherEmployes);
            this.Name = "FrmAffichageParProgrammation";
            this.Text = "Affichage Par Programmation";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAfficherEmployes;
        private System.Windows.Forms.ListBox lstEmploye;
    }
}