using SoilLibrary;
using SoilLibrary.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SMISoilUI
{
    public partial class CreateProductForm : Form
    {
        private IList<ProductModel> AvailableProducts { get; set; }
        private IList<UnitModel> AvailableUnits { get; set; }
        public CreateProductForm()
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

            productUnitsDropDown.DataSource = AvailableUnits;
            productUnitsDropDown.ValueMember = "Unit";

            productListBox.DataSource = AvailableProducts;
            productListBox.ValueMember = "ItemName";
        }
        private void createProductButton_Click(object sender, EventArgs e)
        {
            ProductModel newProduct = new ProductModel();

            newProduct.ItemName = productNameValue.Text;
            UnitModel selectedUnit = (UnitModel)productUnitsDropDown.SelectedItem;
            newProduct.UnitId = selectedUnit.Id;

            GlobalConfig.Connection.CreateProduct(newProduct);

            WireUpLists();

        }

        private void RefreshDatabaseConnections()
        {
            AvailableUnits = GlobalConfig.Connection.GetUnits_All();
            AvailableProducts = GlobalConfig.Connection.GetProducts_All();
        }
    }
}
