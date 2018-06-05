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
    public partial class reportstafftim : Form
    {
        public reportstafftim()
        {
            InitializeComponent();
        }

        private void reportstafftim_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'olfdordrDataSet.staffhours' table. You can move, or remove it, as needed.
            //this.staffhoursTableAdapter.Fill(this.olfdordrDataSet.staffhours);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                this.staffhoursTableAdapter.Fill(this.olfdordrDataSet.staffhours);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            DataTable dt = (DataTable)this.olfdordrDataSet.staffhours;
            dt.DefaultView.RowFilter = string.Format("staff_id = '{0}'", textBox1.Text);
            dataGridView1.DataSource = dt;
        }
    }
}
