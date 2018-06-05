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
    public partial class DeRewards : Form
    {
        public DeRewards()
        {
            InitializeComponent();
        }

        private void btnsubmit_click(object sender, EventArgs e)
        {
            String sql = "insert into departments values("+did.Text+",'"+dna.Text+"')";
            DataAccess da = new DataAccess();
            int res = da.InsUpDel(sql);
            if (res != 1)
                MessageBox.Show("Insert failed");
            else
                MessageBox.Show("Insert success");
        }
    }
}
