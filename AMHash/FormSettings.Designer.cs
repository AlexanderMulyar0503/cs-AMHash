namespace AMHash
{
    partial class FormSettings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSettings));
            this.groupExts = new System.Windows.Forms.GroupBox();
            this.extSHA256 = new System.Windows.Forms.TextBox();
            this.labelExtSHA256 = new System.Windows.Forms.Label();
            this.extMD5 = new System.Windows.Forms.TextBox();
            this.labelExtMD5 = new System.Windows.Forms.Label();
            this.buttonDefault = new System.Windows.Forms.Button();
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.groupExts.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupExts
            // 
            this.groupExts.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupExts.Controls.Add(this.extSHA256);
            this.groupExts.Controls.Add(this.labelExtSHA256);
            this.groupExts.Controls.Add(this.extMD5);
            this.groupExts.Controls.Add(this.labelExtMD5);
            this.groupExts.Location = new System.Drawing.Point(12, 12);
            this.groupExts.Name = "groupExts";
            this.groupExts.Size = new System.Drawing.Size(260, 105);
            this.groupExts.TabIndex = 0;
            this.groupExts.TabStop = false;
            this.groupExts.Text = "Расширения файлов";
            // 
            // extSHA256
            // 
            this.extSHA256.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.extSHA256.Location = new System.Drawing.Point(98, 69);
            this.extSHA256.Name = "extSHA256";
            this.extSHA256.Size = new System.Drawing.Size(156, 20);
            this.extSHA256.TabIndex = 3;
            this.extSHA256.Text = "sha256";
            // 
            // labelExtSHA256
            // 
            this.labelExtSHA256.AutoSize = true;
            this.labelExtSHA256.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelExtSHA256.Location = new System.Drawing.Point(16, 69);
            this.labelExtSHA256.Name = "labelExtSHA256";
            this.labelExtSHA256.Size = new System.Drawing.Size(76, 16);
            this.labelExtSHA256.TabIndex = 2;
            this.labelExtSHA256.Text = "SHA256    *.";
            // 
            // extMD5
            // 
            this.extMD5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.extMD5.Location = new System.Drawing.Point(98, 32);
            this.extMD5.Name = "extMD5";
            this.extMD5.Size = new System.Drawing.Size(156, 20);
            this.extMD5.TabIndex = 1;
            this.extMD5.Text = "md5";
            // 
            // labelExtMD5
            // 
            this.labelExtMD5.AutoSize = true;
            this.labelExtMD5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelExtMD5.Location = new System.Drawing.Point(16, 32);
            this.labelExtMD5.Name = "labelExtMD5";
            this.labelExtMD5.Size = new System.Drawing.Size(76, 16);
            this.labelExtMD5.TabIndex = 0;
            this.labelExtMD5.Text = "MD5           *.";
            // 
            // buttonDefault
            // 
            this.buttonDefault.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonDefault.Location = new System.Drawing.Point(12, 126);
            this.buttonDefault.Name = "buttonDefault";
            this.buttonDefault.Size = new System.Drawing.Size(98, 23);
            this.buttonDefault.TabIndex = 3;
            this.buttonDefault.Text = "По умолчанию";
            this.buttonDefault.UseVisualStyleBackColor = true;
            this.buttonDefault.Click += new System.EventHandler(this.buttonDefault_Click);
            // 
            // buttonOK
            // 
            this.buttonOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOK.Location = new System.Drawing.Point(116, 126);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 4;
            this.buttonOK.Text = "ОК";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.Location = new System.Drawing.Point(197, 126);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 5;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // FormSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 161);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.buttonDefault);
            this.Controls.Add(this.groupExts);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Параметры";
            this.groupExts.ResumeLayout(false);
            this.groupExts.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupExts;
        private System.Windows.Forms.Label labelExtSHA256;
        private System.Windows.Forms.Label labelExtMD5;
        private System.Windows.Forms.Button buttonDefault;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonCancel;
        public System.Windows.Forms.TextBox extSHA256;
        public System.Windows.Forms.TextBox extMD5;
    }
}