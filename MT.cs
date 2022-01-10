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
    public partial class MT : Form
    {
        WebClient dl;
        public MT()
        {
            InitializeComponent();
        }

        private void MT_Load(object sender, EventArgs e)
        {
            dl = new WebClient();
            dl.DownloadFileCompleted += dl_DownloadFileCompleted;
            dl.DownloadProgressChanged += dl_DownloadProgressChanged;
            dl.DownloadFileAsync(new Uri("http://95.216.22.233/igetintopc.com/download.php?url_str=https%3A%2F%2F95.216.22.233%2FiGetintopc.com%2Fdownload.php%3Ffilename%3D_igetintopc.com_Mozilla_Thunderbird_78_x64.zip%26expires%3D1610272650%26signature%3D95d49ac24c5d3847e28462a571541e0a&filename=_igetintopc.com_Mozilla_Thunderbird_78_x64.zip"), "C:\\Nexus_LiteOS_ToolKit\\Downloads\\Mozilla_Thunderbird_78_x64.zip");
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