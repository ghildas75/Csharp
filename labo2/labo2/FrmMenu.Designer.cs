namespace labo2
{
    partial class FrmMenu
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
            this.lAB02ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.affichageParEnrigistrementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.affichageTabulaireToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.affichageAPartirDePlusieursTablesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.affichageAvecFiltresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.affichageAvecFiltreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lAB02ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(282, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // lAB02ToolStripMenuItem
            // 
            this.lAB02ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.affichageParEnrigistrementToolStripMenuItem,
            this.affichageTabulaireToolStripMenuItem,
            this.affichageAPartirDePlusieursTablesToolStripMenuItem,
            this.affichageAvecFiltresToolStripMenuItem,
            this.affichageAvecFiltreToolStripMenuItem});
            this.lAB02ToolStripMenuItem.Name = "lAB02ToolStripMenuItem";
            this.lAB02ToolStripMenuItem.Size = new System.Drawing.Size(63, 24);
            this.lAB02ToolStripMenuItem.Text = "LAB02";
            // 
            // affichageParEnrigistrementToolStripMenuItem
            // 
            this.affichageParEnrigistrementToolStripMenuItem.Name = "affichageParEnrigistrementToolStripMenuItem";
            this.affichageParEnrigistrementToolStripMenuItem.Size = new System.Drawing.Size(327, 26);
            this.affichageParEnrigistrementToolStripMenuItem.Text = "Affichage par enrigistrement";
            this.affichageParEnrigistrementToolStripMenuItem.Click += new System.EventHandler(this.affichageParEnrigistrementToolStripMenuItem_Click);
            // 
            // affichageTabulaireToolStripMenuItem
            // 
            this.affichageTabulaireToolStripMenuItem.Name = "affichageTabulaireToolStripMenuItem";
            this.affichageTabulaireToolStripMenuItem.Size = new System.Drawing.Size(327, 26);
            this.affichageTabulaireToolStripMenuItem.Text = "Affichage tabulaire";
            this.affichageTabulaireToolStripMenuItem.Click += new System.EventHandler(this.affichageTabulaireToolStripMenuItem_Click);
            // 
            // affichageAPartirDePlusieursTablesToolStripMenuItem
            // 
            this.affichageAPartirDePlusieursTablesToolStripMenuItem.Name = "affichageAPartirDePlusieursTablesToolStripMenuItem";
            this.affichageAPartirDePlusieursTablesToolStripMenuItem.Size = new System.Drawing.Size(327, 26);
            this.affichageAPartirDePlusieursTablesToolStripMenuItem.Text = "Affichage a partir de plusieurs tables";
            this.affichageAPartirDePlusieursTablesToolStripMenuItem.Click += new System.EventHandler(this.affichageAPartirDePlusieursTablesToolStripMenuItem_Click);
            // 
            // affichageAvecFiltresToolStripMenuItem
            // 
            this.affichageAvecFiltresToolStripMenuItem.Name = "affichageAvecFiltresToolStripMenuItem";
            this.affichageAvecFiltresToolStripMenuItem.Size = new System.Drawing.Size(327, 26);
            this.affichageAvecFiltresToolStripMenuItem.Text = "Affichage Maitre detail";
            this.affichageAvecFiltresToolStripMenuItem.Click += new System.EventHandler(this.affichageAvecFiltresToolStripMenuItem_Click);
            // 
            // affichageAvecFiltreToolStripMenuItem
            // 
            this.affichageAvecFiltreToolStripMenuItem.Name = "affichageAvecFiltreToolStripMenuItem";
            this.affichageAvecFiltreToolStripMenuItem.Size = new System.Drawing.Size(327, 26);
            this.affichageAvecFiltreToolStripMenuItem.Text = "affichage avec filtre";
            this.affichageAvecFiltreToolStripMenuItem.Click += new System.EventHandler(this.affichageAvecFiltreToolStripMenuItem_Click);
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 255);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMenu";
            this.Text = "Menu samir";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem lAB02ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem affichageParEnrigistrementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem affichageTabulaireToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem affichageAPartirDePlusieursTablesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem affichageAvecFiltresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem affichageAvecFiltreToolStripMenuItem;
    }
}

