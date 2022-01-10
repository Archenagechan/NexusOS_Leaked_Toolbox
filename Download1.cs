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
    public partial class Download1 : Form
    {
        public Download1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Downloads frm = new Downloads();
            frm.Show();
            this.Hide();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            MainScreen frm = new MainScreen();
            frm.Show();
            this.Hide();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            Download2 frm = new Download2();
            frm.Show();
            this.Hide();
        }

        private void button26_Click(object sender, EventArgs e)
        {
            Download2 frm = new Download2();
            frm.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            GIMP frm = new GIMP();
            frm.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            GOM frm = new GOM();
            frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GC frm = new GC();
            frm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            HTTD frm = new HTTD();
            frm.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            IDM frm = new IDM();
            frm.Show();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            KLS frm = new KLS();
            frm.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            KLF frm = new KLF();
            frm.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            KLM frm = new KLM();
            frm.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            LO frm = new LO();
            frm.Show();
        }

        private void button24_Click(object sender, EventArgs e)
        {
            MPC frm = new MPC();
            frm.Show();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            MS07 frm = new MS07();
            frm.Show();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            MS10 frm = new MS10();
            frm.Show();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            MS13 frm = new MS13();
            frm.Show();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            MS16 frm = new MS16();
            frm.Show();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            MS19 frm = new MS19();
            frm.Show();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            MS365 frm = new MS365();
            frm.Show();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            SQL frm = new SQL();
            frm.Show();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            MF frm = new MF();
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

        private void button25_Click(object sender, EventArgs e)
        {
            Download3 frm = new Download3();
            frm.Show();
            this.Hide();
        }
    }
}
