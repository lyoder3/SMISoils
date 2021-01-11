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

        private void createMeasuredQuantityFormButton_Click(object sender, EventArgs e)
        {
            Form measuredQuantityForm = new CreateDimensionedQuantityForm();
            measuredQuantityForm.ShowDialog();
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
    }
}
