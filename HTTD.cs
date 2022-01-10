using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;

namespace Nexus_LiteOS_ToolKit_GUI
{
    public partial class HTTD : Form
    {
        WebClient dl;
        public HTTD()
        {
            InitializeComponent();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            dl.CancelAsync();
            this.Close();
        }

        private void HTTD_Load(object sender, EventArgs e)
        {
            dl = new WebClient();
            dl.DownloadFileCompleted += dl_DownloadFileCompleted;
            dl.DownloadProgressChanged += dl_DownloadProgressChanged;
            dl.DownloadFileAsync(new Uri("https://cdn.discordapp.com/attachments/795163195488206878/795198581161590784/HTTP_Downloader_64.zip"), "C:\\Nexus_LiteOS_ToolKit\\Downloads\\HTTP_Downloader_64.zip");
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
    }
}
