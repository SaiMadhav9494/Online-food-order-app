namespace OnlineFoodOrder
{
    partial class reportcustords
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.olfdordrDataSet = new OnlineFoodOrder.Datasources.olfdordrDataSet();
            this.ordersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ordersTableAdapter = new OnlineFoodOrder.Datasources.olfdordrDataSetTableAdapters.OrdersTableAdapter();
            this.orderIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customeridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deliveryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dueTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.actualTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.commentsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.olfdordrDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(294, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(108, 16);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "cust id";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orderIDDataGridViewTextBoxColumn,
            this.customeridDataGridViewTextBoxColumn,
            this.itemidDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.deliveryDataGridViewTextBoxColumn,
            this.paymentDataGridViewTextBoxColumn,
            this.dueTimeDataGridViewTextBoxColumn,
            this.actualTimeDataGridViewTextBoxColumn,
            this.commentsDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.ordersBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(19, 78);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(434, 150);
            this.dataGridView1.TabIndex = 3;
            // 
            // olfdordrDataSet
            // 
            this.olfdordrDataSet.DataSetName = "olfdordrDataSet";
            this.olfdordrDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ordersBindingSource
            // 
            this.ordersBindingSource.DataMember = "Orders";
            this.ordersBindingSource.DataSource = this.olfdordrDataSet;
            // 
            // ordersTableAdapter
            // 
            this.ordersTableAdapter.ClearBeforeFill = true;
            // 
            // orderIDDataGridViewTextBoxColumn
            // 
            this.orderIDDataGridViewTextBoxColumn.DataPropertyName = "Order_ID";
            this.orderIDDataGridViewTextBoxColumn.HeaderText = "Order_ID";
            this.orderIDDataGridViewTextBoxColumn.Name = "orderIDDataGridViewTextBoxColumn";
            // 
            // customeridDataGridViewTextBoxColumn
            // 
            this.customeridDataGridViewTextBoxColumn.DataPropertyName = "Customer_id";
            this.customeridDataGridViewTextBoxColumn.HeaderText = "Customer_id";
            this.customeridDataGridViewTextBoxColumn.Name = "customeridDataGridViewTextBoxColumn";
            // 
            // itemidDataGridViewTextBoxColumn
            // 
            this.itemidDataGridViewTextBoxColumn.DataPropertyName = "item_id";
            this.itemidDataGridViewTextBoxColumn.HeaderText = "item_id";
            this.itemidDataGridViewTextBoxColumn.Name = "itemidDataGridViewTextBoxColumn";
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            // 
            // deliveryDataGridViewTextBoxColumn
            // 
            this.deliveryDataGridViewTextBoxColumn.DataPropertyName = "Delivery";
            this.deliveryDataGridViewTextBoxColumn.HeaderText = "Delivery";
            this.deliveryDataGridViewTextBoxColumn.Name = "deliveryDataGridViewTextBoxColumn";
            // 
            // paymentDataGridViewTextBoxColumn
            // 
            this.paymentDataGridViewTextBoxColumn.DataPropertyName = "Payment";
            this.paymentDataGridViewTextBoxColumn.HeaderText = "Payment";
            this.paymentDataGridViewTextBoxColumn.Name = "paymentDataGridViewTextBoxColumn";
            // 
            // dueTimeDataGridViewTextBoxColumn
            // 
            this.dueTimeDataGridViewTextBoxColumn.DataPropertyName = "Due_Time";
            this.dueTimeDataGridViewTextBoxColumn.HeaderText = "Due_Time";
            this.dueTimeDataGridViewTextBoxColumn.Name = "dueTimeDataGridViewTextBoxColumn";
            // 
            // actualTimeDataGridViewTextBoxColumn
            // 
            this.actualTimeDataGridViewTextBoxColumn.DataPropertyName = "Actual_Time";
            this.actualTimeDataGridViewTextBoxColumn.HeaderText = "Actual_Time";
            this.actualTimeDataGridViewTextBoxColumn.Name = "actualTimeDataGridViewTextBoxColumn";
            // 
            // commentsDataGridViewTextBoxColumn
            // 
            this.commentsDataGridViewTextBoxColumn.DataPropertyName = "Comments";
            this.commentsDataGridViewTextBoxColumn.HeaderText = "Comments";
            this.commentsDataGridViewTextBoxColumn.Name = "commentsDataGridViewTextBoxColumn";
            // 
            // reportcustords
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 261);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Name = "reportcustords";
            this.Text = "reportcustords";
            this.Load += new System.EventHandler(this.reportcustords_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.olfdordrDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Datasources.olfdordrDataSet olfdordrDataSet;
        private System.Windows.Forms.BindingSource ordersBindingSource;
        private Datasources.olfdordrDataSetTableAdapters.OrdersTableAdapter ordersTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customeridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deliveryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paymentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dueTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn actualTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn commentsDataGridViewTextBoxColumn;
    }
}