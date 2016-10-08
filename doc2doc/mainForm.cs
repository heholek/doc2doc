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

namespace doc2doc
{
    public partial class mainForm : Form
    {
        BindingList<String> filesToConvert = new BindingList<string>();

        public mainForm()
        {
            InitializeComponent();
            docxFileList.DataSource = filesToConvert;
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
        }

        private void startConversionButton_Click(object sender, EventArgs e)
        {

        }
    }
}
