namespace OnlineFoodOrder
{
    partial class reportreward
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
            this.rewgrid = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_submit = new System.Windows.Forms.Button();
            this.cid = new System.Windows.Forms.TextBox();
            this.olfdordrDataSet = new OnlineFoodOrder.Datasources.olfdordrDataSet();
            this.rewardsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rewardsTableAdapter = new OnlineFoodOrder.Datasources.olfdordrDataSetTableAdapters.rewardsTableAdapter();
            this.customeridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rewardsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderintotalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.rewgrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.olfdordrDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rewardsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // rewgrid
            // 
            this.rewgrid.AllowUserToAddRows = false;
            this.rewgrid.AllowUserToDeleteRows = false;
            this.rewgrid.AutoGenerateColumns = false;
            this.rewgrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.rewgrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.customeridDataGridViewTextBoxColumn,
            this.rewardsDataGridViewTextBoxColumn,
            this.orderintotalDataGridViewTextBoxColumn});
            this.rewgrid.DataSource = this.rewardsBindingSource;
            this.rewgrid.Location = new System.Drawing.Point(28, 88);
            this.rewgrid.Name = "rewgrid";
            this.rewgrid.ReadOnly = true;
            this.rewgrid.Size = new System.Drawing.Size(349, 190);
            this.rewgrid.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "customer id";
            // 
            // btn_submit
            // 
            this.btn_submit.Location = new System.Drawing.Point(302, 12);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(75, 23);
            this.btn_submit.TabIndex = 2;
            this.btn_submit.Text = "search";
            this.btn_submit.UseVisualStyleBackColor = true;
            this.btn_submit.Click += new System.EventHandler(this.btn_submit_Click);
            // 
            // cid
            // 
            this.cid.Location = new System.Drawing.Point(105, 15);
            this.cid.Name = "cid";
            this.cid.Size = new System.Drawing.Size(100, 20);
            this.cid.TabIndex = 3;
            // 
            // olfdordrDataSet
            // 
            this.olfdordrDataSet.DataSetName = "olfdordrDataSet";
            this.olfdordrDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rewardsBindingSource
            // 
            this.rewardsBindingSource.DataMember = "rewards";
            this.rewardsBindingSource.DataSource = this.olfdordrDataSet;
            // 
            // rewardsTableAdapter
            // 
            this.rewardsTableAdapter.ClearBeforeFill = true;
            // 
            // customeridDataGridViewTextBoxColumn
            // 
            this.customeridDataGridViewTextBoxColumn.DataPropertyName = "customer_id";
            this.customeridDataGridViewTextBoxColumn.HeaderText = "customer_id";
            this.customeridDataGridViewTextBoxColumn.Name = "customeridDataGridViewTextBoxColumn";
            this.customeridDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rewardsDataGridViewTextBoxColumn
            // 
            this.rewardsDataGridViewTextBoxColumn.DataPropertyName = "rewards";
            this.rewardsDataGridViewTextBoxColumn.HeaderText = "rewards";
            this.rewardsDataGridViewTextBoxColumn.Name = "rewardsDataGridViewTextBoxColumn";
            this.rewardsDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // orderintotalDataGridViewTextBoxColumn
            // 
            this.orderintotalDataGridViewTextBoxColumn.DataPropertyName = "orderintotal";
            this.orderintotalDataGridViewTextBoxColumn.HeaderText = "orderintotal";
            this.orderintotalDataGridViewTextBoxColumn.Name = "orderintotalDataGridViewTextBoxColumn";
            this.orderintotalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // reportreward
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 290);
            this.Controls.Add(this.cid);
            this.Controls.Add(this.btn_submit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rewgrid);
            this.Name = "reportreward";
            this.Text = "reportreward";
            this.Load += new System.EventHandler(this.reportreward_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rewgrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.olfdordrDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rewardsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView rewgrid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_submit;
        private System.Windows.Forms.TextBox cid;
        private Datasources.olfdordrDataSet olfdordrDataSet;
        private System.Windows.Forms.BindingSource rewardsBindingSource;
        private Datasources.olfdordrDataSetTableAdapters.rewardsTableAdapter rewardsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn customeridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rewardsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderintotalDataGridViewTextBoxColumn;
    }
}