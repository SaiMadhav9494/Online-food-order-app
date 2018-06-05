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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btncustdtls_click(object sender, EventArgs e)
        {
            DTcusDetls dt = new DTcusDetls();
            dt.Show();
        }

        private void btnmenitems(object sender, EventArgs e)
        {
            MenuItems mn = new MenuItems();
            mn.Show();
        }

        private void btnordrs_click(object sender, EventArgs e)
        {
            deorders deo = new deorders();
            deo.Show();
        }

        private void bthstfdtls_click(object sender, EventArgs e)
        {
            DeStffdetls ds = new DeStffdetls();
            ds.Show();
        }

        private void derwds_click(object sender, EventArgs e)
        {
            DeRewards dr = new DeRewards();
            dr.Show();
        }

        private void btnpay_click(object sender, EventArgs e)
        {
            depay dp = new depay();
            dp.Show();
        }

        private void btnaddr_click(object sender, EventArgs e)
        {
            deaddrs da = new deaddrs();
            da.Show();
        }

        private void btnstfhr_click(object sender, EventArgs e)
        {
            desthrs ds = new desthrs();
            ds.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            reportcust rc = new reportcust();
            rc.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            reportreward rr = new reportreward();
            rr.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            reportorders rr = new reportorders();
            rr.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            reportpay rr = new reportpay();
            rr.Show();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            reportaddr rr = new reportaddr();
            rr.Show();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            reportaddrtypes rr = new reportaddrtypes();
            rr.Show();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            reportitemcat rr = new reportitemcat();
            rr.Show();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            reportitems rr = new reportitems();
            rr.Show();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            reportdept rr = new reportdept();
            rr.Show();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            reportstaff rs = new reportstaff();
            rs.Show();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            reportstafftim rs = new reportstafftim();
            rs.Show();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            reportcustords ro = new reportcustords();
            ro.Show();
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
