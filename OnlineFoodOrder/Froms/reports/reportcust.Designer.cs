namespace OnlineFoodOrder
{
    partial class reportcust
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
            this.cgrid = new System.Windows.Forms.DataGridView();
            this.fillByToolStrip = new System.Windows.Forms.ToolStrip();
            this.fillByToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.label1 = new System.Windows.Forms.Label();
            this.cid = new System.Windows.Forms.TextBox();
            this.searchbtn = new System.Windows.Forms.Button();
            this.customerIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.middleNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneNbrDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.streetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stateofcDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.commentsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mailStatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.olfdordrDataSet = new OnlineFoodOrder.Datasources.olfdordrDataSet();
            this.customerTableAdapter = new OnlineFoodOrder.Datasources.olfdordrDataSetTableAdapters.CustomerTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.cgrid)).BeginInit();
            this.fillByToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.olfdordrDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // cgrid
            // 
            this.cgrid.AllowUserToAddRows = false;
            this.cgrid.AllowUserToDeleteRows = false;
            this.cgrid.AutoGenerateColumns = false;
            this.cgrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cgrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.customerIDDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.middleNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.phoneNbrDataGridViewTextBoxColumn,
            this.streetDataGridViewTextBoxColumn,
            this.cityDataGridViewTextBoxColumn,
            this.stateofcDataGridViewTextBoxColumn,
            this.commentsDataGridViewTextBoxColumn,
            this.mailStatusDataGridViewTextBoxColumn});
            this.cgrid.DataSource = this.customerBindingSource;
            this.cgrid.Location = new System.Drawing.Point(12, 100);
            this.cgrid.Name = "cgrid";
            this.cgrid.ReadOnly = true;
            this.cgrid.Size = new System.Drawing.Size(590, 189);
            this.cgrid.TabIndex = 0;
            // 
            // fillByToolStrip
            // 
            this.fillByToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fillByToolStripButton});
            this.fillByToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fillByToolStrip.Name = "fillByToolStrip";
            this.fillByToolStrip.Size = new System.Drawing.Size(614, 25);
            this.fillByToolStrip.TabIndex = 1;
            this.fillByToolStrip.Text = "fillByToolStrip";
            // 
            // fillByToolStripButton
            // 
            this.fillByToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillByToolStripButton.Name = "fillByToolStripButton";
            this.fillByToolStripButton.Size = new System.Drawing.Size(39, 22);
            this.fillByToolStripButton.Text = "FillBy";
            this.fillByToolStripButton.Click += new System.EventHandler(this.fillByToolStripButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "customer id";
            // 
            // cid
            // 
            this.cid.Location = new System.Drawing.Point(138, 41);
            this.cid.Name = "cid";
            this.cid.Size = new System.Drawing.Size(100, 20);
            this.cid.TabIndex = 3;
            // 
            // searchbtn
            // 
            this.searchbtn.Location = new System.Drawing.Point(325, 38);
            this.searchbtn.Name = "searchbtn";
            this.searchbtn.Size = new System.Drawing.Size(75, 23);
            this.searchbtn.TabIndex = 4;
            this.searchbtn.Text = "search";
            this.searchbtn.UseVisualStyleBackColor = true;
            this.searchbtn.Click += new System.EventHandler(this.searchbtn_Click);
            // 
            // customerIDDataGridViewTextBoxColumn
            // 
            this.customerIDDataGridViewTextBoxColumn.DataPropertyName = "Customer_ID";
            this.customerIDDataGridViewTextBoxColumn.HeaderText = "Customer_ID";
            this.customerIDDataGridViewTextBoxColumn.Name = "customerIDDataGridViewTextBoxColumn";
            this.customerIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "First_Name";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "First_Name";
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            this.firstNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // middleNameDataGridViewTextBoxColumn
            // 
            this.middleNameDataGridViewTextBoxColumn.DataPropertyName = "Middle_Name";
            this.middleNameDataGridViewTextBoxColumn.HeaderText = "Middle_Name";
            this.middleNameDataGridViewTextBoxColumn.Name = "middleNameDataGridViewTextBoxColumn";
            this.middleNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "Last_Name";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "Last_Name";
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            this.lastNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // phoneNbrDataGridViewTextBoxColumn
            // 
            this.phoneNbrDataGridViewTextBoxColumn.DataPropertyName = "Phone_Nbr";
            this.phoneNbrDataGridViewTextBoxColumn.HeaderText = "Phone_Nbr";
            this.phoneNbrDataGridViewTextBoxColumn.Name = "phoneNbrDataGridViewTextBoxColumn";
            this.phoneNbrDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // streetDataGridViewTextBoxColumn
            // 
            this.streetDataGridViewTextBoxColumn.DataPropertyName = "Street";
            this.streetDataGridViewTextBoxColumn.HeaderText = "Street";
            this.streetDataGridViewTextBoxColumn.Name = "streetDataGridViewTextBoxColumn";
            this.streetDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cityDataGridViewTextBoxColumn
            // 
            this.cityDataGridViewTextBoxColumn.DataPropertyName = "City";
            this.cityDataGridViewTextBoxColumn.HeaderText = "City";
            this.cityDataGridViewTextBoxColumn.Name = "cityDataGridViewTextBoxColumn";
            this.cityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // stateofcDataGridViewTextBoxColumn
            // 
            this.stateofcDataGridViewTextBoxColumn.DataPropertyName = "Stateofc";
            this.stateofcDataGridViewTextBoxColumn.HeaderText = "Stateofc";
            this.stateofcDataGridViewTextBoxColumn.Name = "stateofcDataGridViewTextBoxColumn";
            this.stateofcDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // commentsDataGridViewTextBoxColumn
            // 
            this.commentsDataGridViewTextBoxColumn.DataPropertyName = "Comments";
            this.commentsDataGridViewTextBoxColumn.HeaderText = "Comments";
            this.commentsDataGridViewTextBoxColumn.Name = "commentsDataGridViewTextBoxColumn";
            this.commentsDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mailStatusDataGridViewTextBoxColumn
            // 
            this.mailStatusDataGridViewTextBoxColumn.DataPropertyName = "Mail_Status";
            this.mailStatusDataGridViewTextBoxColumn.HeaderText = "Mail_Status";
            this.mailStatusDataGridViewTextBoxColumn.Name = "mailStatusDataGridViewTextBoxColumn";
            this.mailStatusDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataMember = "Customer";
            this.customerBindingSource.DataSource = this.olfdordrDataSet;
            // 
            // olfdordrDataSet
            // 
            this.olfdordrDataSet.DataSetName = "olfdordrDataSet";
            this.olfdordrDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customerTableAdapter
            // 
            this.customerTableAdapter.ClearBeforeFill = true;
            // 
            // reportcust
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 301);
            this.Controls.Add(this.searchbtn);
            this.Controls.Add(this.cid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fillByToolStrip);
            this.Controls.Add(this.cgrid);
            this.Name = "reportcust";
            this.Text = "reportcust";
            this.Load += new System.EventHandler(this.reportcust_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cgrid)).EndInit();
            this.fillByToolStrip.ResumeLayout(false);
            this.fillByToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.olfdordrDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView cgrid;
        private Datasources.olfdordrDataSet olfdordrDataSet;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private Datasources.olfdordrDataSetTableAdapters.CustomerTableAdapter customerTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn middleNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneNbrDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn streetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stateofcDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn commentsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mailStatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStrip fillByToolStrip;
        private System.Windows.Forms.ToolStripButton fillByToolStripButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox cid;
        private System.Windows.Forms.Button searchbtn;
    }
}