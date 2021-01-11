using SoilLibrary;
using SoilLibrary.Models;
using System;
using System.Windows.Forms;

namespace SMISoilUI
{
    public partial class CreateUnitForm : Form
    {
        public CreateUnitForm()
        {
            InitializeComponent();
        }

        private void createUnitButton_Click(object sender, EventArgs e)
        {
            UnitModel model = new UnitModel();
            model.Unit = unitValue.Text;

            GlobalConfig.Connection.CreateUnit(model);

            if (model.Id >= 1)
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("Unit creation failed");
            }
        }
    }
}
