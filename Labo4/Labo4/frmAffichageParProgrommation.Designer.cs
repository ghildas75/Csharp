namespace Labo4
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
            this.btnAfficherEmployes = new System.Windows.Forms.Button();
            this.lstEmploye = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lstContrats = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnAfficherEmployes
            // 
            this.btnAfficherEmployes.Location = new System.Drawing.Point(12, 13);
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
            this.lstEmploye.Location = new System.Drawing.Point(12, 42);
            this.lstEmploye.Name = "lstEmploye";
            this.lstEmploye.Size = new System.Drawing.Size(258, 212);
            this.lstEmploye.TabIndex = 1;
            this.lstEmploye.SelectedIndexChanged += new System.EventHandler(this.lstEmploye_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(338, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Contrats";
            // 
            // lstContrats
            // 
            this.lstContrats.FormattingEnabled = true;
            this.lstContrats.ItemHeight = 16;
            this.lstContrats.Location = new System.Drawing.Point(276, 44);
            this.lstContrats.Name = "lstContrats";
            this.lstContrats.Size = new System.Drawing.Size(232, 212);
            this.lstContrats.TabIndex = 3;
            // 
            // frmAffichageParProgrommation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 255);
            this.Controls.Add(this.lstContrats);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstEmploye);
            this.Controls.Add(this.btnAfficherEmployes);
            this.Name = "frmAffichageParProgrommation";
            this.Text = "frmAffichageParProgrommation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAfficherEmployes;
        private System.Windows.Forms.ListBox lstEmploye;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstContrats;
    }
}