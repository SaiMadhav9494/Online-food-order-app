using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineFoodOrder
{
    public partial class reportdept : Form
    {
        public reportdept()
        {
            InitializeComponent();
        }

        private void reportdept_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'olfdordrDataSet.departments' table. You can move, or remove it, as needed.
            //this.departmentsTableAdapter.Fill(this.olfdordrDataSet.departments);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                this.departmentsTableAdapter.Fill(this.olfdordrDataSet.departments);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            DataTable dt = (DataTable)this.olfdordrDataSet.departments;
            dt.DefaultView.RowFilter = string.Format("department = '{0}'", textBox1.Text);
            dataGridView1.DataSource = dt;
        }
    }
}
