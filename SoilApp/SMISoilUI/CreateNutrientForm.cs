using SoilLibrary;
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

namespace SMISoilUI
{
    public partial class CreateNutrientForm : Form
    {
        public IList<UnitModel> AvailableUnits { get; set; }
        public IList<NutrientModel> AvailableNutrients { get; set; }
        public CreateNutrientForm()
        {
            InitializeComponent();
            WireUpLists();
        }

        private void createUnitFormButton_Click(object sender, EventArgs e)
        {
            Form createUnitForm = new CreateUnitForm();
            createUnitForm.ShowDialog();
            WireUpLists();
        }
        private void WireUpLists()
        {
            RefreshDatabaseConnections();
            nutrientUnitsDropDown.DataSource = AvailableUnits;
            nutrientUnitsDropDown.ValueMember = "Unit";

            nutrientListBox.DataSource = AvailableNutrients;
            nutrientListBox.ValueMember = "ItemName";
        }
        private void createNutrientButton_Click(object sender, EventArgs e)
        {
            NutrientModel newNutrient = new NutrientModel();

            newNutrient.ItemName = nutrientNameValue.Text;
            UnitModel selectedUnit = (UnitModel) nutrientUnitsDropDown.SelectedItem;
            newNutrient.UnitId = selectedUnit.Id;

            GlobalConfig.Connection.CreateNutrient(newNutrient);

            WireUpLists();

        }

        private void RefreshDatabaseConnections()
        {
            AvailableUnits = GlobalConfig.Connection.GetUnits_All();
            AvailableNutrients = GlobalConfig.Connection.GetNutrients_All();
        }
    }
}
