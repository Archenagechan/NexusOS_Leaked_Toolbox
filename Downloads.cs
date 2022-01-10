using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nexus_LiteOS_ToolKit_GUI
{
    public partial class Downloads : Form
    {
        public Downloads()
        {
            InitializeComponent();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            Download1 frm = new Download1();
            frm.Show();
            this.Hide();
        }

        private void button24_Click(object sender, EventArgs e)
        {
            Download1 frm = new Download1();
            frm.Show();
            this.Hide();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            MainScreen frm = new MainScreen();
            frm.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        { 
            DC frm = new DC();
            frm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            _7z frm = new _7z();
            frm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AE frm = new AE();
            frm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AUD frm = new AUD();
            frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DW frm = new DW();
            frm.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            ILL frm = new ILL();
            frm.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            IND frm = new IND();
            frm.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            PSD frm = new PSD();
            frm.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            PRE frm = new PRE();
            frm.Show();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            BCAM frm = new BCAM();
            frm.Show();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            VPN frm = new VPN();
            frm.Show();
        }

        private void button18_Click(object sender, EventArgs e)
        {
        }

        private void button20_Click(object sender, EventArgs e)
        {
            CAM frm = new CAM();
            frm.Show();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            _4D frm = new _4D();
            frm.Show();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            CAD frm = new CAD();
            frm.Show();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            CDGS frm = new CDGS();
            frm.Show();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            PP frm = new PP();
            frm.Show();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Discord frm = new Discord();
            frm.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Process.Start("https://nexusliteos.blogspot.com/p/nexus-liteos-toolkit-report-page.html");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Process.Start("https://paypal.me/supportme7147");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Process.Start("https://nexusliteos.blogspot.com/p/nexus-liteos-toolkit-feature-request.html");
        }

        private void button26_Click(object sender, EventArgs e)
        {
            Download2 frm = new Download2();
            frm.Show();
            this.Hide();
        }

        private void button25_Click(object sender, EventArgs e)
        {
            Download3 frm = new Download3();
            frm.Show();
            this.Hide();
        }
    }
}
