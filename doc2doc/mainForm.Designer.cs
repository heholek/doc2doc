namespace doc2doc
{
    partial class mainForm
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
            this.chooseFolderButton = new System.Windows.Forms.Button();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.selectedFolderLabel = new System.Windows.Forms.Label();
            this.docxFileList = new System.Windows.Forms.ListBox();
            this.fileListHeader = new System.Windows.Forms.Label();
            this.startConversionButton = new System.Windows.Forms.Button();
            this.conversionInfoLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // chooseFolderButton
            // 
            this.chooseFolderButton.Location = new System.Drawing.Point(12, 35);
            this.chooseFolderButton.Name = "chooseFolderButton";
            this.chooseFolderButton.Size = new System.Drawing.Size(134, 23);
            this.chooseFolderButton.TabIndex = 0;
            this.chooseFolderButton.Text = "Выбрать папку...";
            this.chooseFolderButton.UseVisualStyleBackColor = true;
            this.chooseFolderButton.Click += new System.EventHandler(this.chooseFolderButton_Click);
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Location = new System.Drawing.Point(12, 9);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(311, 13);
            this.descriptionLabel.TabIndex = 1;
            this.descriptionLabel.Text = "Пакетное преобразование файлов Word 2007+ в Word 2003";
            // 
            // folderBrowserDialog
            // 
            this.folderBrowserDialog.ShowNewFolderButton = false;
            // 
            // selectedFolderLabel
            // 
            this.selectedFolderLabel.AutoSize = true;
            this.selectedFolderLabel.Location = new System.Drawing.Point(152, 40);
            this.selectedFolderLabel.Name = "selectedFolderLabel";
            this.selectedFolderLabel.Size = new System.Drawing.Size(0, 13);
            this.selectedFolderLabel.TabIndex = 2;
            // 
            // docxFileList
            // 
            this.docxFileList.FormattingEnabled = true;
            this.docxFileList.Location = new System.Drawing.Point(12, 77);
            this.docxFileList.Name = "docxFileList";
            this.docxFileList.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.docxFileList.Size = new System.Drawing.Size(447, 147);
            this.docxFileList.Sorted = true;
            this.docxFileList.TabIndex = 3;
            // 
            // fileListHeader
            // 
            this.fileListHeader.AutoSize = true;
            this.fileListHeader.Location = new System.Drawing.Point(12, 61);
            this.fileListHeader.Name = "fileListHeader";
            this.fileListHeader.Size = new System.Drawing.Size(209, 13);
            this.fileListHeader.TabIndex = 4;
            this.fileListHeader.Text = "Файлы, которые будут преобразованы:";
            // 
            // startConversionButton
            // 
            this.startConversionButton.Location = new System.Drawing.Point(12, 230);
            this.startConversionButton.Name = "startConversionButton";
            this.startConversionButton.Size = new System.Drawing.Size(447, 23);
            this.startConversionButton.TabIndex = 5;
            this.startConversionButton.Text = "Преобразовать!";
            this.startConversionButton.UseVisualStyleBackColor = true;
            this.startConversionButton.Click += new System.EventHandler(this.startConversionButton_Click);
            // 
            // conversionInfoLabel
            // 
            this.conversionInfoLabel.AutoSize = true;
            this.conversionInfoLabel.Location = new System.Drawing.Point(12, 256);
            this.conversionInfoLabel.Name = "conversionInfoLabel";
            this.conversionInfoLabel.Size = new System.Drawing.Size(408, 39);
            this.conversionInfoLabel.TabIndex = 6;
            this.conversionInfoLabel.Text = "Примечание: преобразованные файлы будут записаны в то же расположение,\r\nгде наход" +
    "ятся исходные файлы.\r\nИсходные файлы не будут изменены.";
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 310);
            this.Controls.Add(this.conversionInfoLabel);
            this.Controls.Add(this.startConversionButton);
            this.Controls.Add(this.fileListHeader);
            this.Controls.Add(this.docxFileList);
            this.Controls.Add(this.selectedFolderLabel);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.chooseFolderButton);
            this.MaximizeBox = false;
            this.Name = "mainForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "doc2doc";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button chooseFolderButton;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.Label selectedFolderLabel;
        private System.Windows.Forms.ListBox docxFileList;
        private System.Windows.Forms.Label fileListHeader;
        private System.Windows.Forms.Button startConversionButton;
        private System.Windows.Forms.Label conversionInfoLabel;
    }
}

