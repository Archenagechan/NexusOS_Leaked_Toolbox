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
    public partial class WPS : Form
    {
        WebClient dl;
        public WPS()
        {
            InitializeComponent();
        }

        private void WPS_Load(object sender, EventArgs e)
        {
            dl = new WebClient();
            dl.DownloadFileCompleted += dl_DownloadFileCompleted;
            dl.DownloadProgressChanged += dl_DownloadProgressChanged;
            dl.DownloadFileAsync(new Uri("https://51-89-18-55.xyz/Getintopc.com/WPS_Office%EF%BB%BF_2019_v11.2.0.8991_Multilingual.rar?md5=pYd_ic1h6u_ngupD8P3gYw&expires=1612267056"), "C:\\Nexus_LiteOS_ToolKit\\Downloads\\WPS_Office_2019_v11.2.0.8991_Multilingual.zip");
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
