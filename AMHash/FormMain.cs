using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AMHash
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            this.Location = new Point(Properties.Settings.Default.positionX, Properties.Settings.Default.positionY);
            this.Size = new Size(Properties.Settings.Default.sizeWidth, Properties.Settings.Default.sizeHeight);
            calcAlgorithm.SelectedIndex = 0;
        }

        private void formMainMenuSettings_Click(object sender, EventArgs e)
        {
            FormSettings formSettings = new FormSettings();
            formSettings.extMD5.Text = Properties.Settings.Default.extMD5;
            formSettings.extSHA256.Text = Properties.Settings.Default.extSHA256;
            formSettings.positionX.Value = Properties.Settings.Default.positionX;
            formSettings.positionY.Value = Properties.Settings.Default.positionY;
            formSettings.sizeWidth.Value = Properties.Settings.Default.sizeWidth;
            formSettings.sizeHeight.Value = Properties.Settings.Default.sizeHeight;
            formSettings.ShowDialog();
            this.Location = new Point(Properties.Settings.Default.positionX, Properties.Settings.Default.positionY);
            this.Size = new Size(Properties.Settings.Default.sizeWidth, Properties.Settings.Default.sizeHeight);
        }

        private void formMainMenuExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void calcAlgorithm_SelectedIndexChanged(object sender, EventArgs e)
        {
            hashResult.BackColor = SystemColors.Window;
            hashResult.Text = "";
        }

        private void buttonOpenFile_Click(object sender, EventArgs e)
        {
            calcOpenFileDialog.ShowDialog();
            openFilePath.Text = calcOpenFileDialog.FileName;
        }

        private void buttonHashCalc_Click(object sender, EventArgs e)
        {
            if (File.Exists(openFilePath.Text))
            {
                // MD5
                if (calcAlgorithm.SelectedIndex == 0)
                {
                    MD5 md5sum = MD5.Create();
                    FileStream fileStream = File.OpenRead(openFilePath.Text);

                    byte[] hashMD5Rslt = md5sum.ComputeHash(fileStream);
                    hashResult.Text = BitConverter.ToString(hashMD5Rslt).Replace("-", "").ToLowerInvariant();
                }

                // SHA256
                if (calcAlgorithm.SelectedIndex == 1)
                {
                    SHA256 sha256 = SHA256.Create();
                    FileStream fileStream = File.OpenRead(openFilePath.Text);

                    byte[] hashSHA256Rslt = sha256.ComputeHash(fileStream);
                    hashResult.Text = BitConverter.ToString(hashSHA256Rslt).Replace("-", "").ToLowerInvariant();
                }

                CheckHash();
            }
        }

        private void CheckHash()
        {
            hashResult.BackColor = SystemColors.Window;

            if (hashExpectation.Text.Length != 0)
            {
                if (hashExpectation.Text == hashResult.Text)
                {
                    hashResult.BackColor = Color.Green;
                }
                else
                {
                    hashResult.BackColor = Color.Red;
                }
            }
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.positionX = this.Location.X;
            Properties.Settings.Default.positionY = this.Location.Y;
            Properties.Settings.Default.sizeWidth = this.Size.Width;
            Properties.Settings.Default.sizeHeight = this.Size.Height;
            Properties.Settings.Default.Save();
        }
    }
}
