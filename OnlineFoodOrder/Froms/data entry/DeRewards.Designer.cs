namespace OnlineFoodOrder
{
    partial class DeRewards
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
            this.did = new System.Windows.Forms.TextBox();
            this.dna = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnsubmit
            // 
            this.btnsubmit.Location = new System.Drawing.Point(231, 131);
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
            this.label1.Location = new System.Drawing.Point(67, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "department id";
            // 
            // did
            // 
            this.did.Location = new System.Drawing.Point(169, 44);
            this.did.Name = "did";
            this.did.Size = new System.Drawing.Size(100, 20);
            this.did.TabIndex = 2;
            // 
            // dna
            // 
            this.dna.Location = new System.Drawing.Point(426, 47);
            this.dna.Name = "dna";
            this.dna.Size = new System.Drawing.Size(100, 20);
            this.dna.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(324, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "department name";
            // 
            // DeRewards
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 261);
            this.Controls.Add(this.dna);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.did);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnsubmit);
            this.Name = "DeRewards";
            this.Text = "DeRewards";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnsubmit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox did;
        private System.Windows.Forms.TextBox dna;
        private System.Windows.Forms.Label label2;
    }
}