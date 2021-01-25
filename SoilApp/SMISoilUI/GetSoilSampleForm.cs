using SoilLibrary.Models;
using SoilLibrary.Utilities;
using SoilLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SMISoilUI
{
    public partial class CreateSoilSampleIntentionsForm : Form
    {
        public string SelectedFilePath { get; set; }

        private IList<ProductModel> Products = GlobalConfig.Connection.GetProducts_All();

        public int RotationYear { get; set; }
        public CreateSoilSampleIntentionsForm()
        {
            InitializeComponent();
            WireUpLists();
        }

        private void WireUpLists()
        {
            cropDropDown.DataSource = Products;
            cropDropDown.DisplayMember = "ItemName";
        }
        private void generateSoilDataButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowser = new FolderBrowserDialog();
            ChooseFolder();
        }

        public void ChooseFolder()
        {
            folderBrowserBox.Description = "Select Folder To Save File";
            if (folderBrowserBox.ShowDialog() == DialogResult.OK)
            {
                SelectedFilePath = folderBrowserBox.SelectedPath;

                Dictionary<string, object> parameters = new Dictionary<string, object>();

                parameters.Add("RotationYear", yearValue.Text);
                parameters.Add("LastSampled", lastSampledYearValue.Text);
                parameters.Add("FolderPath", SelectedFilePath);
                parameters.Add("Crop", cropDropDown.SelectedItem);


                ExcelWriter.WriteSoilSampleIntentions(parameters);
                MessageBox.Show($"File written to:\n {SelectedFilePath}");
            }

        }
    }
}
