namespace OnlineFoodOrder
{
    partial class MainForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.dtcustdtls_click = new System.Windows.Forms.Button();
            this.btnmenitems_click = new System.Windows.Forms.Button();
            this.btnordrs = new System.Windows.Forms.Button();
            this.bthstfdtls = new System.Windows.Forms.Button();
            this.derwds = new System.Windows.Forms.Button();
            this.btnpay = new System.Windows.Forms.Button();
            this.btnaddr = new System.Windows.Forms.Button();
            this.btnstfhr = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.button20 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(119, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Data Entry Forms";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(575, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Report Forms";
            // 
            // dtcustdtls_click
            // 
            this.dtcustdtls_click.BackColor = System.Drawing.Color.Crimson;
            this.dtcustdtls_click.Location = new System.Drawing.Point(71, 78);
            this.dtcustdtls_click.Name = "dtcustdtls_click";
            this.dtcustdtls_click.Size = new System.Drawing.Size(92, 44);
            this.dtcustdtls_click.TabIndex = 3;
            this.dtcustdtls_click.Text = "Cuntomer details";
            this.dtcustdtls_click.UseVisualStyleBackColor = false;
            this.dtcustdtls_click.Click += new System.EventHandler(this.btncustdtls_click);
            // 
            // btnmenitems_click
            // 
            this.btnmenitems_click.BackColor = System.Drawing.Color.Crimson;
            this.btnmenitems_click.Location = new System.Drawing.Point(185, 77);
            this.btnmenitems_click.Name = "btnmenitems_click";
            this.btnmenitems_click.Size = new System.Drawing.Size(75, 44);
            this.btnmenitems_click.TabIndex = 4;
            this.btnmenitems_click.Text = "Menu items";
            this.btnmenitems_click.UseVisualStyleBackColor = false;
            this.btnmenitems_click.Click += new System.EventHandler(this.btnmenitems);
            // 
            // btnordrs
            // 
            this.btnordrs.BackColor = System.Drawing.Color.Crimson;
            this.btnordrs.Location = new System.Drawing.Point(295, 77);
            this.btnordrs.Name = "btnordrs";
            this.btnordrs.Size = new System.Drawing.Size(75, 43);
            this.btnordrs.TabIndex = 5;
            this.btnordrs.Text = "Orders";
            this.btnordrs.UseVisualStyleBackColor = false;
            this.btnordrs.Click += new System.EventHandler(this.btnordrs_click);
            // 
            // bthstfdtls
            // 
            this.bthstfdtls.BackColor = System.Drawing.Color.Crimson;
            this.bthstfdtls.Location = new System.Drawing.Point(71, 137);
            this.bthstfdtls.Name = "bthstfdtls";
            this.bthstfdtls.Size = new System.Drawing.Size(92, 41);
            this.bthstfdtls.TabIndex = 6;
            this.bthstfdtls.Text = "Staff Details";
            this.bthstfdtls.UseVisualStyleBackColor = false;
            this.bthstfdtls.Click += new System.EventHandler(this.bthstfdtls_click);
            // 
            // derwds
            // 
            this.derwds.BackColor = System.Drawing.Color.Crimson;
            this.derwds.Location = new System.Drawing.Point(71, 197);
            this.derwds.Name = "derwds";
            this.derwds.Size = new System.Drawing.Size(92, 40);
            this.derwds.TabIndex = 7;
            this.derwds.Text = "department";
            this.derwds.UseVisualStyleBackColor = false;
            this.derwds.Click += new System.EventHandler(this.derwds_click);
            // 
            // btnpay
            // 
            this.btnpay.BackColor = System.Drawing.Color.Crimson;
            this.btnpay.Location = new System.Drawing.Point(295, 137);
            this.btnpay.Name = "btnpay";
            this.btnpay.Size = new System.Drawing.Size(75, 40);
            this.btnpay.TabIndex = 8;
            this.btnpay.Text = "Item category";
            this.btnpay.UseVisualStyleBackColor = false;
            this.btnpay.Click += new System.EventHandler(this.btnpay_click);
            // 
            // btnaddr
            // 
            this.btnaddr.BackColor = System.Drawing.Color.Crimson;
            this.btnaddr.Location = new System.Drawing.Point(185, 138);
            this.btnaddr.Name = "btnaddr";
            this.btnaddr.Size = new System.Drawing.Size(75, 40);
            this.btnaddr.TabIndex = 9;
            this.btnaddr.Text = "Addressess";
            this.btnaddr.UseVisualStyleBackColor = false;
            this.btnaddr.Click += new System.EventHandler(this.btnaddr_click);
            // 
            // btnstfhr
            // 
            this.btnstfhr.BackColor = System.Drawing.Color.Crimson;
            this.btnstfhr.Location = new System.Drawing.Point(185, 197);
            this.btnstfhr.Name = "btnstfhr";
            this.btnstfhr.Size = new System.Drawing.Size(75, 40);
            this.btnstfhr.TabIndex = 10;
            this.btnstfhr.Text = "address types";
            this.btnstfhr.UseVisualStyleBackColor = false;
            this.btnstfhr.Click += new System.EventHandler(this.btnstfhr_click);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.Yellow;
            this.button9.Location = new System.Drawing.Point(502, 78);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(75, 23);
            this.button9.TabIndex = 12;
            this.button9.Text = "Customers";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.Yellow;
            this.button10.Location = new System.Drawing.Point(612, 78);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(75, 23);
            this.button10.TabIndex = 13;
            this.button10.Text = "Rewards";
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.Yellow;
            this.button11.Location = new System.Drawing.Point(716, 77);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(86, 23);
            this.button11.TabIndex = 14;
            this.button11.Text = "Orders";
            this.button11.UseVisualStyleBackColor = false;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.Color.Yellow;
            this.button12.Location = new System.Drawing.Point(502, 127);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(75, 23);
            this.button12.TabIndex = 15;
            this.button12.Text = "payments";
            this.button12.UseVisualStyleBackColor = false;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // button13
            // 
            this.button13.BackColor = System.Drawing.Color.Yellow;
            this.button13.Location = new System.Drawing.Point(612, 126);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(75, 23);
            this.button13.TabIndex = 16;
            this.button13.Text = "Addressess";
            this.button13.UseVisualStyleBackColor = false;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // button14
            // 
            this.button14.BackColor = System.Drawing.Color.Yellow;
            this.button14.Location = new System.Drawing.Point(716, 127);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(86, 24);
            this.button14.TabIndex = 17;
            this.button14.Text = "Address Types";
            this.button14.UseVisualStyleBackColor = false;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // button15
            // 
            this.button15.BackColor = System.Drawing.Color.Yellow;
            this.button15.Location = new System.Drawing.Point(502, 172);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(75, 23);
            this.button15.TabIndex = 18;
            this.button15.Text = "Item Cat.";
            this.button15.UseVisualStyleBackColor = false;
            this.button15.Click += new System.EventHandler(this.button15_Click);
            // 
            // button16
            // 
            this.button16.BackColor = System.Drawing.Color.Yellow;
            this.button16.Location = new System.Drawing.Point(612, 172);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(75, 23);
            this.button16.TabIndex = 19;
            this.button16.Text = "Items";
            this.button16.UseVisualStyleBackColor = false;
            this.button16.Click += new System.EventHandler(this.button16_Click);
            // 
            // button17
            // 
            this.button17.BackColor = System.Drawing.Color.Yellow;
            this.button17.Location = new System.Drawing.Point(716, 172);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(86, 23);
            this.button17.TabIndex = 20;
            this.button17.Text = "Departments";
            this.button17.UseVisualStyleBackColor = false;
            this.button17.Click += new System.EventHandler(this.button17_Click);
            // 
            // button18
            // 
            this.button18.BackColor = System.Drawing.Color.Yellow;
            this.button18.Location = new System.Drawing.Point(502, 214);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(75, 23);
            this.button18.TabIndex = 21;
            this.button18.Text = "Staff";
            this.button18.UseVisualStyleBackColor = false;
            this.button18.Click += new System.EventHandler(this.button18_Click);
            // 
            // button19
            // 
            this.button19.BackColor = System.Drawing.Color.Yellow;
            this.button19.Location = new System.Drawing.Point(612, 214);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(75, 23);
            this.button19.TabIndex = 22;
            this.button19.Text = "Staff Time";
            this.button19.UseVisualStyleBackColor = false;
            this.button19.Click += new System.EventHandler(this.button19_Click);
            // 
            // button20
            // 
            this.button20.BackColor = System.Drawing.Color.Yellow;
            this.button20.Location = new System.Drawing.Point(716, 214);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(86, 23);
            this.button20.TabIndex = 23;
            this.button20.Text = "Cust. Orders";
            this.button20.UseVisualStyleBackColor = false;
            this.button20.Click += new System.EventHandler(this.button20_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 311);
            this.Controls.Add(this.button20);
            this.Controls.Add(this.button19);
            this.Controls.Add(this.button18);
            this.Controls.Add(this.button17);
            this.Controls.Add(this.button16);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.btnstfhr);
            this.Controls.Add(this.btnaddr);
            this.Controls.Add(this.btnpay);
            this.Controls.Add(this.derwds);
            this.Controls.Add(this.bthstfdtls);
            this.Controls.Add(this.btnordrs);
            this.Controls.Add(this.btnmenitems_click);
            this.Controls.Add(this.dtcustdtls_click);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.Text = "Online Food Order System";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button dtcustdtls_click;
        private System.Windows.Forms.Button btnmenitems_click;
        private System.Windows.Forms.Button btnordrs;
        private System.Windows.Forms.Button bthstfdtls;
        private System.Windows.Forms.Button derwds;
        private System.Windows.Forms.Button btnpay;
        private System.Windows.Forms.Button btnaddr;
        private System.Windows.Forms.Button btnstfhr;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.Button button20;
    }
}

