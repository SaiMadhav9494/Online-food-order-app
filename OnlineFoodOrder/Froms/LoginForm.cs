using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineFoodOrder.Froms
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            String uName = textBox1.Text;
            String pwd = textBox2.Text;

            if (!uName.Equals("") && !pwd.Equals(""))
            {
                string sql = "select * from admin where username = '" + uName + "' and password = '" + pwd + "'";
                DataAccess da = new DataAccess();
                object res = da.GetScalar(sql);
                if (!res.ToString().Equals("0"))
                {
                    MainForm m  = new MainForm();
                    m.Show();
                    this.Hide();
                    MessageBox.Show("Login Successful");
                }
                else
                {
                    MessageBox.Show("Invalid Login");
                }
            }
            else
            {
                MessageBox.Show("Invalid Login");
            }
        }
    }
}
