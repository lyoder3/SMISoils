using SoilLibrary;
using SoilLibrary.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SMISoilUI
{
    public partial class CreateDimensionedQuantityForm : Form
    {
        /// <summary>
        /// Fetches all DimensionedQuantity types from database
        /// </summary>
        private IList<DimensionedQuantityTypeModel> availableTypes = GlobalConfig.Connection.GetDimensionedQuantityType_All();
        /// <summary>
        /// List to store the quantities that are the selected Type
        /// </summary>
        private IList<DimensionedQuantityModel> quantitiesInType = new List<DimensionedQuantityModel>();
        /// <summary>
        /// Fetches all units from database
        /// </summary>
        private IList<UnitModel> availableUnits = GlobalConfig.Connection.GetUnit_All();

        /// <summary>
        /// Creates the form and wires up the lists
        /// </summary>
        public CreateDimensionedQuantityForm()
        {
            InitializeComponent();
            //CreateSampleData();
            WireUpLists();
        }
        /// <summary>
        /// Method to create fake test data when testing the form
        /// </summary>
        private void CreateSampleData()
        {
            availableTypes.Add(new DimensionedQuantityTypeModel { Id = 1, Type = "Product" });
            availableTypes.Add(new DimensionedQuantityTypeModel { Id = 2, Type = "Nutrient" });

            quantitiesInType.Add(new DimensionedQuantityModel { Id = 1, UnitId = 1, ItemName = "Calcium" });
            quantitiesInType.Add(new DimensionedQuantityModel { Id = 2, UnitId = 1, ItemName = "Potassium" });

        }
        /// <summary>
        /// Links all combo boxes and lists to their respective properties
        /// </summary>
        private void WireUpLists()
        {
            selectedTypeDropDown.DataSource = availableTypes;
            selectedTypeDropDown.DisplayMember = "Type";

            measuredQuantityListBox.DataSource = null;
            measuredQuantityListBox.DataSource = quantitiesInType;
            measuredQuantityListBox.DisplayMember = "ItemName";

            itemUnitsDropDown.DataSource = availableUnits;
            itemUnitsDropDown.DisplayMember = "Unit";
        }
        /// <summary>
        /// Event handler for clicking the "Add" unit button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void createUnitFormButton_Click(object sender, EventArgs e)
        {
            Form unitForm = new CreateUnitForm();
            unitForm.ShowDialog();

        }
        /// <summary>
        /// Event handler for processing a Create Item button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void createItemButton_Click(object sender, EventArgs e)
        {
            DimensionedQuantityModel model = new DimensionedQuantityModel();
            model.ItemName = quantityNameValue.Text;
            UnitModel unit = (UnitModel)itemUnitsDropDown.SelectedItem;
            DimensionedQuantityTypeModel type = (DimensionedQuantityTypeModel)selectedTypeDropDown.SelectedItem;

            model.UnitId = unit.Id;
            model.TypeId = type.Id;

            GlobalConfig.Connection.CreateDimensionedQuantity(model);

            quantityNameValue.Text = "";
            SetQuantitiesInType();
        }

        private void selectedTypeDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetQuantitiesInType();
        }

        private void SetQuantitiesInType()
        {
            DimensionedQuantityTypeModel type = (DimensionedQuantityTypeModel)selectedTypeDropDown.SelectedItem;
            quantitiesInType = GlobalConfig.Connection.GetDimensionedQuantity_ByType(type.Id);
            WireUpLists();
        }
    }
}
