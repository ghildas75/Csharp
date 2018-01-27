namespace Labo3
{
    partial class frmMenu
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.mODELEMVCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cHARGEMENTDYNMIQUEDESDONNESToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Location = new System.Drawing.Point(0, 28);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(827, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuStrip2
            // 
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mODELEMVCToolStripMenuItem,
            this.chaToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(827, 28);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // mODELEMVCToolStripMenuItem
            // 
            this.mODELEMVCToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cHARGEMENTDYNMIQUEDESDONNESToolStripMenuItem});
            this.mODELEMVCToolStripMenuItem.Name = "mODELEMVCToolStripMenuItem";
            this.mODELEMVCToolStripMenuItem.Size = new System.Drawing.Size(114, 24);
            this.mODELEMVCToolStripMenuItem.Text = "MODELE MVC";
            this.mODELEMVCToolStripMenuItem.Click += new System.EventHandler(this.mODELEMVCToolStripMenuItem_Click);
            // 
            // cHARGEMENTDYNMIQUEDESDONNESToolStripMenuItem
            // 
            this.cHARGEMENTDYNMIQUEDESDONNESToolStripMenuItem.Name = "cHARGEMENTDYNMIQUEDESDONNESToolStripMenuItem";
            this.cHARGEMENTDYNMIQUEDESDONNESToolStripMenuItem.Size = new System.Drawing.Size(356, 26);
            this.cHARGEMENTDYNMIQUEDESDONNESToolStripMenuItem.Text = "CHARGEMENT DYNMIQUE DES DONNES";
            // 
            // chaToolStripMenuItem
            // 
            this.chaToolStripMenuItem.Name = "chaToolStripMenuItem";
            this.chaToolStripMenuItem.Size = new System.Drawing.Size(261, 24);
            this.chaToolStripMenuItem.Text = "Chargement Dynamique des donnés";
            this.chaToolStripMenuItem.Click += new System.EventHandler(this.chaToolStripMenuItem_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 286);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMenu";
            this.Text = "Menu GHILAS";
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem mODELEMVCToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cHARGEMENTDYNMIQUEDESDONNESToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chaToolStripMenuItem;
    }
}

