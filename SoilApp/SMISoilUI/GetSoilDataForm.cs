using SoilLibrary;
using SoilLibrary.Models;
using SoilLibrary.Utilities;
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
    public partial class GetSoilDataForm : Form
    {
        public IList<string> Farms { get; set; }
        public IList<FieldModel> Fields { get; set; }
        public int Year { get; set; }
        public IList<ProductModel> Crops { get; set; }
        
        public IList<NutrientModel> Nutrients { get; set; }
        public string SelectedFilePath { get; set; }

        public GetSoilDataForm()
        {
            InitializeComponent();
            WireUpLists();
        }

        private void WireUpLists()
        {
            Fields = GlobalConfig.Connection.GetFields("ALL");

            Farms = Fields.Select(field => field.Farm).Distinct().ToList();

            Farms.Add("ALL");

            Farms.OrderBy(x => x);

            Crops = GlobalConfig.Connection.GetProducts_All();

            Nutrients = GlobalConfig.Connection.GetNutrients_All();

            farmDropDown.DataSource = Farms;
            cropDropDown.DataSource = Crops;
            cropDropDown.DisplayMember = "ItemName";

            nutrientDropDown.DataSource = Nutrients;
            nutrientDropDown.DisplayMember = "ItemName";
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
            }

            Dictionary<string, object> parameters = new Dictionary<string, object>();

            parameters.Add("FarmName", farmDropDown.SelectedValue);
            parameters.Add("RotationYear", yearValue.Text);
            parameters.Add("FolderPath", SelectedFilePath);
            parameters.Add("Crop", cropDropDown.SelectedItem);
            parameters.Add("Nutrient", nutrientDropDown.SelectedItem);


            ExcelWriter.WriteSoilData(parameters);
        }
    }
}
