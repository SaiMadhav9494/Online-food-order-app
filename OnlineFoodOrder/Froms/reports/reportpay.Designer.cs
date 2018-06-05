namespace OnlineFoodOrder
{
    partial class reportpay
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
            this.cid = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.olfdordrDataSet = new OnlineFoodOrder.Datasources.olfdordrDataSet();
            this.paymentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.paymentsTableAdapter = new OnlineFoodOrder.Datasources.olfdordrDataSetTableAdapters.paymentsTableAdapter();
            this.customeridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymenttypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cardnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paydateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.olfdordrDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(294, 22);
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
            this.label1.Location = new System.Drawing.Point(31, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Customer id";
            // 
            // cid
            // 
            this.cid.Location = new System.Drawing.Point(117, 22);
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
            this.orderIDDataGridViewTextBoxColumn,
            this.paymenttypeDataGridViewTextBoxColumn,
            this.cardnoDataGridViewTextBoxColumn,
            this.paydateDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.paymentsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(34, 84);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(416, 150);
            this.dataGridView1.TabIndex = 3;
            // 
            // olfdordrDataSet
            // 
            this.olfdordrDataSet.DataSetName = "olfdordrDataSet";
            this.olfdordrDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // paymentsBindingSource
            // 
            this.paymentsBindingSource.DataMember = "payments";
            this.paymentsBindingSource.DataSource = this.olfdordrDataSet;
            // 
            // paymentsTableAdapter
            // 
            this.paymentsTableAdapter.ClearBeforeFill = true;
            // 
            // customeridDataGridViewTextBoxColumn
            // 
            this.customeridDataGridViewTextBoxColumn.DataPropertyName = "customer_id";
            this.customeridDataGridViewTextBoxColumn.HeaderText = "customer_id";
            this.customeridDataGridViewTextBoxColumn.Name = "customeridDataGridViewTextBoxColumn";
            // 
            // orderIDDataGridViewTextBoxColumn
            // 
            this.orderIDDataGridViewTextBoxColumn.DataPropertyName = "Order_ID";
            this.orderIDDataGridViewTextBoxColumn.HeaderText = "Order_ID";
            this.orderIDDataGridViewTextBoxColumn.Name = "orderIDDataGridViewTextBoxColumn";
            // 
            // paymenttypeDataGridViewTextBoxColumn
            // 
            this.paymenttypeDataGridViewTextBoxColumn.DataPropertyName = "paymenttype";
            this.paymenttypeDataGridViewTextBoxColumn.HeaderText = "paymenttype";
            this.paymenttypeDataGridViewTextBoxColumn.Name = "paymenttypeDataGridViewTextBoxColumn";
            // 
            // cardnoDataGridViewTextBoxColumn
            // 
            this.cardnoDataGridViewTextBoxColumn.DataPropertyName = "card_no";
            this.cardnoDataGridViewTextBoxColumn.HeaderText = "card_no";
            this.cardnoDataGridViewTextBoxColumn.Name = "cardnoDataGridViewTextBoxColumn";
            // 
            // paydateDataGridViewTextBoxColumn
            // 
            this.paydateDataGridViewTextBoxColumn.DataPropertyName = "pay_date";
            this.paydateDataGridViewTextBoxColumn.HeaderText = "pay_date";
            this.paydateDataGridViewTextBoxColumn.Name = "paydateDataGridViewTextBoxColumn";
            // 
            // reportpay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 261);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "reportpay";
            this.Text = "reportpay";
            this.Load += new System.EventHandler(this.reportpay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.olfdordrDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox cid;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Datasources.olfdordrDataSet olfdordrDataSet;
        private System.Windows.Forms.BindingSource paymentsBindingSource;
        private Datasources.olfdordrDataSetTableAdapters.paymentsTableAdapter paymentsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn customeridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paymenttypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cardnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paydateDataGridViewTextBoxColumn;
    }
}