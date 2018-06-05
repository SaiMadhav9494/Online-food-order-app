namespace OnlineFoodOrder
{
    partial class reportstaff
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.olfdordrDataSet = new OnlineFoodOrder.Datasources.olfdordrDataSet();
            this.staffBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.staffTableAdapter = new OnlineFoodOrder.Datasources.olfdordrDataSetTableAdapters.staffTableAdapter();
            this.staffidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stateofeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zipcodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.payperhrDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departmentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.olfdordrDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "staffid";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(110, 18);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(346, 15);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.staffidDataGridViewTextBoxColumn,
            this.firstnameDataGridViewTextBoxColumn,
            this.lastnameDataGridViewTextBoxColumn,
            this.address1DataGridViewTextBoxColumn,
            this.address2DataGridViewTextBoxColumn,
            this.cityDataGridViewTextBoxColumn,
            this.stateofeDataGridViewTextBoxColumn,
            this.zipcodeDataGridViewTextBoxColumn,
            this.payperhrDataGridViewTextBoxColumn,
            this.departmentDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.staffBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(16, 81);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(405, 150);
            this.dataGridView1.TabIndex = 3;
            // 
            // olfdordrDataSet
            // 
            this.olfdordrDataSet.DataSetName = "olfdordrDataSet";
            this.olfdordrDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // staffBindingSource
            // 
            this.staffBindingSource.DataMember = "staff";
            this.staffBindingSource.DataSource = this.olfdordrDataSet;
            // 
            // staffTableAdapter
            // 
            this.staffTableAdapter.ClearBeforeFill = true;
            // 
            // staffidDataGridViewTextBoxColumn
            // 
            this.staffidDataGridViewTextBoxColumn.DataPropertyName = "staff_id";
            this.staffidDataGridViewTextBoxColumn.HeaderText = "staff_id";
            this.staffidDataGridViewTextBoxColumn.Name = "staffidDataGridViewTextBoxColumn";
            // 
            // firstnameDataGridViewTextBoxColumn
            // 
            this.firstnameDataGridViewTextBoxColumn.DataPropertyName = "firstname";
            this.firstnameDataGridViewTextBoxColumn.HeaderText = "firstname";
            this.firstnameDataGridViewTextBoxColumn.Name = "firstnameDataGridViewTextBoxColumn";
            // 
            // lastnameDataGridViewTextBoxColumn
            // 
            this.lastnameDataGridViewTextBoxColumn.DataPropertyName = "lastname";
            this.lastnameDataGridViewTextBoxColumn.HeaderText = "lastname";
            this.lastnameDataGridViewTextBoxColumn.Name = "lastnameDataGridViewTextBoxColumn";
            // 
            // address1DataGridViewTextBoxColumn
            // 
            this.address1DataGridViewTextBoxColumn.DataPropertyName = "address1";
            this.address1DataGridViewTextBoxColumn.HeaderText = "address1";
            this.address1DataGridViewTextBoxColumn.Name = "address1DataGridViewTextBoxColumn";
            // 
            // address2DataGridViewTextBoxColumn
            // 
            this.address2DataGridViewTextBoxColumn.DataPropertyName = "address2";
            this.address2DataGridViewTextBoxColumn.HeaderText = "address2";
            this.address2DataGridViewTextBoxColumn.Name = "address2DataGridViewTextBoxColumn";
            // 
            // cityDataGridViewTextBoxColumn
            // 
            this.cityDataGridViewTextBoxColumn.DataPropertyName = "city";
            this.cityDataGridViewTextBoxColumn.HeaderText = "city";
            this.cityDataGridViewTextBoxColumn.Name = "cityDataGridViewTextBoxColumn";
            // 
            // stateofeDataGridViewTextBoxColumn
            // 
            this.stateofeDataGridViewTextBoxColumn.DataPropertyName = "stateofe";
            this.stateofeDataGridViewTextBoxColumn.HeaderText = "stateofe";
            this.stateofeDataGridViewTextBoxColumn.Name = "stateofeDataGridViewTextBoxColumn";
            // 
            // zipcodeDataGridViewTextBoxColumn
            // 
            this.zipcodeDataGridViewTextBoxColumn.DataPropertyName = "zipcode";
            this.zipcodeDataGridViewTextBoxColumn.HeaderText = "zipcode";
            this.zipcodeDataGridViewTextBoxColumn.Name = "zipcodeDataGridViewTextBoxColumn";
            // 
            // payperhrDataGridViewTextBoxColumn
            // 
            this.payperhrDataGridViewTextBoxColumn.DataPropertyName = "payperhr";
            this.payperhrDataGridViewTextBoxColumn.HeaderText = "payperhr";
            this.payperhrDataGridViewTextBoxColumn.Name = "payperhrDataGridViewTextBoxColumn";
            // 
            // departmentDataGridViewTextBoxColumn
            // 
            this.departmentDataGridViewTextBoxColumn.DataPropertyName = "department";
            this.departmentDataGridViewTextBoxColumn.HeaderText = "department";
            this.departmentDataGridViewTextBoxColumn.Name = "departmentDataGridViewTextBoxColumn";
            // 
            // reportstaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 261);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "reportstaff";
            this.Text = "reportstaff";
            this.Load += new System.EventHandler(this.reportstaff_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.olfdordrDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Datasources.olfdordrDataSet olfdordrDataSet;
        private System.Windows.Forms.BindingSource staffBindingSource;
        private Datasources.olfdordrDataSetTableAdapters.staffTableAdapter staffTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn staffidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn address1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn address2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stateofeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zipcodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn payperhrDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn departmentDataGridViewTextBoxColumn;
    }
}