using SoilLibrary.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SoilLibrary;

namespace SMISoilUI
{
    public partial class CreateAnalysisForm : Form
    {
        private IList<AnalysisModel> ExistingAnalyses { get; set; }
        private IList<AnalysisNutrientModel> AnalysisNutrients { get; set; } = new List<AnalysisNutrientModel>();
        private IList<ProductModel> Products { get; set; } = GlobalConfig.Connection.GetProducts_All();
        private IList<NutrientModel> Nutrients { get; set; } = GlobalConfig.Connection.GetNutrients_All();
        public CreateAnalysisForm()
        {
            InitializeComponent();
            WireUpLists();
        }

        private void WireUpLists()
        {
            RefreshDatabaseConnections();

            productDropDown.DataSource = Products;
            productDropDown.DisplayMember = "ItemName";

            nutrientDropDown.DataSource = null;
            Nutrients = Nutrients.OrderBy(x => x.ItemName).ToList();
            nutrientDropDown.DataSource = Nutrients;
            nutrientDropDown.DisplayMember = "ItemName";

            analysisListBox.DataSource = null;
            analysisListBox.DataSource = ExistingAnalyses;
            analysisListBox.DisplayMember = "AnalysisName";
            
            analysisNutrientListBox.DataSource = null;
            analysisNutrientListBox.DataSource = AnalysisNutrients;

        }

        private void RefreshDatabaseConnections()
        {
            RefreshAnalysisConnection();
            RefreshNutrientUnits();
        }

        private void RefreshAnalysisConnection()
        {
            if (productDropDown.SelectedValue != null) 
            {
                ProductModel currentProduct = (ProductModel)productDropDown.SelectedItem;
                ExistingAnalyses = GlobalConfig.Connection.GetAnalyses_ByProductId(currentProduct.Id);
                UnitModel unit = GlobalConfig.Connection.GetUnit_ById(currentProduct.UnitId);
                productUnitsValue.Text = unit.Unit;
            }
            else
            {
                ExistingAnalyses = GlobalConfig.Connection.GetAnalyses_ByProductId(-1);
            }

        }
        private void RefreshNutrientUnits()
        {
            if (nutrientDropDown.SelectedItem != null)
            {
                NutrientModel currentNutrient = (NutrientModel)nutrientDropDown.SelectedItem;
                UnitModel unit = GlobalConfig.Connection.GetUnit_ById(currentNutrient.UnitId);
                nutrientUnitsValue.Text = unit.Unit; 
            }else
            {
                nutrientUnitsValue.Text = "";
            }

        }
 
        private void productDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            WireUpLists();
        }

        private void addNutrientButton_Click(object sender, EventArgs e)
        {
            NutrientModel selectedNutrient = (NutrientModel)nutrientDropDown.SelectedItem;
            decimal nutrientAmount = Decimal.Parse(nutrientAmountValue.Text);

            // Generate the string to display in the list box
            string nutrientDisplay = $"{selectedNutrient.ItemName}, {nutrientAmount}";


            AnalysisNutrientModel analysisNutrient = new AnalysisNutrientModel()
            {
                Amount = nutrientAmount,
                NutrientId = selectedNutrient.Id,
            };

            AnalysisNutrients.Add(analysisNutrient);
            Nutrients.Remove(selectedNutrient);
            WireUpLists();
        }

        private void nutrientDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshNutrientUnits();
        }

        private void createAnalysisButton_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                AnalysisModel newAnalysis = new AnalysisModel();
                ProductModel currentProduct = (ProductModel)productDropDown.SelectedItem;

                newAnalysis.AnalysisName = analysisNameValue.Text;
                newAnalysis.ProductId = currentProduct.Id;
                newAnalysis.Nutrients = AnalysisNutrients;

                try
                {
                    GlobalConfig.Connection.CreateAnalysis(newAnalysis);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"{ex.Message}\n{ex.InnerException.Message}");
                }

            } else
            {
                MessageBox.Show("Invalid form. Make sure you have nutrients added and the name is less than 50 characters");
            }
        }

        private void removeSelectedAnalysisNutrientButton_Click(object sender, EventArgs e)
        {
            if (analysisNutrientListBox.SelectedItem != null)
            {
                AnalysisNutrientModel analysisNutrientModel = (AnalysisNutrientModel)analysisNutrientListBox.SelectedItem;
                AnalysisNutrients.Remove(analysisNutrientModel);
                NutrientModel nutrientModel = GlobalConfig.Connection.GetNutrient_ById(analysisNutrientModel.NutrientId);
                Nutrients.Add(nutrientModel);
            }
            WireUpLists();
        }

        private bool ValidateForm()
        {
            if (analysisNameValue.Text.Length < 0 || analysisNameValue.Text.Length > 50) {
                return false;
            }
            if (AnalysisNutrients.Count <= 0)
            {
                return false;
            }

            return true;
        }
    }
}
