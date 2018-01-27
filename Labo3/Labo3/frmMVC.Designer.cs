namespace Labo3
{
    partial class frmMVC
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
            System.Windows.Forms.Label empNomLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMVC));
            this.bDVoyagesDataSet = new Labo3.BDVoyagesDataSet();
            this.employeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeTableAdapter = new Labo3.BDVoyagesDataSetTableAdapters.employeTableAdapter();
            this.tableAdapterManager = new Labo3.BDVoyagesDataSetTableAdapters.TableAdapterManager();
            this.employeBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.employeBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.employeDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empNomTextBox = new System.Windows.Forms.TextBox();
            this.btnModifierNom = new System.Windows.Forms.Button();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.btnSuspendreLiaison = new System.Windows.Forms.Button();
            this.btnReprendreLiaison = new System.Windows.Forms.Button();
            this.btnPremierEmploye = new System.Windows.Forms.Button();
            this.btnEmployePrecedent = new System.Windows.Forms.Button();
            this.btnEmployeSuivant = new System.Windows.Forms.Button();
            this.btnEmployeDernier = new System.Windows.Forms.Button();
            this.btnEmployePosition = new System.Windows.Forms.Button();
            this.btnNombreEmploye = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnEmployeUpdate = new System.Windows.Forms.Button();
            this.btnEmployeAdd = new System.Windows.Forms.Button();
            this.btnEmployeDel = new System.Windows.Forms.Button();
            empNomLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bDVoyagesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeBindingNavigator)).BeginInit();
            this.employeBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeDataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // empNomLabel
            // 
            empNomLabel.AutoSize = true;
            empNomLabel.Location = new System.Drawing.Point(45, 274);
            empNomLabel.Name = "empNomLabel";
            empNomLabel.Size = new System.Drawing.Size(72, 17);
            empNomLabel.TabIndex = 2;
            empNomLabel.Text = "emp Nom:";
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
            this.tableAdapterManager.employeTableAdapter = this.employeTableAdapter;
            this.tableAdapterManager.faitLeVoyageTableAdapter = null;
            this.tableAdapterManager.hotelTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Labo3.BDVoyagesDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
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
            this.employeBindingNavigator.Size = new System.Drawing.Size(1018, 27);
            this.employeBindingNavigator.TabIndex = 0;
            this.employeBindingNavigator.Text = "bindingNavigator1";
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(48, 24);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Nombre total d\'éléments";
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
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Placer en premier";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Déplacer vers le haut";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
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
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
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
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // employeBindingNavigatorSaveItem
            // 
            this.employeBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.employeBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("employeBindingNavigatorSaveItem.Image")));
            this.employeBindingNavigatorSaveItem.Name = "employeBindingNavigatorSaveItem";
            this.employeBindingNavigatorSaveItem.Size = new System.Drawing.Size(24, 24);
            this.employeBindingNavigatorSaveItem.Text = "Enregistrer les données";
            this.employeBindingNavigatorSaveItem.Click += new System.EventHandler(this.employeBindingNavigatorSaveItem_Click_1);
            // 
            // employeDataGridView
            // 
            this.employeDataGridView.AutoGenerateColumns = false;
            this.employeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.employeDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.employeDataGridView.DataSource = this.employeBindingSource;
            this.employeDataGridView.Location = new System.Drawing.Point(0, 40);
            this.employeDataGridView.Name = "employeDataGridView";
            this.employeDataGridView.RowTemplate.Height = 24;
            this.employeDataGridView.Size = new System.Drawing.Size(1116, 220);
            this.employeDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "empNo";
            this.dataGridViewTextBoxColumn1.HeaderText = "empNo";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "empPrenom";
            this.dataGridViewTextBoxColumn2.HeaderText = "empPrenom";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "empNom";
            this.dataGridViewTextBoxColumn3.HeaderText = "empNom";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "empEmploi";
            this.dataGridViewTextBoxColumn4.HeaderText = "empEmploi";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "empSal";
            this.dataGridViewTextBoxColumn5.HeaderText = "empSal";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "empComm";
            this.dataGridViewTextBoxColumn6.HeaderText = "empComm";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "empSup";
            this.dataGridViewTextBoxColumn7.HeaderText = "empSup";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "empBureau";
            this.dataGridViewTextBoxColumn8.HeaderText = "empBureau";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // empNomTextBox
            // 
            this.empNomTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeBindingSource, "empNom", true));
            this.empNomTextBox.Location = new System.Drawing.Point(123, 271);
            this.empNomTextBox.Name = "empNomTextBox";
            this.empNomTextBox.Size = new System.Drawing.Size(100, 22);
            this.empNomTextBox.TabIndex = 3;
            // 
            // btnModifierNom
            // 
            this.btnModifierNom.Location = new System.Drawing.Point(264, 267);
            this.btnModifierNom.Name = "btnModifierNom";
            this.btnModifierNom.Size = new System.Drawing.Size(131, 23);
            this.btnModifierNom.TabIndex = 4;
            this.btnModifierNom.Text = "Modifier 1e nom";
            this.btnModifierNom.UseVisualStyleBackColor = true;
            this.btnModifierNom.Click += new System.EventHandler(this.btnModifierNom_Click);
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(418, 267);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(115, 22);
            this.txtNom.TabIndex = 5;
            // 
            // btnSuspendreLiaison
            // 
            this.btnSuspendreLiaison.Location = new System.Drawing.Point(169, 299);
            this.btnSuspendreLiaison.Name = "btnSuspendreLiaison";
            this.btnSuspendreLiaison.Size = new System.Drawing.Size(151, 34);
            this.btnSuspendreLiaison.TabIndex = 6;
            this.btnSuspendreLiaison.Text = "Suspendre la liaison";
            this.btnSuspendreLiaison.UseVisualStyleBackColor = true;
            this.btnSuspendreLiaison.Click += new System.EventHandler(this.btnSuspendreLiaison_Click);
            // 
            // btnReprendreLiaison
            // 
            this.btnReprendreLiaison.Location = new System.Drawing.Point(418, 295);
            this.btnReprendreLiaison.Name = "btnReprendreLiaison";
            this.btnReprendreLiaison.Size = new System.Drawing.Size(147, 34);
            this.btnReprendreLiaison.TabIndex = 7;
            this.btnReprendreLiaison.Text = "Reprendre la liaison";
            this.btnReprendreLiaison.UseVisualStyleBackColor = true;
            this.btnReprendreLiaison.Click += new System.EventHandler(this.btnReprendreLiaison_Click);
            // 
            // btnPremierEmploye
            // 
            this.btnPremierEmploye.BackColor = System.Drawing.Color.Red;
            this.btnPremierEmploye.Location = new System.Drawing.Point(0, 361);
            this.btnPremierEmploye.Name = "btnPremierEmploye";
            this.btnPremierEmploye.Size = new System.Drawing.Size(151, 34);
            this.btnPremierEmploye.TabIndex = 8;
            this.btnPremierEmploye.Text = "Premier Employe";
            this.btnPremierEmploye.UseVisualStyleBackColor = false;
            this.btnPremierEmploye.Click += new System.EventHandler(this.btnPremierEmploye_Click);
            // 
            // btnEmployePrecedent
            // 
            this.btnEmployePrecedent.BackColor = System.Drawing.Color.Yellow;
            this.btnEmployePrecedent.Location = new System.Drawing.Point(169, 361);
            this.btnEmployePrecedent.Name = "btnEmployePrecedent";
            this.btnEmployePrecedent.Size = new System.Drawing.Size(151, 34);
            this.btnEmployePrecedent.TabIndex = 9;
            this.btnEmployePrecedent.Text = "Employe Précédent";
            this.btnEmployePrecedent.UseVisualStyleBackColor = false;
            this.btnEmployePrecedent.Click += new System.EventHandler(this.btnEmployePrecedent_Click);
            // 
            // btnEmployeSuivant
            // 
            this.btnEmployeSuivant.BackColor = System.Drawing.Color.Blue;
            this.btnEmployeSuivant.Location = new System.Drawing.Point(337, 361);
            this.btnEmployeSuivant.Name = "btnEmployeSuivant";
            this.btnEmployeSuivant.Size = new System.Drawing.Size(151, 34);
            this.btnEmployeSuivant.TabIndex = 10;
            this.btnEmployeSuivant.Text = "Employe Suivant";
            this.btnEmployeSuivant.UseVisualStyleBackColor = false;
            this.btnEmployeSuivant.Click += new System.EventHandler(this.btnEmployeSuivant_Click);
            // 
            // btnEmployeDernier
            // 
            this.btnEmployeDernier.BackColor = System.Drawing.Color.Gray;
            this.btnEmployeDernier.Location = new System.Drawing.Point(519, 361);
            this.btnEmployeDernier.Name = "btnEmployeDernier";
            this.btnEmployeDernier.Size = new System.Drawing.Size(151, 34);
            this.btnEmployeDernier.TabIndex = 11;
            this.btnEmployeDernier.Text = "Dernier Employé";
            this.btnEmployeDernier.UseVisualStyleBackColor = false;
            this.btnEmployeDernier.Click += new System.EventHandler(this.btnEmployeDernier_Click);
            // 
            // btnEmployePosition
            // 
            this.btnEmployePosition.BackColor = System.Drawing.Color.White;
            this.btnEmployePosition.Location = new System.Drawing.Point(686, 361);
            this.btnEmployePosition.Name = "btnEmployePosition";
            this.btnEmployePosition.Size = new System.Drawing.Size(151, 34);
            this.btnEmployePosition.TabIndex = 12;
            this.btnEmployePosition.Text = "Position Employé";
            this.btnEmployePosition.UseVisualStyleBackColor = false;
            this.btnEmployePosition.Click += new System.EventHandler(this.btnEmployePosition_Click);
            // 
            // btnNombreEmploye
            // 
            this.btnNombreEmploye.BackColor = System.Drawing.Color.Lime;
            this.btnNombreEmploye.Location = new System.Drawing.Point(855, 361);
            this.btnNombreEmploye.Name = "btnNombreEmploye";
            this.btnNombreEmploye.Size = new System.Drawing.Size(151, 34);
            this.btnNombreEmploye.TabIndex = 13;
            this.btnNombreEmploye.Text = "Nombre d\'Employe";
            this.btnNombreEmploye.UseVisualStyleBackColor = false;
            this.btnNombreEmploye.Click += new System.EventHandler(this.btnNombreEmploye_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnEmployeDel);
            this.panel1.Controls.Add(this.btnEmployeAdd);
            this.panel1.Controls.Add(this.btnEmployeUpdate);
            this.panel1.Location = new System.Drawing.Point(0, 401);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(923, 71);
            this.panel1.TabIndex = 14;
            // 
            // btnEmployeUpdate
            // 
            this.btnEmployeUpdate.BackColor = System.Drawing.Color.Aqua;
            this.btnEmployeUpdate.Location = new System.Drawing.Point(91, 15);
            this.btnEmployeUpdate.Name = "btnEmployeUpdate";
            this.btnEmployeUpdate.Size = new System.Drawing.Size(206, 36);
            this.btnEmployeUpdate.TabIndex = 0;
            this.btnEmployeUpdate.Text = "Actualiser l\'employe Courant";
            this.btnEmployeUpdate.UseVisualStyleBackColor = false;
            this.btnEmployeUpdate.Click += new System.EventHandler(this.btnEmployeUpdate_Click);
            // 
            // btnEmployeAdd
            // 
            this.btnEmployeAdd.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnEmployeAdd.Location = new System.Drawing.Point(358, 15);
            this.btnEmployeAdd.Name = "btnEmployeAdd";
            this.btnEmployeAdd.Size = new System.Drawing.Size(206, 40);
            this.btnEmployeAdd.TabIndex = 1;
            this.btnEmployeAdd.Text = "Ajouter  un Employe";
            this.btnEmployeAdd.UseVisualStyleBackColor = false;
            this.btnEmployeAdd.Click += new System.EventHandler(this.btnEmployeAdd_Click);
            // 
            // btnEmployeDel
            // 
            this.btnEmployeDel.BackColor = System.Drawing.Color.Red;
            this.btnEmployeDel.Location = new System.Drawing.Point(613, 15);
            this.btnEmployeDel.Name = "btnEmployeDel";
            this.btnEmployeDel.Size = new System.Drawing.Size(206, 40);
            this.btnEmployeDel.TabIndex = 2;
            this.btnEmployeDel.Text = "Supprimer l\'employe Courant";
            this.btnEmployeDel.UseVisualStyleBackColor = false;
            this.btnEmployeDel.Click += new System.EventHandler(this.btnEmployeDel_Click);
            // 
            // frmMVC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1018, 464);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnNombreEmploye);
            this.Controls.Add(this.btnEmployePosition);
            this.Controls.Add(this.btnEmployeDernier);
            this.Controls.Add(this.btnEmployeSuivant);
            this.Controls.Add(this.btnEmployePrecedent);
            this.Controls.Add(this.btnPremierEmploye);
            this.Controls.Add(this.btnReprendreLiaison);
            this.Controls.Add(this.btnSuspendreLiaison);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.btnModifierNom);
            this.Controls.Add(empNomLabel);
            this.Controls.Add(this.empNomTextBox);
            this.Controls.Add(this.employeDataGridView);
            this.Controls.Add(this.employeBindingNavigator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "frmMVC";
            this.Text = "frmMVC";
            this.Load += new System.EventHandler(this.frmMVC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bDVoyagesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeBindingNavigator)).EndInit();
            this.employeBindingNavigator.ResumeLayout(false);
            this.employeBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeDataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
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
        private System.Windows.Forms.DataGridView employeDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.TextBox empNomTextBox;
        private System.Windows.Forms.Button btnModifierNom;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.Button btnSuspendreLiaison;
        private System.Windows.Forms.Button btnReprendreLiaison;
        private System.Windows.Forms.Button btnPremierEmploye;
        private System.Windows.Forms.Button btnEmployePrecedent;
        private System.Windows.Forms.Button btnEmployeSuivant;
        private System.Windows.Forms.Button btnEmployeDernier;
        private System.Windows.Forms.Button btnEmployePosition;
        private System.Windows.Forms.Button btnNombreEmploye;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnEmployeUpdate;
        private System.Windows.Forms.Button btnEmployeDel;
        private System.Windows.Forms.Button btnEmployeAdd;
    }
}