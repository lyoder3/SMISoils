using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SoilLibrary.DataAccess;

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
                MasterSheet.UpsertFieldsAndRotations();
                MessageBox.Show("Master Sheet sync successful!");
            }catch (Exception exception)
            {
                MessageBox.Show("Master sheet sync failed.");
                Console.WriteLine(exception.StackTrace);
            }

        }

        private void createSoilSampleFormButton_Click(object sender, EventArgs e)
        {
            Form createSampleForm = new CreateSoilSampleForm();
            createSampleForm.ShowDialog();

        }
    }
}
