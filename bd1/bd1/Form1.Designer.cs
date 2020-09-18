namespace bd1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataTable1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new bd1.DataSet1();
            this.koli1DataSet = new bd1.koli1DataSet();
            this.хораBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.хораTableAdapter = new bd1.koli1DataSetTableAdapters.ХораTableAdapter();
            this.dataTable1TableAdapter = new bd1.DataSet1TableAdapters.DataTable1TableAdapter();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.хораBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.table1Table2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.колиTableAdapter = new bd1.koli1DataSetTableAdapters.КолиTableAdapter();
            this.хораTableAdapter1 = new bd1.DataSet1TableAdapters.ХораTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dataTable1TableAdapter1 = new bd1.DataSet1TableAdapters.DataTable1TableAdapter();
            this.table1Table2BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.table1Table2BindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.table1Table2BindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.еГНDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.имеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.адресDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.градDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataSet11 = new bd1.DataSet1();
            this.хора1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.хора1TableAdapter = new bd1.DataSet1TableAdapters.Хора1TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.koli1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.хораBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.хораBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table1Table2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table1Table2BindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table1Table2BindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table1Table2BindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.хора1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Broi sobstvenici";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataTable1BindingSource, "NumSob", true));
            this.label2.Location = new System.Drawing.Point(184, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "label2";
            // 
            // dataTable1BindingSource
            // 
            this.dataTable1BindingSource.DataMember = "DataTable1";
            this.dataTable1BindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // koli1DataSet
            // 
            this.koli1DataSet.DataSetName = "koli1DataSet";
            this.koli1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // хораBindingSource
            // 
            this.хораBindingSource.DataMember = "Хора";
            this.хораBindingSource.DataSource = this.koli1DataSet;
            // 
            // хораTableAdapter
            // 
            this.хораTableAdapter.ClearBeforeFill = true;
            // 
            // dataTable1TableAdapter
            // 
            this.dataTable1TableAdapter.ClearBeforeFill = true;
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.хораBindingSource1;
            this.comboBox1.DisplayMember = "Име";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(22, 220);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.ValueMember = "ЕГН";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // хораBindingSource1
            // 
            this.хораBindingSource1.DataMember = "Хора";
            this.хораBindingSource1.DataSource = this.dataSet1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(184, 227);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "label3";
            // 
            // table1Table2BindingSource
            // 
            this.table1Table2BindingSource.DataMember = "Table1Table2";
            this.table1Table2BindingSource.DataSource = this.хораBindingSource;
            // 
            // колиTableAdapter
            // 
            this.колиTableAdapter.ClearBeforeFill = true;
            // 
            // хораTableAdapter1
            // 
            this.хораTableAdapter1.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.еГНDataGridViewTextBoxColumn,
            this.имеDataGridViewTextBoxColumn,
            this.адресDataGridViewTextBoxColumn,
            this.градDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.хора1BindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(364, 57);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(483, 206);
            this.dataGridView1.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(478, 301);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Query";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(772, 301);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Save";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataTable1TableAdapter1
            // 
            this.dataTable1TableAdapter1.ClearBeforeFill = true;
            // 
            // table1Table2BindingSource1
            // 
            this.table1Table2BindingSource1.DataMember = "Table1Table2";
            this.table1Table2BindingSource1.DataSource = this.хораBindingSource;
            // 
            // table1Table2BindingSource2
            // 
            this.table1Table2BindingSource2.DataMember = "Table1Table2";
            this.table1Table2BindingSource2.DataSource = this.хораBindingSource;
            // 
            // table1Table2BindingSource3
            // 
            this.table1Table2BindingSource3.DataMember = "Table1Table2";
            this.table1Table2BindingSource3.DataSource = this.хораBindingSource;
            // 
            // еГНDataGridViewTextBoxColumn
            // 
            this.еГНDataGridViewTextBoxColumn.DataPropertyName = "ЕГН";
            this.еГНDataGridViewTextBoxColumn.HeaderText = "ЕГН";
            this.еГНDataGridViewTextBoxColumn.Name = "еГНDataGridViewTextBoxColumn";
            // 
            // имеDataGridViewTextBoxColumn
            // 
            this.имеDataGridViewTextBoxColumn.DataPropertyName = "Име";
            this.имеDataGridViewTextBoxColumn.HeaderText = "Име";
            this.имеDataGridViewTextBoxColumn.Name = "имеDataGridViewTextBoxColumn";
            // 
            // адресDataGridViewTextBoxColumn
            // 
            this.адресDataGridViewTextBoxColumn.DataPropertyName = "Адрес";
            this.адресDataGridViewTextBoxColumn.HeaderText = "Адрес";
            this.адресDataGridViewTextBoxColumn.Name = "адресDataGridViewTextBoxColumn";
            // 
            // градDataGridViewTextBoxColumn
            // 
            this.градDataGridViewTextBoxColumn.DataPropertyName = "Град";
            this.градDataGridViewTextBoxColumn.HeaderText = "Град";
            this.градDataGridViewTextBoxColumn.Name = "градDataGridViewTextBoxColumn";
            // 
            // dataSet11
            // 
            this.dataSet11.DataSetName = "DataSet1";
            this.dataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // хора1BindingSource
            // 
            this.хора1BindingSource.DataMember = "Хора1";
            this.хора1BindingSource.DataSource = this.dataSet11;
            // 
            // хора1TableAdapter
            // 
            this.хора1TableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.koli1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.хораBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.хораBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table1Table2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table1Table2BindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table1Table2BindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table1Table2BindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.хора1BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private koli1DataSet koli1DataSet;
        private System.Windows.Forms.BindingSource хораBindingSource;
        private koli1DataSetTableAdapters.ХораTableAdapter хораTableAdapter;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource dataTable1BindingSource;
        private DataSet1TableAdapters.DataTable1TableAdapter dataTable1TableAdapter;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.BindingSource table1Table2BindingSource;
        private koli1DataSetTableAdapters.КолиTableAdapter колиTableAdapter;
        private System.Windows.Forms.BindingSource хораBindingSource1;
        private DataSet1TableAdapters.ХораTableAdapter хораTableAdapter1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private DataSet1TableAdapters.DataTable1TableAdapter dataTable1TableAdapter1;
        private System.Windows.Forms.BindingSource table1Table2BindingSource1;
        private System.Windows.Forms.BindingSource table1Table2BindingSource2;
        private System.Windows.Forms.BindingSource table1Table2BindingSource3;
        private System.Windows.Forms.DataGridViewTextBoxColumn еГНDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn имеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn адресDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn градDataGridViewTextBoxColumn;
        private DataSet1 dataSet11;
        private System.Windows.Forms.BindingSource хора1BindingSource;
        private DataSet1TableAdapters.Хора1TableAdapter хора1TableAdapter;
    }
}

