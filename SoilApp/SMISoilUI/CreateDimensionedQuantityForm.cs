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
using SoilLibrary.DataAccess;
using SoilLibrary.Models;

namespace SMISoilUI
{
    public partial class CreateDimensionedQuantityForm : Form
    {
        private List<DimensionedQuantityTypeModel> availableTypes = GlobalConfig.Connection.GetDimensionedQuantityType_All();
        private List<DimensionedQuantityModel> quantitiesInType = new List<DimensionedQuantityModel>();
        private List<UnitModel> availableUnits = GlobalConfig.Connection.GetUnit_All();
        public CreateDimensionedQuantityForm()
        {
            InitializeComponent();
            //CreateSampleData();
            WireUpLists();
        }
        private void CreateSampleData()
        {
            availableTypes.Add(new DimensionedQuantityTypeModel { Id = 1, Type = "Product" });
            availableTypes.Add(new DimensionedQuantityTypeModel { Id = 2, Type = "Nutrient" });

            quantitiesInType.Add(new DimensionedQuantityModel { Id = 1, UnitId= 1, ItemName = "Calcium" });
            quantitiesInType.Add(new DimensionedQuantityModel { Id = 2, UnitId=1, ItemName= "Potassium" });

        }
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

        private void createUnitFormButton_Click(object sender, EventArgs e)
        {
            Form unitForm = new CreateUnitForm();
            unitForm.ShowDialog();
            
        }

        private void createItemButton_Click(object sender, EventArgs e)
        {
            DimensionedQuantityModel model = new DimensionedQuantityModel();
            model.ItemName = quantityNameValue.Text;
            UnitModel unit = (UnitModel)itemUnitsDropDown.SelectedItem;
            DimensionedQuantityTypeModel type = (DimensionedQuantityTypeModel) selectedTypeDropDown.SelectedItem;

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
            DimensionedQuantityTypeModel type = (DimensionedQuantityTypeModel) selectedTypeDropDown.SelectedItem;
            quantitiesInType = GlobalConfig.Connection.GetDimensionedQuantity_ByType(type.Id);
            WireUpLists();
        }
    }   
}
