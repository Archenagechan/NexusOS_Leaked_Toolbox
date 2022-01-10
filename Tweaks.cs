using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;
using System.Diagnostics;

namespace Nexus_LiteOS_ToolKit_GUI
{
    public partial class Tweaks : Form
    {
        public Tweaks()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button17_Click(object sender, EventArgs e)
        {
            MainScreen frm = new MainScreen();
            frm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            startInfo.FileName = "cmd.exe";
            startInfo.Arguments = "/C cmd.exe bcdedit /set useplatformclock true";
            process.StartInfo = startInfo;
            process.Start();
            //Message box displays
            string message = "Enabled HPET Successfully!";
            string title = "Nexus_LiteOS_ToolKit";
            MessageBox.Show(message, title);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            startInfo.FileName = "cmd.exe";
            startInfo.Arguments = "/C cmd.exe bcdedit /deletevalue useplatformclock";
            process.StartInfo = startInfo;
            process.Start();
            //Message box displays
            string message = "Disabled HPET Successfully!";
            string title = "Nexus_LiteOS_ToolKit";
            MessageBox.Show(message, title);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            startInfo.FileName = "cmd.exe";
            startInfo.Arguments = "/C cmd.exe sc config SysMain start=auto & sc start SysMain";
            process.StartInfo = startInfo;
            process.Start();
            //Message box displays
            string message = "Enabled Sysmain Successfully!";
            string title = "Nexus_LiteOS_ToolKit";
            MessageBox.Show(message, title);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            startInfo.FileName = "cmd.exe";
            startInfo.Arguments = "/C cmd.exe sc stop SysMain & sc stop SysMain";
            process.StartInfo = startInfo;
            process.Start();
            //Message box displays
            string message = "Disabled Sysmain Successfully!";
            string title = "Nexus_LiteOS_ToolKit";
            MessageBox.Show(message, title);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            startInfo.FileName = "cmd.exe";
            startInfo.Arguments = "/C cmd.exe powercfg -hibernate on";
            process.StartInfo = startInfo;
            process.Start();
            //Message box displays
            string message = "Enabled Hibernation Successfully!";
            string title = "Nexus_LiteOS_ToolKit";
            MessageBox.Show(message, title);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            startInfo.FileName = "cmd.exe";
            startInfo.Arguments = "/C cmd.exe powercfg -hibernate off";
            process.StartInfo = startInfo;
            process.Start();
            //Message box displays
            string message = "Disabled Hibernation Successfully!";
            string title = "Nexus_LiteOS_ToolKit";
            MessageBox.Show(message, title);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Control\\Session Manager\\Power", "HiberbootEnabled", 1, RegistryValueKind.DWord);
            //Message box displays
            string message = "Enabled Fast Startup Successfully!";
            string title = "Nexus_LiteOS_ToolKit";
            MessageBox.Show(message, title);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Registry.SetValue("HKLM\\SYSTEM\\CurrentControlSet\\services\\Spooler", "Start", 2, RegistryValueKind.DWord);
            //Message box displays
            string message = "Enabled Print Spooler Service Successfully! Please sign out to let the changes take place.";
            string title = "Nexus_LiteOS_ToolKit";
            MessageBox.Show(message, title);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            startInfo.FileName = "cmd.exe";
            startInfo.Arguments = "/C cmd.exe NetSh Advfirewall set allprofiles state on";
            process.StartInfo = startInfo;
            process.Start();
            //Message box displays
            string message = "Enabled Firewall Successfully!";
            string title = "Nexus_LiteOS_ToolKit";
            MessageBox.Show(message, title);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            startInfo.FileName = "cmd.exe";
            startInfo.Arguments = "/C cmd.exe NetSh Advfirewall set allprofiles state off";
            process.StartInfo = startInfo;
            process.Start();
            //Message box displays
            string message = "Disabled Firewall Successfully!";
            string title = "Nexus_LiteOS_ToolKit";
            MessageBox.Show(message, title);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Control\\Session Manager\\Power", "HiberbootEnabled", 0, RegistryValueKind.DWord);
            //Message box displays
            string message = "Disabled Fast Startup Successfully!";
            string title = "Nexus_LiteOS_ToolKit";
            MessageBox.Show(message, title);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Registry.SetValue("HKEY_CURRENT_USER\\Software\\Policies\\Microsoft\\Windows\\Explorer", "DisableNotificationCenter", 0, RegistryValueKind.DWord);
            //Message box displays
            string message = "Enabled Action Centre Successfully! Please sign out to let the changes take place.";
            string title = "Nexus_LiteOS_ToolKit";
            MessageBox.Show(message, title);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Registry.SetValue("HKEY_CURRENT_USER\\Software\\Policies\\Microsoft\\Windows\\Explorer", "DisableNotificationCenter", 1, RegistryValueKind.DWord);
            //Message box displays
            string message = "Disabled Action Centre Successfully! Please sign out to let the changes take place.";
            string title = "Nexus_LiteOS_ToolKit";
            MessageBox.Show(message, title);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Registry.SetValue("HKEY_CURRENT_USER\\Software\\Policies\\Microsoft\\Windows\\Explorer", "DisableNotificationCenter", 4, RegistryValueKind.DWord);
            //Message box displays
            string message = "Disabled Print Spooler Service Successfully! Please sign out to let the changes take place.";
            string title = "Nexus_LiteOS_ToolKit";
            MessageBox.Show(message, title);
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows\\Personalization", "NoLockScreen", 1, RegistryValueKind.DWord);
            //Message box displays
            string message = "Enabled Lock Screen Successfully!";
            string title = "Nexus_LiteOS_ToolKit";
            MessageBox.Show(message, title);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows\\Personalization", "NoLockScreen", 0, RegistryValueKind.DWord);
            //Message box displays
            string message = "Disabled Lock Screen Successfully!";
            string title = "Nexus_LiteOS_ToolKit";
            MessageBox.Show(message, title);
        }
    }
}
