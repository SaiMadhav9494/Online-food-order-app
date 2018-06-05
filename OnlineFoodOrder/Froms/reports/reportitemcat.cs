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
    public partial class reportitemcat : Form
    {
        public reportitemcat()
        {
            InitializeComponent();
        }

        private void reportitemcat_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'olfdordrDataSet.category' table. You can move, or remove it, as needed.
            //this.categoryTableAdapter.Fill(this.olfdordrDataSet.category);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                this.categoryTableAdapter.Fill(this.olfdordrDataSet.category);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            DataTable dt = (DataTable)this.olfdordrDataSet.category;
            dt.DefaultView.RowFilter = string.Format("category_id = '{0}'", textBox1.Text);
            dataGridView1.DataSource = dt;
        }
    }
}
