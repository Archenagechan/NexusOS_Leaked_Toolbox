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
    public partial class MF : Form
    {
        WebClient dl;
        public MF()
        {
            InitializeComponent();
        }

        private void MF_Load(object sender, EventArgs e)
        {
            dl = new WebClient();
            dl.DownloadFileCompleted += dl_DownloadFileCompleted;
            dl.DownloadProgressChanged += dl_DownloadProgressChanged;
            dl.DownloadFileAsync(new Uri("http://95.216.22.233/igetintopc.com/download.php?url_str=https%3A%2F%2F95.216.22.233%2FiGetintopc.com%2Fdownload.php%3Ffilename%3D_igetintopc.com_Mozilla_Firefox_84_x64.zip%26expires%3D1610272358%26signature%3D87aac4de5604956323599a81917d4e00&filename=_igetintopc.com_Mozilla_Firefox_84_x64.zip"), "C:\\Nexus_LiteOS_ToolKit\\Downloads\\Mozilla_Firefox_84_x64.zip");
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
