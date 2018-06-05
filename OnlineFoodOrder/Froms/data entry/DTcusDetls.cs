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
    public partial class DTcusDetls : Form
    {
        public DTcusDetls()
        {
            InitializeComponent();
        }

        private void btnsbmt_click(object sender, EventArgs e)
        {
            String sql = "insert into customer values("+cstid.Text+",'"+fname.Text+ "','"+mname.Text+ "','"+lname.Text+ "','"+
                ph.Text+ "','"+street.Text+ "','"+city.Text+ "','"+stt.Text+ "','"+cmnts.Text+"',"+mail.Text+")";
            DataAccess da = new DataAccess();
            int i = da.InsUpDel(sql);
            if(i!=1)
            {
                MessageBox.Show("Insert failed");
            }
            else
            {
                MessageBox.Show("Insert successful");
            }
        }
    }
}
