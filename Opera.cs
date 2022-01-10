using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nexus_LiteOS_ToolKit_GUI
{
    public partial class Opera : Form
    {
        WebClient dl;
        public Opera()
        {
            InitializeComponent();
        }

        private void Opera_Load(object sender, EventArgs e)
        {
            dl = new WebClient();
            dl.DownloadFileCompleted += dl_DownloadFileCompleted;
            dl.DownloadProgressChanged += dl_DownloadProgressChanged;
            dl.DownloadFileAsync(new Uri("https://download3.operacdn.com/pub/opera/desktop/73.0.3856.284/win/Opera_73.0.3856.284_Setup_x64.exe"), "C:\\Nexus_LiteOS_ToolKit\\Downloads\\Opera_73.0.3856.284_Setup_x64.exe");
        }

        private void dl_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            progressBar1.Maximum = (int)e.TotalBytesToReceive / 100;
            progressBar1.Value = (int)e.BytesReceived / 100;

        }

        private void dl_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            System.Diagnostics.Process.Start("explorer.exe", @"c:\nexus_liteOS_toolkit\downloads");
            string termination = (e.Cancelled == true) ? " Cancelled" : " Finished";
            MessageBox.Show(e.UserState + termination);
        }

        private void button17_Click(object sender, EventArgs e)
        {
            dl.CancelAsync();
            this.Close();
        }
    }
}