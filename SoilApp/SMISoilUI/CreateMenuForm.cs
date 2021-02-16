using SoilLibrary.DataAccess;
using System;
using System.Windows.Forms;
using SoilLibrary.Exceptions;
using SoilLibrary;
using SoilLibrary.Utilities;

namespace SMISoilUI
{
    public partial class CreateMenuForm : Form
    {
        public CreateMenuForm()
        {
            InitializeComponent();
        }

        private void updateProductsButton_Click(object sender, EventArgs e)
        {
            try
            {
                GlobalConfig.MasterSheet.Update(MasterSheetTab.PRODUCTS);
            }
            catch (GoogleSheetUpdateException ex)
            {
                MessageBox.Show($"ERROR: {ex.Message}");
                Console.WriteLine(ex.StackTrace);
            }
            MessageBox.Show("Product update successful!");
        }
        
        private void updateMasterSheetButton_Click(object sender, EventArgs e)
        {
            try
            {
                GlobalConfig.MasterSheet.Update(MasterSheetTab.MASTER);
            } catch (GoogleSheetUpdateException ex)
            {
                MessageBox.Show($"ERROR: {ex.Message}");
                Console.WriteLine(ex.StackTrace);
            }
            MessageBox.Show("Fields and Rotation update successful!");
        }

        private void createSoilSampleFormButton_Click(object sender, EventArgs e)
        {
            Form createSampleForm = new CreateSoilSampleForm();
            createSampleForm.ShowDialog();

        }

        private void updateNutrientsButton_Click(object sender, EventArgs e)
        {
            try
            {
                GlobalConfig.MasterSheet.Update(MasterSheetTab.NUTRIENTS);
            }
            catch (GoogleSheetUpdateException ex)
            {
                MessageBox.Show($"ERROR: {ex.Message}");
                Console.WriteLine(ex.StackTrace);
            }
            MessageBox.Show("Nutrient update successful!");
        }

        private void createAnalysesFormButton_Click(object sender, EventArgs e)
        {
            try
            {
                GlobalConfig.MasterSheet.Update(MasterSheetTab.ANALYSES);
            }
            catch (GoogleSheetUpdateException ex)
            {
                MessageBox.Show($"ERROR: {ex.Message}");
                Console.WriteLine(ex.StackTrace);
            }
            MessageBox.Show("Analyses update successful!");
        }

        private void updateUnitsButton_Click(object sender, EventArgs e)
        {
            try
            {
                GlobalConfig.MasterSheet.Update(MasterSheetTab.UNITS);
            }
            catch (GoogleSheetUpdateException ex)
            {
                MessageBox.Show($"ERROR: {ex.Message}");
                Console.WriteLine(ex.StackTrace);
            }
            MessageBox.Show("Unit update successful!");
        }

        private void importIntentionsButton_Click(object sender, EventArgs e)
        {
            try
            {
                GlobalConfig.OperationSheet.Update();
            }
            catch (GoogleSheetUpdateException ex)
            {
                MessageBox.Show($"ERROR: {ex.Message}");
                Console.WriteLine(ex.StackTrace);
            }
            MessageBox.Show("Operation update successful!");
        }
    }
}
