namespace revisionLabo2
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
            this.labo2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.affichageParEnrigistrementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.affichageEnTabulaireToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.affichageAPartirDePlusieurTableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.affichageMaitreDétailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.affichageFiltreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.labo2ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(320, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // labo2ToolStripMenuItem
            // 
            this.labo2ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.affichageParEnrigistrementToolStripMenuItem,
            this.affichageEnTabulaireToolStripMenuItem,
            this.affichageAPartirDePlusieurTableToolStripMenuItem,
            this.affichageMaitreDétailsToolStripMenuItem,
            this.affichageFiltreToolStripMenuItem});
            this.labo2ToolStripMenuItem.Name = "labo2ToolStripMenuItem";
            this.labo2ToolStripMenuItem.Size = new System.Drawing.Size(62, 24);
            this.labo2ToolStripMenuItem.Text = "Labo2";
            // 
            // affichageParEnrigistrementToolStripMenuItem
            // 
            this.affichageParEnrigistrementToolStripMenuItem.Name = "affichageParEnrigistrementToolStripMenuItem";
            this.affichageParEnrigistrementToolStripMenuItem.Size = new System.Drawing.Size(315, 26);
            this.affichageParEnrigistrementToolStripMenuItem.Text = "Affichage par enrigistrement";
            this.affichageParEnrigistrementToolStripMenuItem.Click += new System.EventHandler(this.affichageParEnrigistrementToolStripMenuItem_Click);
            // 
            // affichageEnTabulaireToolStripMenuItem
            // 
            this.affichageEnTabulaireToolStripMenuItem.Name = "affichageEnTabulaireToolStripMenuItem";
            this.affichageEnTabulaireToolStripMenuItem.Size = new System.Drawing.Size(315, 26);
            this.affichageEnTabulaireToolStripMenuItem.Text = "Affichage  tabulaire";
            this.affichageEnTabulaireToolStripMenuItem.Click += new System.EventHandler(this.affichageEnTabulaireToolStripMenuItem_Click);
            // 
            // affichageAPartirDePlusieurTableToolStripMenuItem
            // 
            this.affichageAPartirDePlusieurTableToolStripMenuItem.Name = "affichageAPartirDePlusieurTableToolStripMenuItem";
            this.affichageAPartirDePlusieurTableToolStripMenuItem.Size = new System.Drawing.Size(315, 26);
            this.affichageAPartirDePlusieurTableToolStripMenuItem.Text = "Affichage a partir de plusieur table";
            this.affichageAPartirDePlusieurTableToolStripMenuItem.Click += new System.EventHandler(this.affichageAPartirDePlusieurTableToolStripMenuItem_Click);
            // 
            // affichageMaitreDétailsToolStripMenuItem
            // 
            this.affichageMaitreDétailsToolStripMenuItem.Name = "affichageMaitreDétailsToolStripMenuItem";
            this.affichageMaitreDétailsToolStripMenuItem.Size = new System.Drawing.Size(315, 26);
            this.affichageMaitreDétailsToolStripMenuItem.Text = "Affichage maitre détails";
            this.affichageMaitreDétailsToolStripMenuItem.Click += new System.EventHandler(this.affichageMaitreDétailsToolStripMenuItem_Click);
            // 
            // affichageFiltreToolStripMenuItem
            // 
            this.affichageFiltreToolStripMenuItem.Name = "affichageFiltreToolStripMenuItem";
            this.affichageFiltreToolStripMenuItem.Size = new System.Drawing.Size(315, 26);
            this.affichageFiltreToolStripMenuItem.Text = "Affichage  avec filtre";
            this.affichageFiltreToolStripMenuItem.Click += new System.EventHandler(this.affichageFiltreToolStripMenuItem_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 255);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMenu";
            this.Text = "Menu Ghilas";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem labo2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem affichageParEnrigistrementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem affichageEnTabulaireToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem affichageAPartirDePlusieurTableToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem affichageMaitreDétailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem affichageFiltreToolStripMenuItem;
    }
}

