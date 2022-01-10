using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nexus_LiteOS_ToolKit_GUI
{
    public partial class VS17 : Form
    {
        WebClient dl;
        public VS17()
        {
            InitializeComponent();
        }

        private void VS17_Load(object sender, EventArgs e)
        {
            dl = new WebClient();
            dl.DownloadFileCompleted += dl_DownloadFileCompleted;
            dl.DownloadProgressChanged += dl_DownloadProgressChanged;
            dl.DownloadFileAsync(new Uri("https://51-77-82-250.xyz/Getintopc.com/Microsoft_Visual_Studio_2017_AIO_15.7.6_15.7.27703.2047.rar?md5=6iTO2-eb5lsC8d8hzSDOQA&expires=1612264845"), "C:\\Nexus_LiteOS_ToolKit\\Downloads\\Microsoft_Visual_Studio_2017_AIO_15.7.6_15.7.27703.2047.rar");
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

        private void button1_Click(object sender, EventArgs e)
        {
            Process.Start("https://pastebin.com/KskJ8Eg1");
        }
    }
}