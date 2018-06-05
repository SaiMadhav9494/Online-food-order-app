namespace OnlineFoodOrder
{
    partial class reportstafftim
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.olfdordrDataSet = new OnlineFoodOrder.Datasources.olfdordrDataSet();
            this.staffhoursBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.staffhoursTableAdapter = new OnlineFoodOrder.Datasources.olfdordrDataSetTableAdapters.staffhoursTableAdapter();
            this.staffidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.logintimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.logouttimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hourswrkdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.olfdordrDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffhoursBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.staffidDataGridViewTextBoxColumn,
            this.workdateDataGridViewTextBoxColumn,
            this.logintimeDataGridViewTextBoxColumn,
            this.logouttimeDataGridViewTextBoxColumn,
            this.hourswrkdDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.staffhoursBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(24, 99);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(420, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "staff id";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(157, 18);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(369, 16);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // olfdordrDataSet
            // 
            this.olfdordrDataSet.DataSetName = "olfdordrDataSet";
            this.olfdordrDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // staffhoursBindingSource
            // 
            this.staffhoursBindingSource.DataMember = "staffhours";
            this.staffhoursBindingSource.DataSource = this.olfdordrDataSet;
            // 
            // staffhoursTableAdapter
            // 
            this.staffhoursTableAdapter.ClearBeforeFill = true;
            // 
            // staffidDataGridViewTextBoxColumn
            // 
            this.staffidDataGridViewTextBoxColumn.DataPropertyName = "staff_id";
            this.staffidDataGridViewTextBoxColumn.HeaderText = "staff_id";
            this.staffidDataGridViewTextBoxColumn.Name = "staffidDataGridViewTextBoxColumn";
            // 
            // workdateDataGridViewTextBoxColumn
            // 
            this.workdateDataGridViewTextBoxColumn.DataPropertyName = "workdate";
            this.workdateDataGridViewTextBoxColumn.HeaderText = "workdate";
            this.workdateDataGridViewTextBoxColumn.Name = "workdateDataGridViewTextBoxColumn";
            // 
            // logintimeDataGridViewTextBoxColumn
            // 
            this.logintimeDataGridViewTextBoxColumn.DataPropertyName = "logintime";
            this.logintimeDataGridViewTextBoxColumn.HeaderText = "logintime";
            this.logintimeDataGridViewTextBoxColumn.Name = "logintimeDataGridViewTextBoxColumn";
            // 
            // logouttimeDataGridViewTextBoxColumn
            // 
            this.logouttimeDataGridViewTextBoxColumn.DataPropertyName = "logouttime";
            this.logouttimeDataGridViewTextBoxColumn.HeaderText = "logouttime";
            this.logouttimeDataGridViewTextBoxColumn.Name = "logouttimeDataGridViewTextBoxColumn";
            // 
            // hourswrkdDataGridViewTextBoxColumn
            // 
            this.hourswrkdDataGridViewTextBoxColumn.DataPropertyName = "hourswrkd";
            this.hourswrkdDataGridViewTextBoxColumn.HeaderText = "hourswrkd";
            this.hourswrkdDataGridViewTextBoxColumn.Name = "hourswrkdDataGridViewTextBoxColumn";
            // 
            // reportstafftim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 261);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "reportstafftim";
            this.Text = "reportstafftim";
            this.Load += new System.EventHandler(this.reportstafftim_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.olfdordrDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffhoursBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private Datasources.olfdordrDataSet olfdordrDataSet;
        private System.Windows.Forms.BindingSource staffhoursBindingSource;
        private Datasources.olfdordrDataSetTableAdapters.staffhoursTableAdapter staffhoursTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn staffidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn workdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn logintimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn logouttimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hourswrkdDataGridViewTextBoxColumn;
    }
}