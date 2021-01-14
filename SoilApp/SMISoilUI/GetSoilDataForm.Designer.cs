
namespace SMISoilUI
{
    partial class GetSoilDataForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GetSoilDataForm));
            this.filtersGroupBox = new System.Windows.Forms.GroupBox();
            this.nutrientLabel = new System.Windows.Forms.Label();
            this.nutrientDropDown = new System.Windows.Forms.ComboBox();
            this.cropLabel = new System.Windows.Forms.Label();
            this.cropDropDown = new System.Windows.Forms.ComboBox();
            this.yearLabel = new System.Windows.Forms.Label();
            this.farmNameLabel = new System.Windows.Forms.Label();
            this.farmDropDown = new System.Windows.Forms.ComboBox();
            this.generateSoilDataButton = new System.Windows.Forms.Button();
            this.yearValue = new System.Windows.Forms.TextBox();
            this.folderBrowserBox = new System.Windows.Forms.FolderBrowserDialog();
            this.filtersGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // filtersGroupBox
            // 
            this.filtersGroupBox.Controls.Add(this.yearValue);
            this.filtersGroupBox.Controls.Add(this.nutrientLabel);
            this.filtersGroupBox.Controls.Add(this.nutrientDropDown);
            this.filtersGroupBox.Controls.Add(this.cropLabel);
            this.filtersGroupBox.Controls.Add(this.cropDropDown);
            this.filtersGroupBox.Controls.Add(this.yearLabel);
            this.filtersGroupBox.Controls.Add(this.farmNameLabel);
            this.filtersGroupBox.Controls.Add(this.farmDropDown);
            this.filtersGroupBox.Location = new System.Drawing.Point(23, 42);
            this.filtersGroupBox.Name = "filtersGroupBox";
            this.filtersGroupBox.Size = new System.Drawing.Size(416, 310);
            this.filtersGroupBox.TabIndex = 0;
            this.filtersGroupBox.TabStop = false;
            this.filtersGroupBox.Text = "Filters";
            // 
            // nutrientLabel
            // 
            this.nutrientLabel.AutoSize = true;
            this.nutrientLabel.Location = new System.Drawing.Point(17, 233);
            this.nutrientLabel.Name = "nutrientLabel";
            this.nutrientLabel.Size = new System.Drawing.Size(90, 30);
            this.nutrientLabel.TabIndex = 9;
            this.nutrientLabel.Text = "Nutrient";
            // 
            // nutrientDropDown
            // 
            this.nutrientDropDown.AllowDrop = true;
            this.nutrientDropDown.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.nutrientDropDown.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.nutrientDropDown.FormattingEnabled = true;
            this.nutrientDropDown.Location = new System.Drawing.Point(123, 230);
            this.nutrientDropDown.Name = "nutrientDropDown";
            this.nutrientDropDown.Size = new System.Drawing.Size(274, 38);
            this.nutrientDropDown.TabIndex = 8;
            // 
            // cropLabel
            // 
            this.cropLabel.AutoSize = true;
            this.cropLabel.Location = new System.Drawing.Point(17, 173);
            this.cropLabel.Name = "cropLabel";
            this.cropLabel.Size = new System.Drawing.Size(57, 30);
            this.cropLabel.TabIndex = 7;
            this.cropLabel.Text = "Crop";
            // 
            // cropDropDown
            // 
            this.cropDropDown.AllowDrop = true;
            this.cropDropDown.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cropDropDown.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cropDropDown.FormattingEnabled = true;
            this.cropDropDown.Location = new System.Drawing.Point(123, 170);
            this.cropDropDown.Name = "cropDropDown";
            this.cropDropDown.Size = new System.Drawing.Size(274, 38);
            this.cropDropDown.TabIndex = 6;
            // 
            // yearLabel
            // 
            this.yearLabel.AutoSize = true;
            this.yearLabel.Location = new System.Drawing.Point(17, 110);
            this.yearLabel.Name = "yearLabel";
            this.yearLabel.Size = new System.Drawing.Size(52, 30);
            this.yearLabel.TabIndex = 5;
            this.yearLabel.Text = "Year";
            // 
            // farmNameLabel
            // 
            this.farmNameLabel.AutoSize = true;
            this.farmNameLabel.Location = new System.Drawing.Point(17, 51);
            this.farmNameLabel.Name = "farmNameLabel";
            this.farmNameLabel.Size = new System.Drawing.Size(58, 30);
            this.farmNameLabel.TabIndex = 1;
            this.farmNameLabel.Text = "Farm";
            // 
            // farmDropDown
            // 
            this.farmDropDown.AllowDrop = true;
            this.farmDropDown.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.farmDropDown.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.farmDropDown.FormattingEnabled = true;
            this.farmDropDown.Location = new System.Drawing.Point(123, 48);
            this.farmDropDown.Name = "farmDropDown";
            this.farmDropDown.Size = new System.Drawing.Size(274, 38);
            this.farmDropDown.TabIndex = 0;
            // 
            // generateSoilDataButton
            // 
            this.generateSoilDataButton.Location = new System.Drawing.Point(458, 161);
            this.generateSoilDataButton.Name = "generateSoilDataButton";
            this.generateSoilDataButton.Size = new System.Drawing.Size(122, 65);
            this.generateSoilDataButton.TabIndex = 1;
            this.generateSoilDataButton.Text = "Generate";
            this.generateSoilDataButton.UseVisualStyleBackColor = true;
            this.generateSoilDataButton.Click += new System.EventHandler(this.generateSoilDataButton_Click);
            // 
            // yearValue
            // 
            this.yearValue.Location = new System.Drawing.Point(123, 107);
            this.yearValue.Name = "yearValue";
            this.yearValue.Size = new System.Drawing.Size(273, 35);
            this.yearValue.TabIndex = 10;
            // 
            // GetSoilDataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(608, 387);
            this.Controls.Add(this.generateSoilDataButton);
            this.Controls.Add(this.filtersGroupBox);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "GetSoilDataForm";
            this.Text = "Get Soil Data";
            this.filtersGroupBox.ResumeLayout(false);
            this.filtersGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox filtersGroupBox;
        private System.Windows.Forms.Label farmNameLabel;
        private System.Windows.Forms.ComboBox farmDropDown;
        private System.Windows.Forms.Button generateSoilDataButton;
        private System.Windows.Forms.Label cropLabel;
        private System.Windows.Forms.ComboBox cropDropDown;
        private System.Windows.Forms.Label yearLabel;
        private System.Windows.Forms.Label nutrientLabel;
        private System.Windows.Forms.ComboBox nutrientDropDown;
        private System.Windows.Forms.TextBox yearValue;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserBox;
    }
}