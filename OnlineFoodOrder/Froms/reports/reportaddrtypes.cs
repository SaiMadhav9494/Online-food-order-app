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
    public partial class reportaddrtypes : Form
    {
        public reportaddrtypes()
        {
            InitializeComponent();
        }

        private void reportaddrtypes_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'olfdordrDataSet.addresstypes' table. You can move, or remove it, as needed.
            //this.addresstypesTableAdapter.Fill(this.olfdordrDataSet.addresstypes);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                this.addresstypesTableAdapter.Fill(this.olfdordrDataSet.addresstypes);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            DataTable dt = (DataTable)this.olfdordrDataSet.addresstypes;
            dt.DefaultView.RowFilter = string.Format("addresstype = '{0}'", textBox1.Text);
            dataGridView1.DataSource = dt;
        }
    }
}
