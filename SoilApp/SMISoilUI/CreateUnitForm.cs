using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SoilLibrary.Models;
using SoilLibrary;

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

            model = GlobalConfig.Connection.CreateUnit(model);

            if (model.Id >= 1) {
                this.Close();
            }
            else
            {
                MessageBox.Show("Unit creation failed");
            }   
        }
    }
}
