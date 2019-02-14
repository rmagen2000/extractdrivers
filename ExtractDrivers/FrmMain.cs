using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.IO;

namespace ExtractDrivers
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void btnSelDir_Click(object sender, EventArgs e)
        {
            DialogResult res = fldBro.ShowDialog();
            if ((res == DialogResult.OK) && (!String.IsNullOrEmpty(fldBro.SelectedPath.ToString())))
                path.Text = fldBro.SelectedPath.ToString();
            if (path.Text != "No directory for saving drivers selected")
                path.ForeColor = Color.Black;
            else
                path.ForeColor = Color.Red;

        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            if (path.Text.ToString() == "No directory for saving drivers selected")
            {
                MessageBox.Show("No path selected!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                path.ForeColor = Color.Red;
            }
            else
            {
                btnRun.Enabled = false;
                this.Width = 620;
                this.Height = 440;
                btnSelDir.Enabled = false;
                output.Text = "Please Wait...";
                Application.DoEvents();
                String tmp_file = Path.GetTempFileName();
                String tmp_path = Path.GetTempPath();
                String cmd_path = tmp_path + "drivers.txt";
                if (System.IO.File.Exists(cmd_path))
                    System.IO.File.Delete(cmd_path);
                //MessageBox.Show(cmd_path);
                path.ForeColor = Color.Black;
                String cmd2run = "PowerShell Export-WindowsDriver -Online -Destination " + "'" + path.Text.ToString() + "' >" + cmd_path;
                //MessageBox.Show(cmd2run);
                String cmdfp = tmp_path + "extractDriver.cmd";
                if (System.IO.File.Exists(cmdfp))
                    System.IO.File.Delete(cmdfp);
                //MessageBox.Show(cmdfp);
                System.IO.File.WriteAllText(cmdfp, cmd2run);
                ProcessStartInfo procInfo = new ProcessStartInfo();
                procInfo.UseShellExecute = true;
                procInfo.FileName = @"extractDriver.cmd";
                procInfo.WorkingDirectory = tmp_path;
                procInfo.Verb = "runas";
                Application.DoEvents();
                procInfo.WindowStyle = ProcessWindowStyle.Hidden;
                Process p = Process.Start(procInfo);
                Application.DoEvents();
                int c = 0;
                while (!(p.HasExited))
                {
                    c++;
                    Thread.Sleep(1000);
                    output.Text = c.ToString() + " sec";
                    Application.DoEvents();
                }
                String returned = System.IO.File.ReadAllText(cmd_path);
                //MessageBox.Show(text);
                String pc_name = System.Environment.MachineName.ToString();
                String os_name1 = System.Environment.OSVersion.VersionString.ToString();
                String text = os_name1 + "\r\nTimestamp:" + DateTime.Now.ToString() + "\r\n" + pc_name + "\r\n" + returned;
                output.Text = text;
                String filename = "DriversInfo.txt";
                String new_path = System.IO.Path.Combine(path.Text, filename);
                //MessageBox.Show(new_path);
                System.IO.File.WriteAllText(new_path, text);
                btnRun.Enabled = true;
                btnSelDir.Enabled = true;
            }

        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            this.Height = 120;
            this.Width = 330;

        }
    }
}
