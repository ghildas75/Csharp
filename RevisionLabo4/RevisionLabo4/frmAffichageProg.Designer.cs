namespace RevisionLabo4
{
    partial class frmAffichageProg
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
            this.lstEmploye = new System.Windows.Forms.ListBox();
            this.btnAfficheEmploye = new System.Windows.Forms.Button();
            this.lstContrat = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lstEmploye
            // 
            this.lstEmploye.FormattingEnabled = true;
            this.lstEmploye.ItemHeight = 16;
            this.lstEmploye.Location = new System.Drawing.Point(32, 79);
            this.lstEmploye.Name = "lstEmploye";
            this.lstEmploye.Size = new System.Drawing.Size(290, 164);
            this.lstEmploye.TabIndex = 0;
            this.lstEmploye.SelectedIndexChanged += new System.EventHandler(this.lstEmploye_SelectedIndexChanged);
            // 
            // btnAfficheEmploye
            // 
            this.btnAfficheEmploye.Location = new System.Drawing.Point(32, 27);
            this.btnAfficheEmploye.Name = "btnAfficheEmploye";
            this.btnAfficheEmploye.Size = new System.Drawing.Size(256, 23);
            this.btnAfficheEmploye.TabIndex = 1;
            this.btnAfficheEmploye.Text = "Afficher les Employes";
            this.btnAfficheEmploye.UseVisualStyleBackColor = true;
            this.btnAfficheEmploye.Click += new System.EventHandler(this.btnAfficheEmploye_Click);
            // 
            // lstContrat
            // 
            this.lstContrat.FormattingEnabled = true;
            this.lstContrat.ItemHeight = 16;
            this.lstContrat.Location = new System.Drawing.Point(404, 79);
            this.lstContrat.Name = "lstContrat";
            this.lstContrat.Size = new System.Drawing.Size(222, 164);
            this.lstContrat.TabIndex = 2;
            // 
            // frmAffichageProg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 255);
            this.Controls.Add(this.lstContrat);
            this.Controls.Add(this.btnAfficheEmploye);
            this.Controls.Add(this.lstEmploye);
            this.Name = "frmAffichageProg";
            this.Text = "frmAffichageProg";
            this.Load += new System.EventHandler(this.frmAffichageProg_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstEmploye;
        private System.Windows.Forms.Button btnAfficheEmploye;
        private System.Windows.Forms.ListBox lstContrat;
    }
}