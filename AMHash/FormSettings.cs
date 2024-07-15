using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AMHash
{
    public partial class FormSettings : Form
    {
        public FormSettings()
        {
            InitializeComponent();
        }

        private void buttonDefault_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.extMD5 = "md5";
            Properties.Settings.Default.extSHA256 = "sha256";
            Properties.Settings.Default.positionX = 25;
            Properties.Settings.Default.positionY = 25;
            Properties.Settings.Default.sizeWidth = 500;
            Properties.Settings.Default.sizeHeight = 310;
            Properties.Settings.Default.Save();
            this.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.extMD5 = extMD5.Text;
            Properties.Settings.Default.extSHA256 = extSHA256.Text;
            Properties.Settings.Default.Save();
            this.Close();
        }
    }
}
