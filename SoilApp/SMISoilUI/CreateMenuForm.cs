using SoilLibrary.DataAccess;
using System;
using System.Windows.Forms;

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
            MasterSheet.UpsertFieldsAndRotations();
            MessageBox.Show("Master Sheet sync successful!");
        }

        private void createSoilSampleFormButton_Click(object sender, EventArgs e)
        {
            Form createSampleForm = new CreateSoilSampleForm();
            createSampleForm.ShowDialog();

        }
    }
}
