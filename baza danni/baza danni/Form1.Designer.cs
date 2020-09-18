namespace baza_danni
{
    partial class Form1
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
            System.Windows.Forms.Label номерLabel;
            System.Windows.Forms.Label маркаLabel;
            System.Windows.Forms.Label моделLabel;
            System.Windows.Forms.Label цвятLabel;
            System.Windows.Forms.Label годинаLabel;
            System.Windows.Forms.Label ценаLabel;
            System.Windows.Forms.Label еГНLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.koli1DataSet = new baza_danni.koli1DataSet();
            this.колиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.колиTableAdapter = new baza_danni.koli1DataSetTableAdapters.КолиTableAdapter();
            this.tableAdapterManager = new baza_danni.koli1DataSetTableAdapters.TableAdapterManager();
            this.колиBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.колиBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.колиDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.номерTextBox = new System.Windows.Forms.TextBox();
            this.маркаTextBox = new System.Windows.Forms.TextBox();
            this.моделTextBox = new System.Windows.Forms.TextBox();
            this.цвятTextBox = new System.Windows.Forms.TextBox();
            this.годинаTextBox = new System.Windows.Forms.TextBox();
            this.ценаTextBox = new System.Windows.Forms.TextBox();
            this.еГНTextBox = new System.Windows.Forms.TextBox();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem1 = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem1 = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            номерLabel = new System.Windows.Forms.Label();
            маркаLabel = new System.Windows.Forms.Label();
            моделLabel = new System.Windows.Forms.Label();
            цвятLabel = new System.Windows.Forms.Label();
            годинаLabel = new System.Windows.Forms.Label();
            ценаLabel = new System.Windows.Forms.Label();
            еГНLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.koli1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.колиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.колиBindingNavigator)).BeginInit();
            this.колиBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.колиDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            this.SuspendLayout();
            // 
            // номерLabel
            // 
            номерLabel.AutoSize = true;
            номерLabel.Location = new System.Drawing.Point(375, 106);
            номерLabel.Name = "номерLabel";
            номерLabel.Size = new System.Drawing.Size(55, 17);
            номерLabel.TabIndex = 2;
            номерLabel.Text = "Номер:";
            // 
            // маркаLabel
            // 
            маркаLabel.AutoSize = true;
            маркаLabel.Location = new System.Drawing.Point(375, 134);
            маркаLabel.Name = "маркаLabel";
            маркаLabel.Size = new System.Drawing.Size(54, 17);
            маркаLabel.TabIndex = 4;
            маркаLabel.Text = "Марка:";
            // 
            // моделLabel
            // 
            моделLabel.AutoSize = true;
            моделLabel.Location = new System.Drawing.Point(375, 162);
            моделLabel.Name = "моделLabel";
            моделLabel.Size = new System.Drawing.Size(55, 17);
            моделLabel.TabIndex = 6;
            моделLabel.Text = "Модел:";
            // 
            // цвятLabel
            // 
            цвятLabel.AutoSize = true;
            цвятLabel.Location = new System.Drawing.Point(375, 190);
            цвятLabel.Name = "цвятLabel";
            цвятLabel.Size = new System.Drawing.Size(45, 17);
            цвятLabel.TabIndex = 8;
            цвятLabel.Text = "Цвят:";
            // 
            // годинаLabel
            // 
            годинаLabel.AutoSize = true;
            годинаLabel.Location = new System.Drawing.Point(375, 218);
            годинаLabel.Name = "годинаLabel";
            годинаLabel.Size = new System.Drawing.Size(60, 17);
            годинаLabel.TabIndex = 10;
            годинаLabel.Text = "Година:";
            // 
            // ценаLabel
            // 
            ценаLabel.AutoSize = true;
            ценаLabel.Location = new System.Drawing.Point(375, 246);
            ценаLabel.Name = "ценаLabel";
            ценаLabel.Size = new System.Drawing.Size(47, 17);
            ценаLabel.TabIndex = 12;
            ценаLabel.Text = "Цена:";
            // 
            // еГНLabel
            // 
            еГНLabel.AutoSize = true;
            еГНLabel.Location = new System.Drawing.Point(375, 274);
            еГНLabel.Name = "еГНLabel";
            еГНLabel.Size = new System.Drawing.Size(39, 17);
            еГНLabel.TabIndex = 14;
            еГНLabel.Text = "ЕГН:";
            // 
            // koli1DataSet
            // 
            this.koli1DataSet.DataSetName = "koli1DataSet";
            this.koli1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // колиBindingSource
            // 
            this.колиBindingSource.DataMember = "Коли";
            this.колиBindingSource.DataSource = this.koli1DataSet;
            // 
            // колиTableAdapter
            // 
            this.колиTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = baza_danni.koli1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.КолиTableAdapter = this.колиTableAdapter;
            this.tableAdapterManager.ХораTableAdapter = null;
            // 
            // колиBindingNavigator
            // 
            this.колиBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.колиBindingNavigator.BindingSource = this.колиBindingSource;
            this.колиBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.колиBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.колиBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.колиBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.колиBindingNavigatorSaveItem});
            this.колиBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.колиBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.колиBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.колиBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.колиBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.колиBindingNavigator.Name = "колиBindingNavigator";
            this.колиBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.колиBindingNavigator.Size = new System.Drawing.Size(800, 27);
            this.колиBindingNavigator.TabIndex = 0;
            this.колиBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 24);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
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
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
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
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // колиBindingNavigatorSaveItem
            // 
            this.колиBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.колиBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("колиBindingNavigatorSaveItem.Image")));
            this.колиBindingNavigatorSaveItem.Name = "колиBindingNavigatorSaveItem";
            this.колиBindingNavigatorSaveItem.Size = new System.Drawing.Size(24, 24);
            this.колиBindingNavigatorSaveItem.Text = "Save Data";
            this.колиBindingNavigatorSaveItem.Click += new System.EventHandler(this.колиBindingNavigatorSaveItem_Click);
            // 
            // колиDataGridView
            // 
            this.колиDataGridView.AutoGenerateColumns = false;
            this.колиDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.колиDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.колиDataGridView.DataSource = this.колиBindingSource;
            this.колиDataGridView.Location = new System.Drawing.Point(12, 62);
            this.колиDataGridView.Name = "колиDataGridView";
            this.колиDataGridView.RowTemplate.Height = 24;
            this.колиDataGridView.Size = new System.Drawing.Size(191, 318);
            this.колиDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Номер";
            this.dataGridViewTextBoxColumn1.HeaderText = "Номер";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Марка";
            this.dataGridViewTextBoxColumn2.HeaderText = "Марка";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Модел";
            this.dataGridViewTextBoxColumn3.HeaderText = "Модел";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Цвят";
            this.dataGridViewTextBoxColumn4.HeaderText = "Цвят";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Година";
            this.dataGridViewTextBoxColumn5.HeaderText = "Година";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Цена";
            this.dataGridViewTextBoxColumn6.HeaderText = "Цена";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "ЕГН";
            this.dataGridViewTextBoxColumn7.HeaderText = "ЕГН";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // номерTextBox
            // 
            this.номерTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.колиBindingSource, "Номер", true));
            this.номерTextBox.Location = new System.Drawing.Point(441, 103);
            this.номерTextBox.Name = "номерTextBox";
            this.номерTextBox.Size = new System.Drawing.Size(100, 22);
            this.номерTextBox.TabIndex = 3;
            // 
            // маркаTextBox
            // 
            this.маркаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.колиBindingSource, "Марка", true));
            this.маркаTextBox.Location = new System.Drawing.Point(441, 131);
            this.маркаTextBox.Name = "маркаTextBox";
            this.маркаTextBox.Size = new System.Drawing.Size(100, 22);
            this.маркаTextBox.TabIndex = 5;
            // 
            // моделTextBox
            // 
            this.моделTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.колиBindingSource, "Модел", true));
            this.моделTextBox.Location = new System.Drawing.Point(441, 162);
            this.моделTextBox.Name = "моделTextBox";
            this.моделTextBox.Size = new System.Drawing.Size(100, 22);
            this.моделTextBox.TabIndex = 7;
            // 
            // цвятTextBox
            // 
            this.цвятTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.колиBindingSource, "Цвят", true));
            this.цвятTextBox.Location = new System.Drawing.Point(441, 190);
            this.цвятTextBox.Name = "цвятTextBox";
            this.цвятTextBox.Size = new System.Drawing.Size(100, 22);
            this.цвятTextBox.TabIndex = 9;
            // 
            // годинаTextBox
            // 
            this.годинаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.колиBindingSource, "Година", true));
            this.годинаTextBox.Location = new System.Drawing.Point(441, 215);
            this.годинаTextBox.Name = "годинаTextBox";
            this.годинаTextBox.Size = new System.Drawing.Size(100, 22);
            this.годинаTextBox.TabIndex = 11;
            // 
            // ценаTextBox
            // 
            this.ценаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.колиBindingSource, "Цена", true));
            this.ценаTextBox.Location = new System.Drawing.Point(441, 243);
            this.ценаTextBox.Name = "ценаTextBox";
            this.ценаTextBox.Size = new System.Drawing.Size(100, 22);
            this.ценаTextBox.TabIndex = 13;
            // 
            // еГНTextBox
            // 
            this.еГНTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.колиBindingSource, "ЕГН", true));
            this.еГНTextBox.Location = new System.Drawing.Point(441, 271);
            this.еГНTextBox.Name = "еГНTextBox";
            this.еГНTextBox.Size = new System.Drawing.Size(100, 22);
            this.еГНTextBox.TabIndex = 15;
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = this.bindingNavigatorAddNewItem1;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem1;
            this.bindingNavigator1.DeleteItem = this.bindingNavigatorDeleteItem1;
            this.bindingNavigator1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem1,
            this.bindingNavigatorMovePreviousItem1,
            this.bindingNavigatorSeparator3,
            this.bindingNavigatorPositionItem1,
            this.bindingNavigatorCountItem1,
            this.bindingNavigatorSeparator4,
            this.bindingNavigatorMoveNextItem1,
            this.bindingNavigatorMoveLastItem1,
            this.bindingNavigatorSeparator5,
            this.bindingNavigatorAddNewItem1,
            this.bindingNavigatorDeleteItem1});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 27);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem1;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem1;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem1;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem1;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem1;
            this.bindingNavigator1.Size = new System.Drawing.Size(800, 27);
            this.bindingNavigator1.TabIndex = 16;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem1
            // 
            this.bindingNavigatorAddNewItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem1.Image")));
            this.bindingNavigatorAddNewItem1.Name = "bindingNavigatorAddNewItem1";
            this.bindingNavigatorAddNewItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem1.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorAddNewItem1.Text = "Add new";
            // 
            // bindingNavigatorCountItem1
            // 
            this.bindingNavigatorCountItem1.Name = "bindingNavigatorCountItem1";
            this.bindingNavigatorCountItem1.Size = new System.Drawing.Size(45, 24);
            this.bindingNavigatorCountItem1.Text = "of {0}";
            this.bindingNavigatorCountItem1.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem1
            // 
            this.bindingNavigatorDeleteItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem1.Image")));
            this.bindingNavigatorDeleteItem1.Name = "bindingNavigatorDeleteItem1";
            this.bindingNavigatorDeleteItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem1.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorDeleteItem1.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem1
            // 
            this.bindingNavigatorMoveFirstItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem1.Image")));
            this.bindingNavigatorMoveFirstItem1.Name = "bindingNavigatorMoveFirstItem1";
            this.bindingNavigatorMoveFirstItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem1.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveFirstItem1.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem1
            // 
            this.bindingNavigatorMovePreviousItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem1.Image")));
            this.bindingNavigatorMovePreviousItem1.Name = "bindingNavigatorMovePreviousItem1";
            this.bindingNavigatorMovePreviousItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem1.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMovePreviousItem1.Text = "Move previous";
            // 
            // bindingNavigatorSeparator3
            // 
            this.bindingNavigatorSeparator3.Name = "bindingNavigatorSeparator3";
            this.bindingNavigatorSeparator3.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem1
            // 
            this.bindingNavigatorPositionItem1.AccessibleName = "Position";
            this.bindingNavigatorPositionItem1.AutoSize = false;
            this.bindingNavigatorPositionItem1.Name = "bindingNavigatorPositionItem1";
            this.bindingNavigatorPositionItem1.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem1.Text = "0";
            this.bindingNavigatorPositionItem1.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator4
            // 
            this.bindingNavigatorSeparator4.Name = "bindingNavigatorSeparator4";
            this.bindingNavigatorSeparator4.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem1
            // 
            this.bindingNavigatorMoveNextItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem1.Image")));
            this.bindingNavigatorMoveNextItem1.Name = "bindingNavigatorMoveNextItem1";
            this.bindingNavigatorMoveNextItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem1.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveNextItem1.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem1
            // 
            this.bindingNavigatorMoveLastItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem1.Image")));
            this.bindingNavigatorMoveLastItem1.Name = "bindingNavigatorMoveLastItem1";
            this.bindingNavigatorMoveLastItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem1.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveLastItem1.Text = "Move last";
            // 
            // bindingNavigatorSeparator5
            // 
            this.bindingNavigatorSeparator5.Name = "bindingNavigatorSeparator5";
            this.bindingNavigatorSeparator5.Size = new System.Drawing.Size(6, 27);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 479);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(номерLabel);
            this.Controls.Add(this.номерTextBox);
            this.Controls.Add(маркаLabel);
            this.Controls.Add(this.маркаTextBox);
            this.Controls.Add(моделLabel);
            this.Controls.Add(this.моделTextBox);
            this.Controls.Add(цвятLabel);
            this.Controls.Add(this.цвятTextBox);
            this.Controls.Add(годинаLabel);
            this.Controls.Add(this.годинаTextBox);
            this.Controls.Add(ценаLabel);
            this.Controls.Add(this.ценаTextBox);
            this.Controls.Add(еГНLabel);
            this.Controls.Add(this.еГНTextBox);
            this.Controls.Add(this.колиDataGridView);
            this.Controls.Add(this.колиBindingNavigator);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.koli1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.колиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.колиBindingNavigator)).EndInit();
            this.колиBindingNavigator.ResumeLayout(false);
            this.колиBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.колиDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private koli1DataSet koli1DataSet;
        private System.Windows.Forms.BindingSource колиBindingSource;
        private koli1DataSetTableAdapters.КолиTableAdapter колиTableAdapter;
        private koli1DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator колиBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton колиBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView колиDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.TextBox номерTextBox;
        private System.Windows.Forms.TextBox маркаTextBox;
        private System.Windows.Forms.TextBox моделTextBox;
        private System.Windows.Forms.TextBox цвятTextBox;
        private System.Windows.Forms.TextBox годинаTextBox;
        private System.Windows.Forms.TextBox ценаTextBox;
        private System.Windows.Forms.TextBox еГНTextBox;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem1;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator3;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator4;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator5;
    }
}

