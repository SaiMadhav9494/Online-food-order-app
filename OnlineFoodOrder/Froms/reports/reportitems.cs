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
    public partial class reportitems : Form
    {
        public reportitems()
        {
            InitializeComponent();
        }

        private void reportitems_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'olfdordrDataSet.item' table. You can move, or remove it, as needed.
            //this.itemTableAdapter.Fill(this.olfdordrDataSet.item);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                this.itemTableAdapter.Fill(this.olfdordrDataSet.item);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            DataTable dt = (DataTable)this.olfdordrDataSet.item;
            dt.DefaultView.RowFilter = string.Format("item_id = '{0}'", textBox1.Text);
            dataGridView1.DataSource = dt;
        }
    }
}
