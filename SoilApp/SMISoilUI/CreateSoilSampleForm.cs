using SoilLibrary.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Windows.Forms;

namespace SMISoilUI
{
    public partial class CreateSoilSampleForm : Form
    {
        private List<string> selectedFilePaths = new List<string>();
        public CreateSoilSampleForm()
        {
            InitializeComponent();
            //CreateSampleData();
            WireUpLists();
            this.AutoSize = true;
            this.AutoSizeMode = AutoSizeMode.GrowOnly;
        }

        private void CreateSampleData()
        {
            selectedFilePaths.Add(@"C:\Users\loyod\Desktop");
            selectedFilePaths.Add(@"C:\Users\loyod\Desktop\SMISoils\soils");
        }

        private void browseButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowser = new FolderBrowserDialog();
            ChooseFolder();
        }

        private void WireUpLists()
        {
            selectedFilesListBox.DataSource = null;
            selectedFilesListBox.DataSource = selectedFilePaths;
        }

        public void ChooseFolder()
        {
            folderBrowserBox.Description = "Select Folder Containing Soil Samples";
            if (folderBrowserBox.ShowDialog() == DialogResult.OK)
            {
                selectedFilePaths.Clear();
                string[] files = Directory.GetFiles(folderBrowserBox.SelectedPath);
                foreach (var file in files)
                {
                    string fileName = Path.GetFileName(file);
                    string extension = Path.GetExtension(file);
                    bool isCSV = extension == ".csv";
                    if (isCSV)
                    {
                        selectedFilePaths.Add(file);
                    }
                }
            }
            WireUpLists();
        }

        private void importButton_Click(object sender, EventArgs e)
        {
            if (selectedFilePaths.Count > 0)
            {
                SoilSampleProcessor sampleProcesor = new SoilSampleProcessor(selectedFilePaths);
                sampleProcesor.ProcessSamples();
                Console.WriteLine();
            }
        }
    }
}
