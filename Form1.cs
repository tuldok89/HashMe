/*
 * ----------------------------------------------------------------------------
 * "THE BEER-WARE LICENSE" (Revision 42):
 * <tuldok89@gmail.com> wrote this file. As long as you retain this notice you
 * can do whatever you want with this stuff. If we meet some day, and you think
 * this stuff is worth it, you can buy me a beer in return -- Denver Ivan Gazo
 * ----------------------------------------------------------------------------
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.IO;

namespace HashMe
{
    public partial class Form1 : Form
    {
        HashAlgo selectedHash;
        HashAlgorithm Hash;
        FileStream inFile;
        bool hashingFinished = false;

        public enum HashAlgo
        {
            CRC32,
            MD5,
            SHA1,
            SHA256,
            SHA384,
            SHA512,
            RipeMd,
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BgWorker.ProgressChanged += new ProgressChangedEventHandler(BgWorker_ProgressChanged);
            BgWorker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(BgWorker_RunWorkerCompleted);
            FileNameTextBox.DragEnter += new DragEventHandler(FileNameTextBox_DragEnter);       // Drag & Drop Effects
            FileNameTextBox.DragDrop += new DragEventHandler(FileNameTextBox_DragDrop);         // Catch Drop
            this.DragEnter += new DragEventHandler(FileNameTextBox_DragEnter);
            this.DragDrop += new DragEventHandler(FileNameTextBox_DragDrop);
            selectedHash = HashAlgo.CRC32;
        }

        private void BrowseButton_Click(object sender, EventArgs e)
        {
            DialogResult myDialogResult;
            myDialogResult = OpenFile.ShowDialog();

            if (myDialogResult == System.Windows.Forms.DialogResult.Cancel)
                return; // exit if cancel is pressed

            FileNameTextBox.Text = OpenFile.FileName;
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            BgWorker.RunWorkerAsync(); // run hash calculation on a separate thread
            CalculateButton.Enabled = false;
        }

        private void CrcRadio_CheckedChanged(object sender, EventArgs e)
        {
            selectedHash = HashAlgo.CRC32;
        }

        private void Md5Radio_CheckedChanged(object sender, EventArgs e)
        {
            selectedHash = HashAlgo.MD5;

        }

        private void Sha1Radio_CheckedChanged(object sender, EventArgs e)
        {
            selectedHash = HashAlgo.SHA1;

        }

        private void Sha256Radio_CheckedChanged(object sender, EventArgs e)
        {
            selectedHash = HashAlgo.SHA256;

        }

        private void Sha384Radio_CheckedChanged(object sender, EventArgs e)
        {
            selectedHash = HashAlgo.SHA384;
        }

        private void Sha512Radio_CheckedChanged(object sender, EventArgs e)
        {
            selectedHash = HashAlgo.SHA512;
        }

        private void RipemdRadio_CheckedChanged(object sender, EventArgs e)
        {
            selectedHash = HashAlgo.RipeMd;
        }

        private void BgWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            ProgressBar.Value = e.ProgressPercentage;
        }

        private void BgWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            switch (selectedHash)
            {
                case HashAlgo.MD5:
                    Hash = new MD5CryptoServiceProvider();
                    break;
                case HashAlgo.SHA1:
                    Hash = new SHA1CryptoServiceProvider();
                    break;
                case HashAlgo.SHA256:
                    Hash = new SHA256CryptoServiceProvider();
                    break;
                case HashAlgo.SHA384:
                    Hash = new SHA384CryptoServiceProvider();
                    break;
                case HashAlgo.SHA512:
                    Hash = new SHA512CryptoServiceProvider();
                    break;
                case HashAlgo.RipeMd:
                    Hash = new RIPEMD160Managed();
                    break;
                //case HashAlgo.Adler32:
                //    Hash = new Adler32();
                //    break;
                case HashAlgo.CRC32:
                    Hash = new CRC32();
                    break;
            }

            try
            {
                inFile = new FileStream(FileNameTextBox.Text, FileMode.Open);

                const int bufSize = 4096;
                byte[] buffer = new byte[bufSize];
                int readBytes = 1;
                long filePos;
                long fileLength = inFile.Length;

                while (readBytes > 0)
                {
                    int progress;

                    readBytes = inFile.Read(buffer, 0, bufSize);
                    filePos = inFile.Position;

                    if (readBytes == 4096)
                    {
                        Hash.TransformBlock(buffer, 0, bufSize, null, 0);
                        progress = (int)(((float)filePos / (float)fileLength) * 100);
                    }
                    else
                    {
                        Hash.TransformFinalBlock(buffer, 0, readBytes);
                        progress = 100;
                    }

                    BgWorker.ReportProgress(progress);
                }

                hashingFinished = true;
                inFile.Close();
            }
            catch (IOException)
            {
                MessageBox.Show("Can't open selected file.", "File Open Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (CryptographicException)
            {
                MessageBox.Show("There was an error while processing the file.", "Hashing Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BgWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (hashingFinished)
                hashTextBox.Text = BitConverter.ToString(Hash.Hash).Replace("-", "").ToLower();
            CalculateButton.Enabled = true;
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new About();
            form.ShowDialog();
        }

        private void FileNameTextBox_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.All;
        }

        private void FileNameTextBox_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] myFiles = (string[])e.Data.GetData(DataFormats.FileDrop);
                FileNameTextBox.Text = myFiles[0];
            }
        }

    }
}
