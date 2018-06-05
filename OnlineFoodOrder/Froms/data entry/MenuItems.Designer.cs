namespace OnlineFoodOrder
{
    partial class MenuItems
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnsubmit = new System.Windows.Forms.Button();
            this.itemid = new System.Windows.Forms.TextBox();
            this.itemname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.desc = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.price = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.preptime = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.catid = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comm = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Item Id";
            // 
            // btnsubmit
            // 
            this.btnsubmit.Location = new System.Drawing.Point(227, 254);
            this.btnsubmit.Name = "btnsubmit";
            this.btnsubmit.Size = new System.Drawing.Size(75, 23);
            this.btnsubmit.TabIndex = 1;
            this.btnsubmit.Text = "Submit";
            this.btnsubmit.UseVisualStyleBackColor = true;
            this.btnsubmit.Click += new System.EventHandler(this.btnsubmit_click);
            // 
            // itemid
            // 
            this.itemid.Location = new System.Drawing.Point(157, 41);
            this.itemid.Name = "itemid";
            this.itemid.Size = new System.Drawing.Size(100, 20);
            this.itemid.TabIndex = 2;
            // 
            // itemname
            // 
            this.itemname.Location = new System.Drawing.Point(157, 81);
            this.itemname.Name = "itemname";
            this.itemname.Size = new System.Drawing.Size(100, 20);
            this.itemname.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Name";
            // 
            // desc
            // 
            this.desc.Location = new System.Drawing.Point(157, 122);
            this.desc.Name = "desc";
            this.desc.Size = new System.Drawing.Size(100, 20);
            this.desc.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Description";
            // 
            // price
            // 
            this.price.Location = new System.Drawing.Point(157, 161);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(100, 20);
            this.price.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(54, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Price";
            // 
            // preptime
            // 
            this.preptime.Location = new System.Drawing.Point(157, 209);
            this.preptime.Name = "preptime";
            this.preptime.Size = new System.Drawing.Size(100, 20);
            this.preptime.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(54, 209);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "preperation time";
            // 
            // catid
            // 
            this.catid.Location = new System.Drawing.Point(426, 41);
            this.catid.Name = "catid";
            this.catid.Size = new System.Drawing.Size(100, 20);
            this.catid.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(323, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "category id";
            // 
            // comm
            // 
            this.comm.Location = new System.Drawing.Point(426, 81);
            this.comm.Name = "comm";
            this.comm.Size = new System.Drawing.Size(100, 20);
            this.comm.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(323, 81);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Comments";
            // 
            // MenuItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 306);
            this.Controls.Add(this.comm);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.catid);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.preptime);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.price);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.desc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.itemname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.itemid);
            this.Controls.Add(this.btnsubmit);
            this.Controls.Add(this.label1);
            this.Name = "MenuItems";
            this.Text = "MenuItems";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnsubmit;
        private System.Windows.Forms.TextBox itemid;
        private System.Windows.Forms.TextBox itemname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox desc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox price;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox preptime;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox catid;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox comm;
        private System.Windows.Forms.Label label7;
    }
}