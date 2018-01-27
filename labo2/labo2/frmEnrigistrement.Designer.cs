namespace labo2
{
    partial class frmEnrigistrement
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEnrigistrement));
            System.Windows.Forms.Label empNoLabel;
            System.Windows.Forms.Label empPrenomLabel;
            System.Windows.Forms.Label empNomLabel;
            System.Windows.Forms.Label empEmploiLabel;
            System.Windows.Forms.Label empSalLabel;
            System.Windows.Forms.Label empCommLabel;
            System.Windows.Forms.Label empSupLabel;
            System.Windows.Forms.Label empBureauLabel;
            this.bDVoyagesDataSet = new labo2.BDVoyagesDataSet();
            this.employeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeTableAdapter = new labo2.BDVoyagesDataSetTableAdapters.employeTableAdapter();
            this.tableAdapterManager = new labo2.BDVoyagesDataSetTableAdapters.TableAdapterManager();
            this.employeBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.employeBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.empNoTextBox = new System.Windows.Forms.TextBox();
            this.empPrenomTextBox = new System.Windows.Forms.TextBox();
            this.empNomTextBox = new System.Windows.Forms.TextBox();
            this.empEmploiTextBox = new System.Windows.Forms.TextBox();
            this.empSalTextBox = new System.Windows.Forms.TextBox();
            this.empCommTextBox = new System.Windows.Forms.TextBox();
            this.empSupTextBox = new System.Windows.Forms.TextBox();
            this.empBureauTextBox = new System.Windows.Forms.TextBox();
            empNoLabel = new System.Windows.Forms.Label();
            empPrenomLabel = new System.Windows.Forms.Label();
            empNomLabel = new System.Windows.Forms.Label();
            empEmploiLabel = new System.Windows.Forms.Label();
            empSalLabel = new System.Windows.Forms.Label();
            empCommLabel = new System.Windows.Forms.Label();
            empSupLabel = new System.Windows.Forms.Label();
            empBureauLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bDVoyagesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeBindingNavigator)).BeginInit();
            this.employeBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // bDVoyagesDataSet
            // 
            this.bDVoyagesDataSet.DataSetName = "BDVoyagesDataSet";
            this.bDVoyagesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // employeBindingSource
            // 
            this.employeBindingSource.DataMember = "employe";
            this.employeBindingSource.DataSource = this.bDVoyagesDataSet;
            // 
            // employeTableAdapter
            // 
            this.employeTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.clientTableAdapter = null;
            this.tableAdapterManager.contratTableAdapter = null;
            this.tableAdapterManager.employe1TableAdapter = null;
            this.tableAdapterManager.employe2TableAdapter = null;
            this.tableAdapterManager.employeTableAdapter = this.employeTableAdapter;
            this.tableAdapterManager.faitLeVoyageTableAdapter = null;
            this.tableAdapterManager.hotelTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = labo2.BDVoyagesDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.voyageTableAdapter = null;
            // 
            // employeBindingNavigator
            // 
            this.employeBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.employeBindingNavigator.BindingSource = this.employeBindingSource;
            this.employeBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.employeBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.employeBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.employeBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.employeBindingNavigatorSaveItem});
            this.employeBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.employeBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.employeBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.employeBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.employeBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.employeBindingNavigator.Name = "employeBindingNavigator";
            this.employeBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.employeBindingNavigator.Size = new System.Drawing.Size(364, 27);
            this.employeBindingNavigator.TabIndex = 0;
            this.employeBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(24, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Placer en premier";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(24, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Déplacer vers le haut";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Position actuelle";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(48, 20);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Nombre total d\'éléments";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveNextItem.Text = "Déplacer vers le bas";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveLastItem.Text = "Placer en dernier";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorAddNewItem.Text = "Ajouter nouveau";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorDeleteItem.Text = "Supprimer";
            // 
            // employeBindingNavigatorSaveItem
            // 
            this.employeBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.employeBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("employeBindingNavigatorSaveItem.Image")));
            this.employeBindingNavigatorSaveItem.Name = "employeBindingNavigatorSaveItem";
            this.employeBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.employeBindingNavigatorSaveItem.Text = "Enregistrer les données";
            this.employeBindingNavigatorSaveItem.Click += new System.EventHandler(this.employeBindingNavigatorSaveItem_Click);
            // 
            // empNoLabel
            // 
            empNoLabel.AutoSize = true;
            empNoLabel.Location = new System.Drawing.Point(73, 51);
            empNoLabel.Name = "empNoLabel";
            empNoLabel.Size = new System.Drawing.Size(61, 17);
            empNoLabel.TabIndex = 1;
            empNoLabel.Text = "emp No:";
            // 
            // empNoTextBox
            // 
            this.empNoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeBindingSource, "empNo", true));
            this.empNoTextBox.Location = new System.Drawing.Point(171, 48);
            this.empNoTextBox.Name = "empNoTextBox";
            this.empNoTextBox.Size = new System.Drawing.Size(100, 22);
            this.empNoTextBox.TabIndex = 2;
            // 
            // empPrenomLabel
            // 
            empPrenomLabel.AutoSize = true;
            empPrenomLabel.Location = new System.Drawing.Point(73, 79);
            empPrenomLabel.Name = "empPrenomLabel";
            empPrenomLabel.Size = new System.Drawing.Size(92, 17);
            empPrenomLabel.TabIndex = 3;
            empPrenomLabel.Text = "emp Prenom:";
            // 
            // empPrenomTextBox
            // 
            this.empPrenomTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeBindingSource, "empPrenom", true));
            this.empPrenomTextBox.Location = new System.Drawing.Point(171, 76);
            this.empPrenomTextBox.Name = "empPrenomTextBox";
            this.empPrenomTextBox.Size = new System.Drawing.Size(100, 22);
            this.empPrenomTextBox.TabIndex = 4;
            // 
            // empNomLabel
            // 
            empNomLabel.AutoSize = true;
            empNomLabel.Location = new System.Drawing.Point(73, 107);
            empNomLabel.Name = "empNomLabel";
            empNomLabel.Size = new System.Drawing.Size(72, 17);
            empNomLabel.TabIndex = 5;
            empNomLabel.Text = "emp Nom:";
            // 
            // empNomTextBox
            // 
            this.empNomTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeBindingSource, "empNom", true));
            this.empNomTextBox.Location = new System.Drawing.Point(171, 104);
            this.empNomTextBox.Name = "empNomTextBox";
            this.empNomTextBox.Size = new System.Drawing.Size(100, 22);
            this.empNomTextBox.TabIndex = 6;
            // 
            // empEmploiLabel
            // 
            empEmploiLabel.AutoSize = true;
            empEmploiLabel.Location = new System.Drawing.Point(73, 135);
            empEmploiLabel.Name = "empEmploiLabel";
            empEmploiLabel.Size = new System.Drawing.Size(85, 17);
            empEmploiLabel.TabIndex = 7;
            empEmploiLabel.Text = "emp Emploi:";
            // 
            // empEmploiTextBox
            // 
            this.empEmploiTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeBindingSource, "empEmploi", true));
            this.empEmploiTextBox.Location = new System.Drawing.Point(171, 132);
            this.empEmploiTextBox.Name = "empEmploiTextBox";
            this.empEmploiTextBox.Size = new System.Drawing.Size(100, 22);
            this.empEmploiTextBox.TabIndex = 8;
            // 
            // empSalLabel
            // 
            empSalLabel.AutoSize = true;
            empSalLabel.Location = new System.Drawing.Point(73, 163);
            empSalLabel.Name = "empSalLabel";
            empSalLabel.Size = new System.Drawing.Size(63, 17);
            empSalLabel.TabIndex = 9;
            empSalLabel.Text = "emp Sal:";
            // 
            // empSalTextBox
            // 
            this.empSalTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeBindingSource, "empSal", true));
            this.empSalTextBox.Location = new System.Drawing.Point(171, 160);
            this.empSalTextBox.Name = "empSalTextBox";
            this.empSalTextBox.Size = new System.Drawing.Size(100, 22);
            this.empSalTextBox.TabIndex = 10;
            // 
            // empCommLabel
            // 
            empCommLabel.AutoSize = true;
            empCommLabel.Location = new System.Drawing.Point(73, 191);
            empCommLabel.Name = "empCommLabel";
            empCommLabel.Size = new System.Drawing.Size(82, 17);
            empCommLabel.TabIndex = 11;
            empCommLabel.Text = "emp Comm:";
            // 
            // empCommTextBox
            // 
            this.empCommTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeBindingSource, "empComm", true));
            this.empCommTextBox.Location = new System.Drawing.Point(171, 188);
            this.empCommTextBox.Name = "empCommTextBox";
            this.empCommTextBox.Size = new System.Drawing.Size(100, 22);
            this.empCommTextBox.TabIndex = 12;
            // 
            // empSupLabel
            // 
            empSupLabel.AutoSize = true;
            empSupLabel.Location = new System.Drawing.Point(73, 219);
            empSupLabel.Name = "empSupLabel";
            empSupLabel.Size = new System.Drawing.Size(68, 17);
            empSupLabel.TabIndex = 13;
            empSupLabel.Text = "emp Sup:";
            // 
            // empSupTextBox
            // 
            this.empSupTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeBindingSource, "empSup", true));
            this.empSupTextBox.Location = new System.Drawing.Point(171, 216);
            this.empSupTextBox.Name = "empSupTextBox";
            this.empSupTextBox.Size = new System.Drawing.Size(100, 22);
            this.empSupTextBox.TabIndex = 14;
            // 
            // empBureauLabel
            // 
            empBureauLabel.AutoSize = true;
            empBureauLabel.Location = new System.Drawing.Point(73, 247);
            empBureauLabel.Name = "empBureauLabel";
            empBureauLabel.Size = new System.Drawing.Size(89, 17);
            empBureauLabel.TabIndex = 15;
            empBureauLabel.Text = "emp Bureau:";
            // 
            // empBureauTextBox
            // 
            this.empBureauTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeBindingSource, "empBureau", true));
            this.empBureauTextBox.Location = new System.Drawing.Point(171, 244);
            this.empBureauTextBox.Name = "empBureauTextBox";
            this.empBureauTextBox.Size = new System.Drawing.Size(100, 22);
            this.empBureauTextBox.TabIndex = 16;
            // 
            // frmEnrigistrement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 286);
            this.Controls.Add(empNoLabel);
            this.Controls.Add(this.empNoTextBox);
            this.Controls.Add(empPrenomLabel);
            this.Controls.Add(this.empPrenomTextBox);
            this.Controls.Add(empNomLabel);
            this.Controls.Add(this.empNomTextBox);
            this.Controls.Add(empEmploiLabel);
            this.Controls.Add(this.empEmploiTextBox);
            this.Controls.Add(empSalLabel);
            this.Controls.Add(this.empSalTextBox);
            this.Controls.Add(empCommLabel);
            this.Controls.Add(this.empCommTextBox);
            this.Controls.Add(empSupLabel);
            this.Controls.Add(this.empSupTextBox);
            this.Controls.Add(empBureauLabel);
            this.Controls.Add(this.empBureauTextBox);
            this.Controls.Add(this.employeBindingNavigator);
            this.Name = "frmEnrigistrement";
            this.Text = "frmEnrigistrement";
            this.Load += new System.EventHandler(this.frmEnrigistrement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bDVoyagesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeBindingNavigator)).EndInit();
            this.employeBindingNavigator.ResumeLayout(false);
            this.employeBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BDVoyagesDataSet bDVoyagesDataSet;
        private System.Windows.Forms.BindingSource employeBindingSource;
        private BDVoyagesDataSetTableAdapters.employeTableAdapter employeTableAdapter;
        private BDVoyagesDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator employeBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton employeBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox empNoTextBox;
        private System.Windows.Forms.TextBox empPrenomTextBox;
        private System.Windows.Forms.TextBox empNomTextBox;
        private System.Windows.Forms.TextBox empEmploiTextBox;
        private System.Windows.Forms.TextBox empSalTextBox;
        private System.Windows.Forms.TextBox empCommTextBox;
        private System.Windows.Forms.TextBox empSupTextBox;
        private System.Windows.Forms.TextBox empBureauTextBox;
    }
}