namespace Labo21
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
            this.lABORATOIREToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aFFICHERENRIGISTREMENTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aFFICHAGETABULAIREToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.affichageDePlusieursTablesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.affichageMaitreDAÉTAILSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.affichageAvecFiltreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lABORATOIREToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(487, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // lABORATOIREToolStripMenuItem
            // 
            this.lABORATOIREToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aFFICHERENRIGISTREMENTToolStripMenuItem,
            this.aFFICHAGETABULAIREToolStripMenuItem,
            this.affichageDePlusieursTablesToolStripMenuItem,
            this.affichageMaitreDAÉTAILSToolStripMenuItem,
            this.affichageAvecFiltreToolStripMenuItem});
            this.lABORATOIREToolStripMenuItem.Name = "lABORATOIREToolStripMenuItem";
            this.lABORATOIREToolStripMenuItem.Size = new System.Drawing.Size(125, 24);
            this.lABORATOIREToolStripMenuItem.Text = "LABORATOIRE2";
            this.lABORATOIREToolStripMenuItem.Click += new System.EventHandler(this.lABORATOIREToolStripMenuItem_Click);
            // 
            // aFFICHERENRIGISTREMENTToolStripMenuItem
            // 
            this.aFFICHERENRIGISTREMENTToolStripMenuItem.Name = "aFFICHERENRIGISTREMENTToolStripMenuItem";
            this.aFFICHERENRIGISTREMENTToolStripMenuItem.Size = new System.Drawing.Size(275, 26);
            this.aFFICHERENRIGISTREMENTToolStripMenuItem.Text = "AFFICHER ENRIGISTREMENT";
            this.aFFICHERENRIGISTREMENTToolStripMenuItem.Click += new System.EventHandler(this.aFFICHERENRIGISTREMENTToolStripMenuItem_Click);
            // 
            // aFFICHAGETABULAIREToolStripMenuItem
            // 
            this.aFFICHAGETABULAIREToolStripMenuItem.Name = "aFFICHAGETABULAIREToolStripMenuItem";
            this.aFFICHAGETABULAIREToolStripMenuItem.Size = new System.Drawing.Size(275, 26);
            this.aFFICHAGETABULAIREToolStripMenuItem.Text = "AFFICHAGE TABULAIRE";
            this.aFFICHAGETABULAIREToolStripMenuItem.Click += new System.EventHandler(this.aFFICHAGETABULAIREToolStripMenuItem_Click);
            // 
            // affichageDePlusieursTablesToolStripMenuItem
            // 
            this.affichageDePlusieursTablesToolStripMenuItem.Name = "affichageDePlusieursTablesToolStripMenuItem";
            this.affichageDePlusieursTablesToolStripMenuItem.Size = new System.Drawing.Size(275, 26);
            this.affichageDePlusieursTablesToolStripMenuItem.Text = "Affichage de plusieurs tables";
            this.affichageDePlusieursTablesToolStripMenuItem.Click += new System.EventHandler(this.affichageDePlusieursTablesToolStripMenuItem_Click);
            // 
            // affichageMaitreDAÉTAILSToolStripMenuItem
            // 
            this.affichageMaitreDAÉTAILSToolStripMenuItem.Name = "affichageMaitreDAÉTAILSToolStripMenuItem";
            this.affichageMaitreDAÉTAILSToolStripMenuItem.Size = new System.Drawing.Size(275, 26);
            this.affichageMaitreDAÉTAILSToolStripMenuItem.Text = "Affichage Maitre/DAÉTAILS";
            this.affichageMaitreDAÉTAILSToolStripMenuItem.Click += new System.EventHandler(this.affichageMaitreDAÉTAILSToolStripMenuItem_Click);
            // 
            // affichageAvecFiltreToolStripMenuItem
            // 
            this.affichageAvecFiltreToolStripMenuItem.Name = "affichageAvecFiltreToolStripMenuItem";
            this.affichageAvecFiltreToolStripMenuItem.Size = new System.Drawing.Size(275, 26);
            this.affichageAvecFiltreToolStripMenuItem.Text = "Affichage avec Filtre";
            this.affichageAvecFiltreToolStripMenuItem.Click += new System.EventHandler(this.affichageAvecFiltreToolStripMenuItem_Click);
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 304);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMenu";
            this.Text = "FrmMenuSamir";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem lABORATOIREToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aFFICHERENRIGISTREMENTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aFFICHAGETABULAIREToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem affichageDePlusieursTablesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem affichageMaitreDAÉTAILSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem affichageAvecFiltreToolStripMenuItem;
    }
}

