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
    public partial class POWDVD : Form
    {
        WebClient dl;
        public POWDVD()
        {
            InitializeComponent();
        }

        private void POWDVD_Load(object sender, EventArgs e)
        {

            dl = new WebClient();
            dl.DownloadFileCompleted += dl_DownloadFileCompleted;
            dl.DownloadProgressChanged += dl_DownloadProgressChanged;
            dl.DownloadFileAsync(new Uri("https://54-37-142-44.xyz/Getintopc.com/CyberLink_PowerDVD_Ultra_20.0.1519.62_Multilingual.rar?md5=kk6dPZL_rPqRfQ2-sZ16wQ&expires=1612262274"), "C:\\Nexus_LiteOS_ToolKit\\Downloads\\CyberLink_PowerDVD_Ultra_20.0.1519.62_Multilingual.ra");
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