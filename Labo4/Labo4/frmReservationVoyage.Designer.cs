namespace Labo4
{
    partial class frmReservationVoyage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReservationVoyage));
            this.bDVoyagesDataSet = new Labo4.BDVoyagesDataSet();
            this.destinationsVoyagesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.destinationsVoyagesTableAdapter = new Labo4.BDVoyagesDataSetTableAdapters.destinationsVoyagesTableAdapter();
            this.tableAdapterManager = new Labo4.BDVoyagesDataSetTableAdapters.TableAdapterManager();
            this.destinationsVoyagesBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.destinationsVoyagesBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.destinationsVoyagesComboBox = new System.Windows.Forms.ComboBox();
            this.infoVoyagesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.infoVoyagesTableAdapter = new Labo4.BDVoyagesDataSetTableAdapters.infoVoyagesTableAdapter();
            this.infoVoyagesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dgInfoVoyages = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reservationsVoyagesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reservationsVoyagesTableAdapter = new Labo4.BDVoyagesDataSetTableAdapters.reservationsVoyagesTableAdapter();
            this.fillToolStrip = new System.Windows.Forms.ToolStrip();
            this.dgReservationsVoyages = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAjoutVoyageSelectionné = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bDVoyagesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.destinationsVoyagesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.destinationsVoyagesBindingNavigator)).BeginInit();
            this.destinationsVoyagesBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.infoVoyagesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.infoVoyagesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgInfoVoyages)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservationsVoyagesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgReservationsVoyages)).BeginInit();
            this.SuspendLayout();
            // 
            // bDVoyagesDataSet
            // 
            this.bDVoyagesDataSet.DataSetName = "BDVoyagesDataSet";
            this.bDVoyagesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // destinationsVoyagesBindingSource
            // 
            this.destinationsVoyagesBindingSource.DataMember = "destinationsVoyages";
            this.destinationsVoyagesBindingSource.DataSource = this.bDVoyagesDataSet;
            // 
            // destinationsVoyagesTableAdapter
            // 
            this.destinationsVoyagesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.clientTableAdapter = null;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.contratTableAdapter = null;
            this.tableAdapterManager.employe1TableAdapter = null;
            this.tableAdapterManager.employe2TableAdapter = null;
            this.tableAdapterManager.employeTableAdapter = null;
            this.tableAdapterManager.faitLeVoyageTableAdapter = null;
            this.tableAdapterManager.hotelTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Labo4.BDVoyagesDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.voyageTableAdapter = null;
            // 
            // destinationsVoyagesBindingNavigator
            // 
            this.destinationsVoyagesBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.destinationsVoyagesBindingNavigator.BindingSource = this.destinationsVoyagesBindingSource;
            this.destinationsVoyagesBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.destinationsVoyagesBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.destinationsVoyagesBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.destinationsVoyagesBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.destinationsVoyagesBindingNavigatorSaveItem});
            this.destinationsVoyagesBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.destinationsVoyagesBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.destinationsVoyagesBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.destinationsVoyagesBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.destinationsVoyagesBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.destinationsVoyagesBindingNavigator.Name = "destinationsVoyagesBindingNavigator";
            this.destinationsVoyagesBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.destinationsVoyagesBindingNavigator.Size = new System.Drawing.Size(852, 27);
            this.destinationsVoyagesBindingNavigator.TabIndex = 0;
            this.destinationsVoyagesBindingNavigator.Text = "bindingNavigator1";
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
            // destinationsVoyagesBindingNavigatorSaveItem
            // 
            this.destinationsVoyagesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.destinationsVoyagesBindingNavigatorSaveItem.Enabled = false;
            this.destinationsVoyagesBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("destinationsVoyagesBindingNavigatorSaveItem.Image")));
            this.destinationsVoyagesBindingNavigatorSaveItem.Name = "destinationsVoyagesBindingNavigatorSaveItem";
            this.destinationsVoyagesBindingNavigatorSaveItem.Size = new System.Drawing.Size(24, 24);
            this.destinationsVoyagesBindingNavigatorSaveItem.Text = "Enregistrer les données";
            // 
            // destinationsVoyagesComboBox
            // 
            this.destinationsVoyagesComboBox.DataSource = this.destinationsVoyagesBindingSource;
            this.destinationsVoyagesComboBox.DisplayMember = "voyDestination";
            this.destinationsVoyagesComboBox.FormattingEnabled = true;
            this.destinationsVoyagesComboBox.Location = new System.Drawing.Point(211, 58);
            this.destinationsVoyagesComboBox.Name = "destinationsVoyagesComboBox";
            this.destinationsVoyagesComboBox.Size = new System.Drawing.Size(208, 24);
            this.destinationsVoyagesComboBox.TabIndex = 1;
            this.destinationsVoyagesComboBox.ValueMember = "voyDestination";
            // 
            // infoVoyagesBindingSource
            // 
            this.infoVoyagesBindingSource.DataSource = this.destinationsVoyagesBindingSource;
            // 
            // infoVoyagesTableAdapter
            // 
            this.infoVoyagesTableAdapter.ClearBeforeFill = true;
            // 
            // infoVoyagesBindingSource1
            // 
            this.infoVoyagesBindingSource1.DataMember = "destinationsVoyages_infoVoyages";
            this.infoVoyagesBindingSource1.DataSource = this.destinationsVoyagesBindingSource;
            // 
            // dgInfoVoyages
            // 
            this.dgInfoVoyages.AllowUserToAddRows = false;
            this.dgInfoVoyages.AllowUserToDeleteRows = false;
            this.dgInfoVoyages.AutoGenerateColumns = false;
            this.dgInfoVoyages.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgInfoVoyages.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgInfoVoyages.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn6});
            this.dgInfoVoyages.DataSource = this.infoVoyagesBindingSource1;
            this.dgInfoVoyages.Location = new System.Drawing.Point(30, 114);
            this.dgInfoVoyages.Name = "dgInfoVoyages";
            this.dgInfoVoyages.ReadOnly = true;
            this.dgInfoVoyages.RowHeadersWidth = 20;
            this.dgInfoVoyages.RowTemplate.Height = 24;
            this.dgInfoVoyages.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgInfoVoyages.Size = new System.Drawing.Size(822, 220);
            this.dgInfoVoyages.TabIndex = 2;
            this.dgInfoVoyages.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgInfoVoyages_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "voyNo";
            this.dataGridViewTextBoxColumn1.HeaderText = "NUMERO";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "voyDateDepart";
            this.dataGridViewTextBoxColumn2.HeaderText = "Date de départ";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "voyDateArrive";
            this.dataGridViewTextBoxColumn3.HeaderText = "Date d\'arrivée";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "animateur";
            this.dataGridViewTextBoxColumn5.HeaderText = "animateur";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "voyDestination";
            this.dataGridViewTextBoxColumn4.HeaderText = "Destination";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "hotNom";
            this.dataGridViewTextBoxColumn6.HeaderText = "Hôtel";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // reservationsVoyagesBindingSource
            // 
            this.reservationsVoyagesBindingSource.DataMember = "destinationsVoyages_reservationsVoyages";
            this.reservationsVoyagesBindingSource.DataSource = this.destinationsVoyagesBindingSource;
            // 
            // reservationsVoyagesTableAdapter
            // 
            this.reservationsVoyagesTableAdapter.ClearBeforeFill = true;
            // 
            // fillToolStrip
            // 
            this.fillToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.fillToolStrip.Location = new System.Drawing.Point(0, 27);
            this.fillToolStrip.Name = "fillToolStrip";
            this.fillToolStrip.Size = new System.Drawing.Size(852, 25);
            this.fillToolStrip.TabIndex = 3;
            this.fillToolStrip.Text = "fillToolStrip";
            // 
            // dgReservationsVoyages
            // 
            this.dgReservationsVoyages.AllowUserToAddRows = false;
            this.dgReservationsVoyages.AllowUserToDeleteRows = false;
            this.dgReservationsVoyages.AutoGenerateColumns = false;
            this.dgReservationsVoyages.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgReservationsVoyages.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgReservationsVoyages.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14});
            this.dgReservationsVoyages.DataSource = this.reservationsVoyagesBindingSource;
            this.dgReservationsVoyages.Location = new System.Drawing.Point(30, 384);
            this.dgReservationsVoyages.Name = "dgReservationsVoyages";
            this.dgReservationsVoyages.ReadOnly = true;
            this.dgReservationsVoyages.RowHeadersWidth = 20;
            this.dgReservationsVoyages.RowTemplate.Height = 24;
            this.dgReservationsVoyages.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgReservationsVoyages.Size = new System.Drawing.Size(822, 235);
            this.dgReservationsVoyages.TabIndex = 4;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "conNo";
            this.dataGridViewTextBoxColumn7.HeaderText = "No Contrat";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "conDate";
            this.dataGridViewTextBoxColumn8.HeaderText = "Date  du contrat";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "cliNo";
            this.dataGridViewTextBoxColumn9.HeaderText = "No de client";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "voyNo";
            this.dataGridViewTextBoxColumn10.HeaderText = "No de Voyage";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "voyDateDepart";
            this.dataGridViewTextBoxColumn11.HeaderText = "Date de départ";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "voyDateArrive";
            this.dataGridViewTextBoxColumn12.HeaderText = "Date d\'arrivée";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "voyDestination";
            this.dataGridViewTextBoxColumn13.HeaderText = "Destination";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "hotNom";
            this.dataGridViewTextBoxColumn14.HeaderText = "Hôtel";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(74, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Destination";
            // 
            // btnAjoutVoyageSelectionné
            // 
            this.btnAjoutVoyageSelectionné.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjoutVoyageSelectionné.Location = new System.Drawing.Point(456, 55);
            this.btnAjoutVoyageSelectionné.Name = "btnAjoutVoyageSelectionné";
            this.btnAjoutVoyageSelectionné.Size = new System.Drawing.Size(384, 43);
            this.btnAjoutVoyageSelectionné.TabIndex = 6;
            this.btnAjoutVoyageSelectionné.Text = "Ajouter le voyage selectionné à votre voyage";
            this.btnAjoutVoyageSelectionné.UseVisualStyleBackColor = true;
            this.btnAjoutVoyageSelectionné.Click += new System.EventHandler(this.btnAjoutVoyageSelectionné_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 361);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(194, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Vos voyages reservés";
            // 
            // frmReservationVoyage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 631);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAjoutVoyageSelectionné);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgReservationsVoyages);
            this.Controls.Add(this.fillToolStrip);
            this.Controls.Add(this.dgInfoVoyages);
            this.Controls.Add(this.destinationsVoyagesComboBox);
            this.Controls.Add(this.destinationsVoyagesBindingNavigator);
            this.Name = "frmReservationVoyage";
            this.Text = "Reservation de Voyage";
            this.Load += new System.EventHandler(this.frmReservationVoyage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bDVoyagesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.destinationsVoyagesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.destinationsVoyagesBindingNavigator)).EndInit();
            this.destinationsVoyagesBindingNavigator.ResumeLayout(false);
            this.destinationsVoyagesBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.infoVoyagesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.infoVoyagesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgInfoVoyages)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservationsVoyagesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgReservationsVoyages)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BDVoyagesDataSet bDVoyagesDataSet;
        private System.Windows.Forms.BindingSource destinationsVoyagesBindingSource;
        private BDVoyagesDataSetTableAdapters.destinationsVoyagesTableAdapter destinationsVoyagesTableAdapter;
        private BDVoyagesDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator destinationsVoyagesBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton destinationsVoyagesBindingNavigatorSaveItem;
        private System.Windows.Forms.ComboBox destinationsVoyagesComboBox;
        private System.Windows.Forms.BindingSource infoVoyagesBindingSource;
        private BDVoyagesDataSetTableAdapters.infoVoyagesTableAdapter infoVoyagesTableAdapter;
        private System.Windows.Forms.BindingSource infoVoyagesBindingSource1;
        private System.Windows.Forms.DataGridView dgInfoVoyages;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.BindingSource reservationsVoyagesBindingSource;
        private BDVoyagesDataSetTableAdapters.reservationsVoyagesTableAdapter reservationsVoyagesTableAdapter;
        private System.Windows.Forms.ToolStrip fillToolStrip;
        private System.Windows.Forms.DataGridView dgReservationsVoyages;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAjoutVoyageSelectionné;
        private System.Windows.Forms.Label label2;
    }
}