using System;
using System.Configuration;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Windows.Forms;
using WrapYoutubeDl;
using Microsoft.WindowsAPICodePack.Taskbar;


namespace Youtube_DL_GUI
{
    public partial class Form1 : Form
    {
        private readonly Uri youube_dl_url = new Uri("https://yt-dl.org/downloads/2020.11.29/youtube-dl.exe");
        private string folder;
        private string filename;
        // public static readonly TaskbarManager taskbar;

        public Form1()
        {
            InitializeComponent();
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            { 
                using (WebClient client = new WebClient())
                {
                    client.DownloadProgressChanged += Client_DownloadProgressChanged;
                    client.DownloadFileCompleted += Client_DownloadFileCompleted;
                    client.DownloadFileAsync(youube_dl_url, "youtube-dl.exe");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Download Error!" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Client_DownloadFileCompleted(object sender, System.ComponentModel.AsyncCompletedEventArgs e)
        {
            getlinkBtn.Enabled = true;
            progressBar.Value = 0;
            progressLbl.Text = "0 %";
            TaskbarManager.Instance.SetProgressState(TaskbarProgressBarState.NoProgress, Handle);
            TaskbarManager.Instance.SetProgressValue(0, 100, Handle);
        }

        private void Client_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            progressBar.Value = e.ProgressPercentage;
            progressLbl.Text = e.ProgressPercentage.ToString() + "%";
            TaskbarManager.Instance.SetProgressState(TaskbarProgressBarState.Normal, Handle);
            TaskbarManager.Instance.SetProgressValue(e.ProgressPercentage, 100, Handle);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (!File.Exists("youtube-dl.exe"))
            {
                getlinkBtn.Enabled = false;

            }
            string path = ConfigurationManager.AppSettings["binaryfolder"] = Application.StartupPath;

        }

        private void folderselBtn_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                folder = folderBrowserDialog.SelectedPath;
                txtfolderBox.Text = folder;
            }
        }

        private void getlinkBtn_Click(object sender, EventArgs e)
        {
            if (!File.Exists("youtube-dl.exe"))
            {
                MessageBox.Show("Please download the youtube-dl.exe (Press download btn)", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (string.IsNullOrEmpty(txturlBox.Text))
            {
                MessageBox.Show("Please input an link!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txturlBox.Focus();
            }
            else if (string.IsNullOrEmpty(txtfolderBox.Text))
            {
                MessageBox.Show("Please select a folder!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                folderselBtn.Focus();
            }
            else if (string.IsNullOrEmpty(txtfilenameBox.Text))
            {
                MessageBox.Show("Please input a filename!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtfilenameBox.Focus();
            }
            else
            {
                backgroundWorker.RunWorkerAsync();
            }
        }

        private void Downloader_FinishedDownload(object sender, DownloadEventArgs e)
        {
            MessageBox.Show("Download Finished!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            progressBar.Value = 0;
            progressLbl.Text = "0 %";
            TaskbarManager.Instance.SetProgressState(TaskbarProgressBarState.NoProgress, Handle);
            TaskbarManager.Instance.SetProgressValue(0, 100, Handle);
        }

        private void Downloader_ProgressDownload(object sender, ProgressEventArgs e)
        {
            Invoke(new MethodInvoker(
              delegate
                {
                    progressBar.Value = (int)e.Percentage;
                    progressLbl.Text = $"{e.Percentage.ToString("0.00")} %";
                    TaskbarManager.Instance.SetProgressState(TaskbarProgressBarState.Normal, Handle);
                    TaskbarManager.Instance.SetProgressValue((int)e.Percentage, 100, Handle);
                }
              ));

        }

        private void backgroundWorker_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            AudioDownloader downloader = new AudioDownloader(txturlBox.Text, filename, folder);
            Invoke(new MethodInvoker(delegate
              {
                  txtfilenameBox.Text = downloader.OutputName;

              }
            ));
            downloader.ProgressDownload += Downloader_ProgressDownload;
            downloader.FinishedDownload += Downloader_FinishedDownload;
            downloader.ErrorDownload += Downloader_ErrorDownload;
            downloader.Download();

        }

        private void Downloader_ErrorDownload(object sender, ProgressEventArgs e)
        {
            MessageBox.Show("Download Error!" + e.Error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            TaskbarManager.Instance.SetProgressState(TaskbarProgressBarState.Error, Handle);
            TaskbarManager.Instance.SetProgressValue(0, 100, Handle);
        }

        private void githublinkLbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://github.com/BloddyRose/Youtube-DL-GUI");
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Dispose();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txtfilenameBox.Enabled = false;
                filename = Guid.NewGuid().ToString();
                txtfilenameBox.Text = filename;
            }
            else if (!checkBox1.Checked)
            {
                txtfilenameBox.Enabled = true;
                txtfilenameBox.Clear();
                filename = txtfilenameBox.Text + ".mp3";
            }
        }
    }
}