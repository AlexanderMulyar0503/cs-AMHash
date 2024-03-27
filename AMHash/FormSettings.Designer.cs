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
            this.groupExts = new System.Windows.Forms.GroupBox();
            this.extSHA256 = new System.Windows.Forms.TextBox();
            this.labelExtSHA256 = new System.Windows.Forms.Label();
            this.extMD5 = new System.Windows.Forms.TextBox();
            this.labelExtMD5 = new System.Windows.Forms.Label();
            this.groupPosition = new System.Windows.Forms.GroupBox();
            this.positionY = new System.Windows.Forms.NumericUpDown();
            this.positionX = new System.Windows.Forms.NumericUpDown();
            this.labelPositionY = new System.Windows.Forms.Label();
            this.labelPositionX = new System.Windows.Forms.Label();
            this.groupSize = new System.Windows.Forms.GroupBox();
            this.sizeHeight = new System.Windows.Forms.NumericUpDown();
            this.sizeWidth = new System.Windows.Forms.NumericUpDown();
            this.labelSizeHeight = new System.Windows.Forms.Label();
            this.labelSizeWidth = new System.Windows.Forms.Label();
            this.buttonDefault = new System.Windows.Forms.Button();
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.groupExts.SuspendLayout();
            this.groupPosition.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.positionY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.positionX)).BeginInit();
            this.groupSize.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sizeHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sizeWidth)).BeginInit();
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
            // groupPosition
            // 
            this.groupPosition.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupPosition.Controls.Add(this.positionY);
            this.groupPosition.Controls.Add(this.positionX);
            this.groupPosition.Controls.Add(this.labelPositionY);
            this.groupPosition.Controls.Add(this.labelPositionX);
            this.groupPosition.Location = new System.Drawing.Point(12, 132);
            this.groupPosition.Name = "groupPosition";
            this.groupPosition.Size = new System.Drawing.Size(260, 106);
            this.groupPosition.TabIndex = 1;
            this.groupPosition.TabStop = false;
            this.groupPosition.Text = "Положение формы";
            // 
            // positionY
            // 
            this.positionY.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.positionY.Location = new System.Drawing.Point(98, 71);
            this.positionY.Maximum = new decimal(new int[] {
            8000,
            0,
            0,
            0});
            this.positionY.Name = "positionY";
            this.positionY.Size = new System.Drawing.Size(156, 20);
            this.positionY.TabIndex = 3;
            this.positionY.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            // 
            // positionX
            // 
            this.positionX.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.positionX.Location = new System.Drawing.Point(98, 31);
            this.positionX.Maximum = new decimal(new int[] {
            8000,
            0,
            0,
            0});
            this.positionX.Name = "positionX";
            this.positionX.Size = new System.Drawing.Size(156, 20);
            this.positionX.TabIndex = 2;
            this.positionX.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            // 
            // labelPositionY
            // 
            this.labelPositionY.AutoSize = true;
            this.labelPositionY.Location = new System.Drawing.Point(16, 73);
            this.labelPositionY.Name = "labelPositionY";
            this.labelPositionY.Size = new System.Drawing.Size(14, 13);
            this.labelPositionY.TabIndex = 1;
            this.labelPositionY.Text = "Y";
            // 
            // labelPositionX
            // 
            this.labelPositionX.AutoSize = true;
            this.labelPositionX.Location = new System.Drawing.Point(16, 33);
            this.labelPositionX.Name = "labelPositionX";
            this.labelPositionX.Size = new System.Drawing.Size(14, 13);
            this.labelPositionX.TabIndex = 0;
            this.labelPositionX.Text = "X";
            // 
            // groupSize
            // 
            this.groupSize.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupSize.Controls.Add(this.sizeHeight);
            this.groupSize.Controls.Add(this.sizeWidth);
            this.groupSize.Controls.Add(this.labelSizeHeight);
            this.groupSize.Controls.Add(this.labelSizeWidth);
            this.groupSize.Location = new System.Drawing.Point(12, 255);
            this.groupSize.Name = "groupSize";
            this.groupSize.Size = new System.Drawing.Size(260, 95);
            this.groupSize.TabIndex = 2;
            this.groupSize.TabStop = false;
            this.groupSize.Text = "Размер формы";
            // 
            // sizeHeight
            // 
            this.sizeHeight.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sizeHeight.Location = new System.Drawing.Point(98, 64);
            this.sizeHeight.Maximum = new decimal(new int[] {
            8000,
            0,
            0,
            0});
            this.sizeHeight.Name = "sizeHeight";
            this.sizeHeight.Size = new System.Drawing.Size(156, 20);
            this.sizeHeight.TabIndex = 3;
            this.sizeHeight.Value = new decimal(new int[] {
            310,
            0,
            0,
            0});
            // 
            // sizeWidth
            // 
            this.sizeWidth.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sizeWidth.Location = new System.Drawing.Point(98, 30);
            this.sizeWidth.Maximum = new decimal(new int[] {
            8000,
            0,
            0,
            0});
            this.sizeWidth.Name = "sizeWidth";
            this.sizeWidth.Size = new System.Drawing.Size(156, 20);
            this.sizeWidth.TabIndex = 2;
            this.sizeWidth.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            // 
            // labelSizeHeight
            // 
            this.labelSizeHeight.AutoSize = true;
            this.labelSizeHeight.Location = new System.Drawing.Point(16, 66);
            this.labelSizeHeight.Name = "labelSizeHeight";
            this.labelSizeHeight.Size = new System.Drawing.Size(45, 13);
            this.labelSizeHeight.TabIndex = 1;
            this.labelSizeHeight.Text = "Высота";
            // 
            // labelSizeWidth
            // 
            this.labelSizeWidth.AutoSize = true;
            this.labelSizeWidth.Location = new System.Drawing.Point(16, 32);
            this.labelSizeWidth.Name = "labelSizeWidth";
            this.labelSizeWidth.Size = new System.Drawing.Size(46, 13);
            this.labelSizeWidth.TabIndex = 0;
            this.labelSizeWidth.Text = "Ширина";
            // 
            // buttonDefault
            // 
            this.buttonDefault.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonDefault.Location = new System.Drawing.Point(12, 366);
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
            this.buttonOK.Location = new System.Drawing.Point(116, 366);
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
            this.buttonCancel.Location = new System.Drawing.Point(197, 366);
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
            this.ClientSize = new System.Drawing.Size(284, 401);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.buttonDefault);
            this.Controls.Add(this.groupSize);
            this.Controls.Add(this.groupPosition);
            this.Controls.Add(this.groupExts);
            this.Name = "FormSettings";
            this.Text = "Параметры";
            this.Load += new System.EventHandler(this.FormSettings_Load);
            this.groupExts.ResumeLayout(false);
            this.groupExts.PerformLayout();
            this.groupPosition.ResumeLayout(false);
            this.groupPosition.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.positionY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.positionX)).EndInit();
            this.groupSize.ResumeLayout(false);
            this.groupSize.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sizeHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sizeWidth)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupExts;
        private System.Windows.Forms.Label labelExtSHA256;
        private System.Windows.Forms.Label labelExtMD5;
        private System.Windows.Forms.GroupBox groupPosition;
        private System.Windows.Forms.Label labelPositionY;
        private System.Windows.Forms.Label labelPositionX;
        private System.Windows.Forms.GroupBox groupSize;
        private System.Windows.Forms.Label labelSizeHeight;
        private System.Windows.Forms.Label labelSizeWidth;
        private System.Windows.Forms.Button buttonDefault;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonCancel;
        public System.Windows.Forms.TextBox extSHA256;
        public System.Windows.Forms.TextBox extMD5;
        public System.Windows.Forms.NumericUpDown positionY;
        public System.Windows.Forms.NumericUpDown positionX;
        public System.Windows.Forms.NumericUpDown sizeHeight;
        public System.Windows.Forms.NumericUpDown sizeWidth;
    }
}