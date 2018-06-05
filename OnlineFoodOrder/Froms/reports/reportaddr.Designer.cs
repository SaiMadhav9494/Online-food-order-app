namespace OnlineFoodOrder
{
    partial class reportaddr
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
            this.cid = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.olfdordrDataSet = new OnlineFoodOrder.Datasources.olfdordrDataSet();
            this.addressdetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.address_detailsTableAdapter = new OnlineFoodOrder.Datasources.olfdordrDataSetTableAdapters.address_detailsTableAdapter();
            this.customeridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addresstypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stateofeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zipcodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.olfdordrDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addressdetailsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "customer id";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(264, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cid
            // 
            this.cid.Location = new System.Drawing.Point(99, 12);
            this.cid.Name = "cid";
            this.cid.Size = new System.Drawing.Size(100, 20);
            this.cid.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.customeridDataGridViewTextBoxColumn,
            this.addresstypeDataGridViewTextBoxColumn,
            this.address1DataGridViewTextBoxColumn,
            this.address2DataGridViewTextBoxColumn,
            this.cityDataGridViewTextBoxColumn,
            this.stateofeDataGridViewTextBoxColumn,
            this.zipcodeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.addressdetailsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(16, 87);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(535, 150);
            this.dataGridView1.TabIndex = 3;
            // 
            // olfdordrDataSet
            // 
            this.olfdordrDataSet.DataSetName = "olfdordrDataSet";
            this.olfdordrDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // addressdetailsBindingSource
            // 
            this.addressdetailsBindingSource.DataMember = "address_details";
            this.addressdetailsBindingSource.DataSource = this.olfdordrDataSet;
            // 
            // address_detailsTableAdapter
            // 
            this.address_detailsTableAdapter.ClearBeforeFill = true;
            // 
            // customeridDataGridViewTextBoxColumn
            // 
            this.customeridDataGridViewTextBoxColumn.DataPropertyName = "customer_id";
            this.customeridDataGridViewTextBoxColumn.HeaderText = "customer_id";
            this.customeridDataGridViewTextBoxColumn.Name = "customeridDataGridViewTextBoxColumn";
            // 
            // addresstypeDataGridViewTextBoxColumn
            // 
            this.addresstypeDataGridViewTextBoxColumn.DataPropertyName = "addresstype";
            this.addresstypeDataGridViewTextBoxColumn.HeaderText = "addresstype";
            this.addresstypeDataGridViewTextBoxColumn.Name = "addresstypeDataGridViewTextBoxColumn";
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
            // reportaddr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 261);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cid);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "reportaddr";
            this.Text = "reportaddr";
            this.Load += new System.EventHandler(this.reportaddr_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.olfdordrDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addressdetailsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox cid;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Datasources.olfdordrDataSet olfdordrDataSet;
        private System.Windows.Forms.BindingSource addressdetailsBindingSource;
        private Datasources.olfdordrDataSetTableAdapters.address_detailsTableAdapter address_detailsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn customeridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addresstypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn address1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn address2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stateofeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zipcodeDataGridViewTextBoxColumn;
    }
}