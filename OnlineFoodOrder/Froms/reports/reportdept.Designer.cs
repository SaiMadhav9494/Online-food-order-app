namespace OnlineFoodOrder
{
    partial class reportdept
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.olfdordrDataSet = new OnlineFoodOrder.Datasources.olfdordrDataSet();
            this.departmentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.departmentsTableAdapter = new OnlineFoodOrder.Datasources.olfdordrDataSetTableAdapters.departmentsTableAdapter();
            this.departmentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departmentnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.olfdordrDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(276, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "department id";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(96, 8);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.departmentDataGridViewTextBoxColumn,
            this.departmentnameDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.departmentsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 83);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(245, 150);
            this.dataGridView1.TabIndex = 3;
            // 
            // olfdordrDataSet
            // 
            this.olfdordrDataSet.DataSetName = "olfdordrDataSet";
            this.olfdordrDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // departmentsBindingSource
            // 
            this.departmentsBindingSource.DataMember = "departments";
            this.departmentsBindingSource.DataSource = this.olfdordrDataSet;
            // 
            // departmentsTableAdapter
            // 
            this.departmentsTableAdapter.ClearBeforeFill = true;
            // 
            // departmentDataGridViewTextBoxColumn
            // 
            this.departmentDataGridViewTextBoxColumn.DataPropertyName = "department";
            this.departmentDataGridViewTextBoxColumn.HeaderText = "department";
            this.departmentDataGridViewTextBoxColumn.Name = "departmentDataGridViewTextBoxColumn";
            // 
            // departmentnameDataGridViewTextBoxColumn
            // 
            this.departmentnameDataGridViewTextBoxColumn.DataPropertyName = "departmentname";
            this.departmentnameDataGridViewTextBoxColumn.HeaderText = "departmentname";
            this.departmentnameDataGridViewTextBoxColumn.Name = "departmentnameDataGridViewTextBoxColumn";
            // 
            // reportdept
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 261);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "reportdept";
            this.Text = "reportdept";
            this.Load += new System.EventHandler(this.reportdept_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.olfdordrDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Datasources.olfdordrDataSet olfdordrDataSet;
        private System.Windows.Forms.BindingSource departmentsBindingSource;
        private Datasources.olfdordrDataSetTableAdapters.departmentsTableAdapter departmentsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn departmentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn departmentnameDataGridViewTextBoxColumn;
    }
}