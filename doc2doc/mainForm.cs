using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Word;

namespace doc2doc
{
    public partial class mainForm : Form
    {
        BindingList<String> filesToConvert = new BindingList<string>();

        public mainForm()
        {
            InitializeComponent();
            docxFileList.DataSource = filesToConvert;
            startConversionButton.Enabled = false;
        }

        private void chooseFolderButton_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog.ShowDialog() != DialogResult.OK)
                return;
            selectedFolderLabel.Text = folderBrowserDialog.SelectedPath;
            DirectoryInfo dinfo = new DirectoryInfo(folderBrowserDialog.SelectedPath);
            FileInfo[] files = dinfo.GetFiles("*.docx");
            filesToConvert.Clear();
            foreach (FileInfo file in files)
                filesToConvert.Add(file.Name);
            startConversionButton.Enabled = true;
        }

        private void startConversionButton_Click(object sender, EventArgs e)
        {
            startConversionButton.Enabled = false;

            var word = new Microsoft.Office.Interop.Word.Application();
            //word.Visible = false;
            //word.ScreenUpdating = false;
            // C# doesn't have optional arguments so we'll need a dummy value
            //object oMissing = System.Reflection.Missing.Value;
            foreach (var fname in filesToConvert)
            {
                string fullname = selectedFolderLabel.Text + "\\" + fname;
                Document doc = word.Documents.Open(fullname);
                doc.Activate();
                string outputFileName = fullname.Replace(".docx", ".doc");
                var fileFormat = WdSaveFormat.wdFormatDocument97;
                doc.SaveAs2(outputFileName, fileFormat);
                ((_Document)doc).Close(WdSaveOptions.wdDoNotSaveChanges);
                doc = null;
            }
            MessageBox.Show("Преобразование закончено!");
            filesToConvert.Clear();
            selectedFolderLabel.Text = "";            
        }
    }
}
