namespace OnlineFoodOrder
{
    partial class reportorders
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
            this.oid = new System.Windows.Forms.TextBox();
            this.ordergrid = new System.Windows.Forms.DataGridView();
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
            ((System.ComponentModel.ISupportInitialize)(this.ordergrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.olfdordrDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(304, 33);
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
            this.label1.Location = new System.Drawing.Point(42, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "order id";
            // 
            // oid
            // 
            this.oid.Location = new System.Drawing.Point(117, 33);
            this.oid.Name = "oid";
            this.oid.Size = new System.Drawing.Size(100, 20);
            this.oid.TabIndex = 2;
            // 
            // ordergrid
            // 
            this.ordergrid.AutoGenerateColumns = false;
            this.ordergrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ordergrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orderIDDataGridViewTextBoxColumn,
            this.customeridDataGridViewTextBoxColumn,
            this.itemidDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.deliveryDataGridViewTextBoxColumn,
            this.paymentDataGridViewTextBoxColumn,
            this.dueTimeDataGridViewTextBoxColumn,
            this.actualTimeDataGridViewTextBoxColumn,
            this.commentsDataGridViewTextBoxColumn});
            this.ordergrid.DataSource = this.ordersBindingSource;
            this.ordergrid.Location = new System.Drawing.Point(45, 91);
            this.ordergrid.Name = "ordergrid";
            this.ordergrid.Size = new System.Drawing.Size(647, 209);
            this.ordergrid.TabIndex = 3;
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
            // reportorders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 312);
            this.Controls.Add(this.ordergrid);
            this.Controls.Add(this.oid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "reportorders";
            this.Text = "reportorders";
            this.Load += new System.EventHandler(this.reportorders_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ordergrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.olfdordrDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox oid;
        private System.Windows.Forms.DataGridView ordergrid;
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