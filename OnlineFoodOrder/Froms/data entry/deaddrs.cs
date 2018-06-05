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
    public partial class deaddrs : Form
    {
        public deaddrs()
        {
            InitializeComponent();
        }

        private void btnsubmit_click(object sender, EventArgs e)
        {
            String sql = "insert into address_details values("+cid.Text+","+atyp.Text+",'"+a1.Text+"','"+a2.Text + "','" +city.Text + "','" +stt.Text + "'," +zip.Text+")";
            DataAccess da = new DataAccess();
            int res = da.InsUpDel(sql);
            if (res != 1)
                MessageBox.Show("Insert failed");
            else
                MessageBox.Show("Insert success");
        }
    }
}
