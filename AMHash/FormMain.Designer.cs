namespace AMHash
{
    partial class FormMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.formMainMenu = new System.Windows.Forms.MenuStrip();
            this.formMainMenuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.formMainMenuSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.formMainMenuSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.formMainMenuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.formMainMenuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.formMainMenuAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.labelCalcAlgorithm = new System.Windows.Forms.Label();
            this.calcAlgorithm = new System.Windows.Forms.ComboBox();
            this.labelOpenFile = new System.Windows.Forms.Label();
            this.openFilePath = new System.Windows.Forms.TextBox();
            this.buttonOpenFile = new System.Windows.Forms.Button();
            this.buttonHashCalc = new System.Windows.Forms.Button();
            this.hashExpectation = new System.Windows.Forms.TextBox();
            this.hashResult = new System.Windows.Forms.TextBox();
            this.labelExpectation = new System.Windows.Forms.Label();
            this.labelResult = new System.Windows.Forms.Label();
            this.buttonSaviInFile = new System.Windows.Forms.Button();
            this.calcOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.formMainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // formMainMenu
            // 
            this.formMainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.formMainMenuFile,
            this.formMainMenuHelp});
            this.formMainMenu.Location = new System.Drawing.Point(0, 0);
            this.formMainMenu.Name = "formMainMenu";
            this.formMainMenu.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.formMainMenu.Size = new System.Drawing.Size(484, 24);
            this.formMainMenu.TabIndex = 0;
            this.formMainMenu.Text = "menuStrip1";
            // 
            // formMainMenuFile
            // 
            this.formMainMenuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.formMainMenuSettings,
            this.formMainMenuSeparator1,
            this.formMainMenuExit});
            this.formMainMenuFile.Name = "formMainMenuFile";
            this.formMainMenuFile.Size = new System.Drawing.Size(48, 20);
            this.formMainMenuFile.Text = "Файл";
            // 
            // formMainMenuSettings
            // 
            this.formMainMenuSettings.Name = "formMainMenuSettings";
            this.formMainMenuSettings.Size = new System.Drawing.Size(180, 22);
            this.formMainMenuSettings.Text = "Параметры";
            this.formMainMenuSettings.Click += new System.EventHandler(this.formMainMenuSettings_Click);
            // 
            // formMainMenuSeparator1
            // 
            this.formMainMenuSeparator1.Name = "formMainMenuSeparator1";
            this.formMainMenuSeparator1.Size = new System.Drawing.Size(135, 6);
            // 
            // formMainMenuExit
            // 
            this.formMainMenuExit.Name = "formMainMenuExit";
            this.formMainMenuExit.Size = new System.Drawing.Size(180, 22);
            this.formMainMenuExit.Text = "Выход";
            this.formMainMenuExit.Click += new System.EventHandler(this.formMainMenuExit_Click);
            // 
            // formMainMenuHelp
            // 
            this.formMainMenuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.formMainMenuAbout});
            this.formMainMenuHelp.Name = "formMainMenuHelp";
            this.formMainMenuHelp.Size = new System.Drawing.Size(65, 20);
            this.formMainMenuHelp.Text = "Справка";
            // 
            // formMainMenuAbout
            // 
            this.formMainMenuAbout.Name = "formMainMenuAbout";
            this.formMainMenuAbout.Size = new System.Drawing.Size(149, 22);
            this.formMainMenuAbout.Text = "О программе";
            // 
            // labelCalcAlgorithm
            // 
            this.labelCalcAlgorithm.AutoSize = true;
            this.labelCalcAlgorithm.Location = new System.Drawing.Point(12, 52);
            this.labelCalcAlgorithm.Name = "labelCalcAlgorithm";
            this.labelCalcAlgorithm.Size = new System.Drawing.Size(70, 16);
            this.labelCalcAlgorithm.TabIndex = 1;
            this.labelCalcAlgorithm.Text = "Алгоритм";
            // 
            // calcAlgorithm
            // 
            this.calcAlgorithm.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.calcAlgorithm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.calcAlgorithm.FormattingEnabled = true;
            this.calcAlgorithm.Items.AddRange(new object[] {
            "MD5",
            "SHA256"});
            this.calcAlgorithm.Location = new System.Drawing.Point(118, 49);
            this.calcAlgorithm.Name = "calcAlgorithm";
            this.calcAlgorithm.Size = new System.Drawing.Size(354, 24);
            this.calcAlgorithm.TabIndex = 2;
            this.calcAlgorithm.SelectedIndexChanged += new System.EventHandler(this.calcAlgorithm_SelectedIndexChanged);
            // 
            // labelOpenFile
            // 
            this.labelOpenFile.AutoSize = true;
            this.labelOpenFile.Location = new System.Drawing.Point(12, 91);
            this.labelOpenFile.Name = "labelOpenFile";
            this.labelOpenFile.Size = new System.Drawing.Size(42, 16);
            this.labelOpenFile.TabIndex = 3;
            this.labelOpenFile.Text = "Файл";
            // 
            // openFilePath
            // 
            this.openFilePath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.openFilePath.Location = new System.Drawing.Point(118, 89);
            this.openFilePath.Name = "openFilePath";
            this.openFilePath.Size = new System.Drawing.Size(273, 22);
            this.openFilePath.TabIndex = 4;
            // 
            // buttonOpenFile
            // 
            this.buttonOpenFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOpenFile.Location = new System.Drawing.Point(397, 88);
            this.buttonOpenFile.Name = "buttonOpenFile";
            this.buttonOpenFile.Size = new System.Drawing.Size(75, 23);
            this.buttonOpenFile.TabIndex = 5;
            this.buttonOpenFile.Text = "Открыть";
            this.buttonOpenFile.UseVisualStyleBackColor = true;
            this.buttonOpenFile.Click += new System.EventHandler(this.buttonOpenFile_Click);
            // 
            // buttonHashCalc
            // 
            this.buttonHashCalc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonHashCalc.Location = new System.Drawing.Point(15, 128);
            this.buttonHashCalc.Name = "buttonHashCalc";
            this.buttonHashCalc.Size = new System.Drawing.Size(457, 30);
            this.buttonHashCalc.TabIndex = 6;
            this.buttonHashCalc.Text = "Вичислить контрольную сумму";
            this.buttonHashCalc.UseVisualStyleBackColor = true;
            this.buttonHashCalc.Click += new System.EventHandler(this.buttonHashCalc_Click);
            // 
            // hashExpectation
            // 
            this.hashExpectation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.hashExpectation.BackColor = System.Drawing.SystemColors.Window;
            this.hashExpectation.Location = new System.Drawing.Point(118, 177);
            this.hashExpectation.Name = "hashExpectation";
            this.hashExpectation.Size = new System.Drawing.Size(354, 22);
            this.hashExpectation.TabIndex = 7;
            // 
            // hashResult
            // 
            this.hashResult.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.hashResult.Location = new System.Drawing.Point(118, 205);
            this.hashResult.Name = "hashResult";
            this.hashResult.ReadOnly = true;
            this.hashResult.Size = new System.Drawing.Size(354, 22);
            this.hashResult.TabIndex = 8;
            // 
            // labelExpectation
            // 
            this.labelExpectation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelExpectation.AutoSize = true;
            this.labelExpectation.Location = new System.Drawing.Point(12, 180);
            this.labelExpectation.Name = "labelExpectation";
            this.labelExpectation.Size = new System.Drawing.Size(74, 16);
            this.labelExpectation.TabIndex = 9;
            this.labelExpectation.Text = "Ожидание";
            // 
            // labelResult
            // 
            this.labelResult.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelResult.AutoSize = true;
            this.labelResult.Location = new System.Drawing.Point(12, 208);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(77, 16);
            this.labelResult.TabIndex = 10;
            this.labelResult.Text = "Результат";
            // 
            // buttonSaviInFile
            // 
            this.buttonSaviInFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSaviInFile.Location = new System.Drawing.Point(295, 233);
            this.buttonSaviInFile.Name = "buttonSaviInFile";
            this.buttonSaviInFile.Size = new System.Drawing.Size(177, 30);
            this.buttonSaviInFile.TabIndex = 11;
            this.buttonSaviInFile.Text = "Сохранить результат";
            this.buttonSaviInFile.UseVisualStyleBackColor = true;
            // 
            // calcOpenFileDialog
            // 
            this.calcOpenFileDialog.Filter = "Все файлы|*.*";
            this.calcOpenFileDialog.Title = "Открытие файла";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 271);
            this.Controls.Add(this.buttonSaviInFile);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.labelExpectation);
            this.Controls.Add(this.hashResult);
            this.Controls.Add(this.hashExpectation);
            this.Controls.Add(this.buttonHashCalc);
            this.Controls.Add(this.buttonOpenFile);
            this.Controls.Add(this.openFilePath);
            this.Controls.Add(this.labelOpenFile);
            this.Controls.Add(this.calcAlgorithm);
            this.Controls.Add(this.labelCalcAlgorithm);
            this.Controls.Add(this.formMainMenu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Location = new System.Drawing.Point(25, 25);
            this.MainMenuStrip = this.formMainMenu;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "AMHash";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.formMainMenu.ResumeLayout(false);
            this.formMainMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip formMainMenu;
        private System.Windows.Forms.ToolStripMenuItem formMainMenuFile;
        private System.Windows.Forms.ToolStripMenuItem formMainMenuSettings;
        private System.Windows.Forms.ToolStripSeparator formMainMenuSeparator1;
        private System.Windows.Forms.ToolStripMenuItem formMainMenuExit;
        private System.Windows.Forms.ToolStripMenuItem formMainMenuHelp;
        private System.Windows.Forms.ToolStripMenuItem formMainMenuAbout;
        private System.Windows.Forms.Label labelCalcAlgorithm;
        private System.Windows.Forms.ComboBox calcAlgorithm;
        private System.Windows.Forms.Label labelOpenFile;
        private System.Windows.Forms.TextBox openFilePath;
        private System.Windows.Forms.Button buttonOpenFile;
        private System.Windows.Forms.Button buttonHashCalc;
        private System.Windows.Forms.TextBox hashExpectation;
        private System.Windows.Forms.TextBox hashResult;
        private System.Windows.Forms.Label labelExpectation;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.Button buttonSaviInFile;
        private System.Windows.Forms.OpenFileDialog calcOpenFileDialog;
    }
}

