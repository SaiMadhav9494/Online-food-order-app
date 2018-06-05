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
    public partial class reportaddr : Form
    {
        public reportaddr()
        {
            InitializeComponent();
        }

        private void reportaddr_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'olfdordrDataSet.address_details' table. You can move, or remove it, as needed.
           // this.address_detailsTableAdapter.Fill(this.olfdordrDataSet.address_details);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                this.address_detailsTableAdapter.Fill(this.olfdordrDataSet.address_details);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            DataTable dt = (DataTable)this.olfdordrDataSet.address_details;
            dt.DefaultView.RowFilter = string.Format("customer_id = '{0}'", cid.Text);
            dataGridView1.DataSource = dt;
        }
    }
}
