namespace OnlineFoodOrder
{
    partial class reportaddrtypes
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
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.addresstypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addresstypesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.olfdordrDataSet = new OnlineFoodOrder.Datasources.olfdordrDataSet();
            this.addresstypesTableAdapter = new OnlineFoodOrder.Datasources.olfdordrDataSetTableAdapters.addresstypesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addresstypesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.olfdordrDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "addresstype";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(240, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(99, 15);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.addresstypeDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.addresstypesBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(53, 67);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(241, 150);
            this.dataGridView1.TabIndex = 3;
            // 
            // addresstypeDataGridViewTextBoxColumn
            // 
            this.addresstypeDataGridViewTextBoxColumn.DataPropertyName = "addresstype";
            this.addresstypeDataGridViewTextBoxColumn.HeaderText = "addresstype";
            this.addresstypeDataGridViewTextBoxColumn.Name = "addresstypeDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // addresstypesBindingSource
            // 
            this.addresstypesBindingSource.DataMember = "addresstypes";
            this.addresstypesBindingSource.DataSource = this.olfdordrDataSet;
            // 
            // olfdordrDataSet
            // 
            this.olfdordrDataSet.DataSetName = "olfdordrDataSet";
            this.olfdordrDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // addresstypesTableAdapter
            // 
            this.addresstypesTableAdapter.ClearBeforeFill = true;
            // 
            // reportaddrtypes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 261);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "reportaddrtypes";
            this.Text = "reportaddrtypes";
            this.Load += new System.EventHandler(this.reportaddrtypes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addresstypesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.olfdordrDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Datasources.olfdordrDataSet olfdordrDataSet;
        private System.Windows.Forms.BindingSource addresstypesBindingSource;
        private Datasources.olfdordrDataSetTableAdapters.addresstypesTableAdapter addresstypesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn addresstypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
    }
}