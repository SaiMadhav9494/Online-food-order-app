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
    public partial class reportcust : Form
    {
        public reportcust()
        {
            InitializeComponent();
        }

        private void customerBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.customerBindingSource.EndEdit();

        }

        private void reportcust_Load(object sender, EventArgs e)
        {
            //TODO: This line of code loads data into the 'olfdordrDataSet.Customer' table.You can move, or remove it, as needed.
            //this.customerTableAdapter.Fill(this.olfdordrDataSet.Customer);
            //TODO: This line of code loads data into the 'olfdordrDataSet.Customer' table.You can move, or remove it, as needed.
            //this.customerTableAdapter.Fill(this.olfdordrDataSet.Customer);
            //TODO: This line of code loads data into the 'olfdordrDataSet.Customer' table.You can move, or remove it, as needed.
            //this.customerTableAdapter.Fill(this.olfdordrDataSet.Customer);

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    this.customerTableAdapter.FillBy(this.olfdordrDataSet.Customer);
            //}
            //catch (System.Exception ex)
            //{
            //    System.Windows.Forms.MessageBox.Show(ex.Message);
            //}

        }

        private void searchbtn_Click(object sender, EventArgs e)
        {
            try
            {
                this.customerTableAdapter.Fill(this.olfdordrDataSet.Customer);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            DataTable dt = (DataTable)this.olfdordrDataSet.Customer;
            dt.DefaultView.RowFilter = string.Format("customer_id = '{0}'",cid.Text);
            cgrid.DataSource = dt;
        }
    }
}
