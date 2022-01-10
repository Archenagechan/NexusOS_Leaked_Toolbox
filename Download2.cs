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
    public partial class Download2 : Form
    {
        public Download2()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MT frm = new MT();
            frm.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            NPP frm = new NPP();
            frm.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            OBS frm = new OBS();
            frm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Opera frm = new Opera();
            frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            VB frm = new VB();
            frm.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            POWA frm = new POWA();
            frm.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            POWD frm = new POWD();
            frm.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            POWDVD frm = new POWDVD();
            frm.Show();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            POWISO frm = new POWISO();
            frm.Show();
        }

        private void button24_Click(object sender, EventArgs e)
        {
            SVG frm = new SVG();
            frm.Show();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            STL frm = new STL();
            frm.Show();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            SIB frm = new SIB();
            frm.Show();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            TW frm = new TW();
            frm.Show();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            UISO frm = new UISO();
            frm.Show();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            uTor frm = new uTor();
            frm.Show();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            VS15 frm = new VS15();
            frm.Show();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            VS17 frm = new VS17();
            frm.Show();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            VS19 frm = new VS19();
            frm.Show();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            Download3 frm = new Download3();
            frm.Show();
            this.Hide();
        }

        private void button25_Click(object sender, EventArgs e)
        {
            Download3 frm = new Download3();
            frm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Download1 frm = new Download1();
            frm.Show();
            this.Hide();
        }

        private void button22_Click(object sender, EventArgs e)
        {
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
            Downloads frm = new Downloads();
            frm.Show();
            this.Hide();
        }
    }
}
