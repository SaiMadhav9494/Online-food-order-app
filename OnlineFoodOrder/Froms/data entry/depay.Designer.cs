namespace OnlineFoodOrder
{
    partial class depay
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
            this.btnsubmit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cid = new System.Windows.Forms.TextBox();
            this.cnam = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnsubmit
            // 
            this.btnsubmit.Location = new System.Drawing.Point(205, 90);
            this.btnsubmit.Name = "btnsubmit";
            this.btnsubmit.Size = new System.Drawing.Size(75, 23);
            this.btnsubmit.TabIndex = 0;
            this.btnsubmit.Text = "submit";
            this.btnsubmit.UseVisualStyleBackColor = true;
            this.btnsubmit.Click += new System.EventHandler(this.btnsubmit_click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Category Id";
            // 
            // cid
            // 
            this.cid.Location = new System.Drawing.Point(146, 32);
            this.cid.Name = "cid";
            this.cid.Size = new System.Drawing.Size(100, 20);
            this.cid.TabIndex = 2;
            // 
            // cnam
            // 
            this.cnam.Location = new System.Drawing.Point(381, 35);
            this.cnam.Name = "cnam";
            this.cnam.Size = new System.Drawing.Size(100, 20);
            this.cnam.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(288, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "category name";
            // 
            // depay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 261);
            this.Controls.Add(this.cnam);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnsubmit);
            this.Name = "depay";
            this.Text = "depay";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnsubmit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox cid;
        private System.Windows.Forms.TextBox cnam;
        private System.Windows.Forms.Label label2;
    }
}