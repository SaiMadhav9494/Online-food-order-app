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
    public partial class reportorders : Form
    {
        public reportorders()
        {
            InitializeComponent();
        }

        private void reportorders_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'olfdordrDataSet.Orders' table. You can move, or remove it, as needed.
            //this.ordersTableAdapter.Fill(this.olfdordrDataSet.Orders);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                this.ordersTableAdapter.Fill(this.olfdordrDataSet.Orders);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            DataTable dt = (DataTable)this.olfdordrDataSet.Orders;
            dt.DefaultView.RowFilter = string.Format("order_id = '{0}'", oid.Text);
            ordergrid.DataSource = dt;
        }
    }
}
