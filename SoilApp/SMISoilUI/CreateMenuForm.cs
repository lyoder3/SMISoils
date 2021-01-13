using SoilLibrary.DataAccess;
using System;
using System.Windows.Forms;
using SoilLibrary.Exceptions;
using SoilLibrary;

namespace SMISoilUI
{
    public partial class CreateMenuForm : Form
    {
        public CreateMenuForm()
        {
            InitializeComponent();
        }

        private void createProductFormButton_Click(object sender, EventArgs e)
        {
            Form createProductForm = new CreateProductForm();
            createProductForm.ShowDialog();
        }
        
        private void masterSheetSyncButton_Click(object sender, EventArgs e)
        {
            try
            {
                GlobalConfig.MasterSheet.UpsertFieldsAndRotations();
            } catch (GoogleSheetUpdateException ex)
            {
                MessageBox.Show($"ERROR: {ex.Message}");
                Console.WriteLine(ex.StackTrace);
            }
            MessageBox.Show("Master Sheet sync successful!");
        }

        private void createSoilSampleFormButton_Click(object sender, EventArgs e)
        {
            Form createSampleForm = new CreateSoilSampleForm();
            createSampleForm.ShowDialog();

        }

        private void createNutrientFormButton_Click(object sender, EventArgs e)
        {
            Form createNutrientForm = new CreateNutrientForm();
            createNutrientForm.ShowDialog();
        }

        private void createAnalysesFormButton_Click(object sender, EventArgs e)
        {
            Form createAnalysisForm = new CreateAnalysisForm();
            createAnalysisForm.ShowDialog();
        }
    }
}
