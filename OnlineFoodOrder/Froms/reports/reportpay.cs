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
    public partial class reportpay : Form
    {
        public reportpay()
        {
            InitializeComponent();
        }

        private void reportpay_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'olfdordrDataSet.payments' table. You can move, or remove it, as needed.
            //this.paymentsTableAdapter.Fill(this.olfdordrDataSet.payments);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                this.paymentsTableAdapter.Fill(this.olfdordrDataSet.payments);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            DataTable dt = (DataTable)this.olfdordrDataSet.payments;
            dt.DefaultView.RowFilter = string.Format("customer_id = '{0}'", cid.Text);
            dataGridView1.DataSource = dt;
        }
    }
}
