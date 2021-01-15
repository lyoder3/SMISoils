using System;
using System.Windows.Forms;

namespace SMISoilUI
{
    public partial class HomeForm : Form
    {
        public HomeForm()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void createMenuButton_Click(object sender, EventArgs e)
        {
            Form createMenuForm = new CreateMenuForm();
            createMenuForm.Show();
        }

        private void getSoilDataMenuButton_Click(object sender, EventArgs e)
        {
            Form getSoilDataForm = new GetSoilDataForm();
            getSoilDataForm.Show();
        }

        private void getSoilSampleDataButton_Click(object sender, EventArgs e)
        {
            Form getSoilSampleForm = new CreateSoilSampleIntentionsForm();
            getSoilSampleForm.ShowDialog();
        }
    }
}
