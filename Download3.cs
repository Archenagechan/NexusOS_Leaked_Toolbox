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
    public partial class Download3 : Form
    {
        public Download3()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            VLC frm = new VLC();
            frm.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Vm frm = new Vm();
            frm.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            RAR frm = new RAR();
            frm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            WISO frm = new WISO();
            frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FilmX frm = new FilmX();
            frm.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            WHD frm = new WHD();
            frm.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            WPS frm = new WPS();
            frm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Download2 frm = new Download2();
            frm.Show();
            this.Hide();
        }

        private void button26_Click(object sender, EventArgs e)
        {
            Downloads frm = new Downloads();
            frm.Show();
            this.Hide();
        }

        private void button25_Click(object sender, EventArgs e)
        {
            Download1 frm = new Download1();
            frm.Show();
            this.Hide();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Process.Start("https://nexusliteos.blogspot.com/p/nexus-liteos-toolkit-feature-request.html");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Process.Start("https://paypal.me/supportme7147");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Process.Start("https://nexusliteos.blogspot.com/p/nexus-liteos-toolkit-report-page.html");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Download2 frm = new Download2();
            frm.Show();
            this.Hide();
        }
    }
}
