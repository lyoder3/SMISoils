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
    public partial class GetSoilDataForm : Form
    {
        public IList<string> Farms { get; set; } = new List<string>();
        public IList<FieldModel> Fields { get; set; }
        public IList<int> Years { get; set; }
        public IList<ProductModel> Crops { get; set; }

        public GetSoilDataForm()
        {
            InitializeComponent();
        }
    }
}
