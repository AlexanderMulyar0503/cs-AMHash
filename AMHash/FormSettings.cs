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
        private string cancelExtMD5;
        private string cancelExtSHA256;
        private int cancelPositionX;
        private int cancelPositionY;
        private int cancelSizeWidth;
        private int cancelSizeHeight;

        public FormSettings()
        {
            InitializeComponent();
        }

        private void FormSettings_Load(object sender, EventArgs e)
        {
            cancelExtMD5 = extMD5.Text;
            cancelExtSHA256 = extSHA256.Text;
            cancelPositionX = Convert.ToInt32(positionX.Value);
            cancelPositionY = Convert.ToInt32(positionY.Value);
            cancelSizeWidth = Convert.ToInt32(sizeWidth.Value);
            cancelSizeHeight = Convert.ToInt32(sizeHeight.Value);
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
            Properties.Settings.Default.extMD5 = cancelExtMD5;
            Properties.Settings.Default.extSHA256 = cancelExtSHA256;
            Properties.Settings.Default.positionX = cancelPositionX;
            Properties.Settings.Default.positionY = cancelPositionY;
            Properties.Settings.Default.sizeWidth = cancelSizeWidth;
            Properties.Settings.Default.sizeHeight = cancelSizeHeight;
            Properties.Settings.Default.Save();
            this.Close();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.extMD5 = extMD5.Text;
            Properties.Settings.Default.extSHA256 = extSHA256.Text;
            Properties.Settings.Default.positionX = Convert.ToInt32(positionX.Value);
            Properties.Settings.Default.positionY = Convert.ToInt32(positionY.Value);
            Properties.Settings.Default.sizeWidth = Convert.ToInt32(sizeWidth.Value);
            Properties.Settings.Default.sizeHeight = Convert.ToInt32(sizeHeight.Value);
            Properties.Settings.Default.Save();
            this.Close();
        }
    }
}
