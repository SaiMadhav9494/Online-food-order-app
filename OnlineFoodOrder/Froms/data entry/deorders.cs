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
    public partial class deorders : Form
    {
        public deorders()
        {
            InitializeComponent();
        }

        private void btnsubmit_click(object sender, EventArgs e)
        {
            String sql = "insert into orders values("+oid.Text+","+cid.Text+","+iid.Text+","+quan.Text + "," +del.Text + "," +pay.Text + "," +timed.Text + "," +timea.Text + ",'" +comm.Text+"')";
            DataAccess da = new DataAccess();
            int res = da.InsUpDel(sql);
            if (res != 1)
                MessageBox.Show("Insert failed");
            else
                MessageBox.Show("Insert success");

        }
    }
}
