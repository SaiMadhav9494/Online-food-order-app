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
    public partial class reportreward : Form
    {
        public reportreward()
        {
            InitializeComponent();
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            try
            {
                this.rewardsTableAdapter.Fill(this.olfdordrDataSet.rewards);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            DataTable dt = (DataTable)this.olfdordrDataSet.rewards;
            dt.DefaultView.RowFilter = string.Format("customer_id = '{0}'", cid.Text);
            rewgrid.DataSource = dt;
        }

        private void reportreward_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'olfdordrDataSet.rewards' table. You can move, or remove it, as needed.
            //this.rewardsTableAdapter.Fill(this.olfdordrDataSet.rewards);

        }
    }
}
