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
    public partial class _4D : Form
    {
        WebClient dl;
        public _4D()
        {
            InitializeComponent();
        }

        private void _4D_Load(object sender, EventArgs e)
        {
            dl = new WebClient();
            dl.DownloadFileCompleted += dl_DownloadFileCompleted;
            dl.DownloadProgressChanged += dl_DownloadProgressChanged;
            dl.DownloadFileAsync(new Uri("http://95.216.22.233/igetintopc.com/download.php?url_str=https%3A%2F%2F95.216.22.233%2FiGetintopc.com%2Fdownload.php%3Ffilename%3D_igetintopc.com_Maxon_CINEMA_4D_Studio.zip%26expires%3D1610262309%26signature%3D6e753a8c8174acce52044dc500d49a1c&filename=_igetintopc.com_Maxon_CINEMA_4D_Studio.zip"), "C:\\Nexus_LiteOS_ToolKit\\Downloads\\igetintopc.com_Maxon_CINEMA_4D_Studio.zip");
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
