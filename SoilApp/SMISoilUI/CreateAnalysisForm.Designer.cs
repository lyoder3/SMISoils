
namespace SMISoilUI
{
    partial class CreateAnalysisForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateAnalysisForm));
            this.analysisListBox = new System.Windows.Forms.ListBox();
            this.analysisListLabel = new System.Windows.Forms.Label();
            this.productDropDown = new System.Windows.Forms.ComboBox();
            this.productLabel = new System.Windows.Forms.Label();
            this.productUnitsLabel = new System.Windows.Forms.Label();
            this.productUnitsValue = new System.Windows.Forms.TextBox();
            this.analysisNutrientListBox = new System.Windows.Forms.ListBox();
            this.nutrientsLabel = new System.Windows.Forms.Label();
            this.analysisNutrientGroupBox = new System.Windows.Forms.GroupBox();
            this.addNutrientButton = new System.Windows.Forms.Button();
            this.nutrientAmountLabel = new System.Windows.Forms.Label();
            this.nutrientAmountValue = new System.Windows.Forms.TextBox();
            this.nutrientUnitsLabel = new System.Windows.Forms.Label();
            this.nutrientUnitsValue = new System.Windows.Forms.TextBox();
            this.nutrientDropDown = new System.Windows.Forms.ComboBox();
            this.nutrientLabel = new System.Windows.Forms.Label();
            this.createAnalysisButton = new System.Windows.Forms.Button();
            this.analysisNameLabel = new System.Windows.Forms.Label();
            this.analysisNameValue = new System.Windows.Forms.TextBox();
            this.removeSelectedAnalysisNutrientButton = new System.Windows.Forms.Button();
            this.analysisNutrientGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // analysisListBox
            // 
            this.analysisListBox.FormattingEnabled = true;
            this.analysisListBox.ItemHeight = 30;
            this.analysisListBox.Location = new System.Drawing.Point(21, 50);
            this.analysisListBox.Name = "analysisListBox";
            this.analysisListBox.Size = new System.Drawing.Size(257, 574);
            this.analysisListBox.TabIndex = 18;
            // 
            // analysisListLabel
            // 
            this.analysisListLabel.AutoSize = true;
            this.analysisListLabel.Location = new System.Drawing.Point(89, 11);
            this.analysisListLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.analysisListLabel.Name = "analysisListLabel";
            this.analysisListLabel.Size = new System.Drawing.Size(84, 30);
            this.analysisListLabel.TabIndex = 17;
            this.analysisListLabel.Text = "Existing";
            // 
            // productDropDown
            // 
            this.productDropDown.FormattingEnabled = true;
            this.productDropDown.Location = new System.Drawing.Point(497, 50);
            this.productDropDown.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.productDropDown.Name = "productDropDown";
            this.productDropDown.Size = new System.Drawing.Size(248, 38);
            this.productDropDown.TabIndex = 20;
            this.productDropDown.SelectedIndexChanged += new System.EventHandler(this.productDropDown_SelectedIndexChanged);
            // 
            // productLabel
            // 
            this.productLabel.AutoSize = true;
            this.productLabel.Location = new System.Drawing.Point(342, 50);
            this.productLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.productLabel.Name = "productLabel";
            this.productLabel.Size = new System.Drawing.Size(147, 30);
            this.productLabel.TabIndex = 19;
            this.productLabel.Text = "Product Name";
            // 
            // productUnitsLabel
            // 
            this.productUnitsLabel.AutoSize = true;
            this.productUnitsLabel.Location = new System.Drawing.Point(344, 105);
            this.productUnitsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.productUnitsLabel.Name = "productUnitsLabel";
            this.productUnitsLabel.Size = new System.Drawing.Size(138, 30);
            this.productUnitsLabel.TabIndex = 22;
            this.productUnitsLabel.Text = "Product Units";
            // 
            // productUnitsValue
            // 
            this.productUnitsValue.Location = new System.Drawing.Point(497, 102);
            this.productUnitsValue.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.productUnitsValue.Name = "productUnitsValue";
            this.productUnitsValue.Size = new System.Drawing.Size(248, 35);
            this.productUnitsValue.TabIndex = 21;
            // 
            // analysisNutrientListBox
            // 
            this.analysisNutrientListBox.FormattingEnabled = true;
            this.analysisNutrientListBox.ItemHeight = 30;
            this.analysisNutrientListBox.Location = new System.Drawing.Point(776, 50);
            this.analysisNutrientListBox.Name = "analysisNutrientListBox";
            this.analysisNutrientListBox.Size = new System.Drawing.Size(322, 484);
            this.analysisNutrientListBox.TabIndex = 24;
            // 
            // nutrientsLabel
            // 
            this.nutrientsLabel.AutoSize = true;
            this.nutrientsLabel.Location = new System.Drawing.Point(860, 11);
            this.nutrientsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nutrientsLabel.Name = "nutrientsLabel";
            this.nutrientsLabel.Size = new System.Drawing.Size(166, 30);
            this.nutrientsLabel.TabIndex = 23;
            this.nutrientsLabel.Text = "Added Nutrients";
            // 
            // analysisNutrientGroupBox
            // 
            this.analysisNutrientGroupBox.Controls.Add(this.addNutrientButton);
            this.analysisNutrientGroupBox.Controls.Add(this.nutrientAmountLabel);
            this.analysisNutrientGroupBox.Controls.Add(this.nutrientAmountValue);
            this.analysisNutrientGroupBox.Controls.Add(this.nutrientUnitsLabel);
            this.analysisNutrientGroupBox.Controls.Add(this.nutrientUnitsValue);
            this.analysisNutrientGroupBox.Controls.Add(this.nutrientDropDown);
            this.analysisNutrientGroupBox.Controls.Add(this.nutrientLabel);
            this.analysisNutrientGroupBox.Location = new System.Drawing.Point(329, 221);
            this.analysisNutrientGroupBox.Name = "analysisNutrientGroupBox";
            this.analysisNutrientGroupBox.Size = new System.Drawing.Size(430, 316);
            this.analysisNutrientGroupBox.TabIndex = 25;
            this.analysisNutrientGroupBox.TabStop = false;
            this.analysisNutrientGroupBox.Text = "Add Nutrient";
            // 
            // addNutrientButton
            // 
            this.addNutrientButton.Location = new System.Drawing.Point(120, 241);
            this.addNutrientButton.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.addNutrientButton.Name = "addNutrientButton";
            this.addNutrientButton.Size = new System.Drawing.Size(194, 53);
            this.addNutrientButton.TabIndex = 27;
            this.addNutrientButton.Text = "Add Nutrient";
            this.addNutrientButton.UseVisualStyleBackColor = true;
            this.addNutrientButton.Click += new System.EventHandler(this.addNutrientButton_Click);
            // 
            // nutrientAmountLabel
            // 
            this.nutrientAmountLabel.AutoSize = true;
            this.nutrientAmountLabel.Location = new System.Drawing.Point(10, 193);
            this.nutrientAmountLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nutrientAmountLabel.Name = "nutrientAmountLabel";
            this.nutrientAmountLabel.Size = new System.Drawing.Size(143, 30);
            this.nutrientAmountLabel.TabIndex = 26;
            this.nutrientAmountLabel.Text = "Nutrient Level";
            // 
            // nutrientAmountValue
            // 
            this.nutrientAmountValue.Location = new System.Drawing.Point(165, 190);
            this.nutrientAmountValue.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.nutrientAmountValue.Name = "nutrientAmountValue";
            this.nutrientAmountValue.Size = new System.Drawing.Size(248, 35);
            this.nutrientAmountValue.TabIndex = 25;
            // 
            // nutrientUnitsLabel
            // 
            this.nutrientUnitsLabel.AutoSize = true;
            this.nutrientUnitsLabel.Location = new System.Drawing.Point(10, 128);
            this.nutrientUnitsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nutrientUnitsLabel.Name = "nutrientUnitsLabel";
            this.nutrientUnitsLabel.Size = new System.Drawing.Size(143, 30);
            this.nutrientUnitsLabel.TabIndex = 24;
            this.nutrientUnitsLabel.Text = "Nutrient Units";
            // 
            // nutrientUnitsValue
            // 
            this.nutrientUnitsValue.Location = new System.Drawing.Point(165, 125);
            this.nutrientUnitsValue.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.nutrientUnitsValue.Name = "nutrientUnitsValue";
            this.nutrientUnitsValue.Size = new System.Drawing.Size(248, 35);
            this.nutrientUnitsValue.TabIndex = 23;
            // 
            // nutrientDropDown
            // 
            this.nutrientDropDown.FormattingEnabled = true;
            this.nutrientDropDown.Location = new System.Drawing.Point(165, 65);
            this.nutrientDropDown.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.nutrientDropDown.Name = "nutrientDropDown";
            this.nutrientDropDown.Size = new System.Drawing.Size(248, 38);
            this.nutrientDropDown.TabIndex = 22;
            this.nutrientDropDown.SelectedIndexChanged += new System.EventHandler(this.nutrientDropDown_SelectedIndexChanged);
            // 
            // nutrientLabel
            // 
            this.nutrientLabel.AutoSize = true;
            this.nutrientLabel.Location = new System.Drawing.Point(10, 65);
            this.nutrientLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nutrientLabel.Name = "nutrientLabel";
            this.nutrientLabel.Size = new System.Drawing.Size(152, 30);
            this.nutrientLabel.TabIndex = 21;
            this.nutrientLabel.Text = "Nutrient Name";
            // 
            // createAnalysisButton
            // 
            this.createAnalysisButton.Location = new System.Drawing.Point(445, 571);
            this.createAnalysisButton.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.createAnalysisButton.Name = "createAnalysisButton";
            this.createAnalysisButton.Size = new System.Drawing.Size(194, 53);
            this.createAnalysisButton.TabIndex = 26;
            this.createAnalysisButton.Text = "Create Analysis";
            this.createAnalysisButton.UseVisualStyleBackColor = true;
            this.createAnalysisButton.Click += new System.EventHandler(this.createAnalysisButton_Click);
            // 
            // analysisNameLabel
            // 
            this.analysisNameLabel.AutoSize = true;
            this.analysisNameLabel.Location = new System.Drawing.Point(344, 153);
            this.analysisNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.analysisNameLabel.Name = "analysisNameLabel";
            this.analysisNameLabel.Size = new System.Drawing.Size(150, 30);
            this.analysisNameLabel.TabIndex = 28;
            this.analysisNameLabel.Text = "Analysis Name";
            // 
            // analysisNameValue
            // 
            this.analysisNameValue.Location = new System.Drawing.Point(497, 150);
            this.analysisNameValue.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.analysisNameValue.Name = "analysisNameValue";
            this.analysisNameValue.Size = new System.Drawing.Size(248, 35);
            this.analysisNameValue.TabIndex = 27;
            // 
            // removeSelectedAnalysisNutrientButton
            // 
            this.removeSelectedAnalysisNutrientButton.Location = new System.Drawing.Point(1109, 221);
            this.removeSelectedAnalysisNutrientButton.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.removeSelectedAnalysisNutrientButton.Name = "removeSelectedAnalysisNutrientButton";
            this.removeSelectedAnalysisNutrientButton.Size = new System.Drawing.Size(134, 87);
            this.removeSelectedAnalysisNutrientButton.TabIndex = 29;
            this.removeSelectedAnalysisNutrientButton.Text = "Remove Selected";
            this.removeSelectedAnalysisNutrientButton.UseVisualStyleBackColor = true;
            this.removeSelectedAnalysisNutrientButton.Click += new System.EventHandler(this.removeSelectedAnalysisNutrientButton_Click);
            // 
            // CreateAnalysisForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1256, 670);
            this.Controls.Add(this.removeSelectedAnalysisNutrientButton);
            this.Controls.Add(this.analysisNameLabel);
            this.Controls.Add(this.analysisNameValue);
            this.Controls.Add(this.createAnalysisButton);
            this.Controls.Add(this.analysisNutrientGroupBox);
            this.Controls.Add(this.analysisNutrientListBox);
            this.Controls.Add(this.nutrientsLabel);
            this.Controls.Add(this.productUnitsLabel);
            this.Controls.Add(this.productUnitsValue);
            this.Controls.Add(this.productDropDown);
            this.Controls.Add(this.productLabel);
            this.Controls.Add(this.analysisListBox);
            this.Controls.Add(this.analysisListLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "CreateAnalysisForm";
            this.Text = "CreateAnalysisForm";
            this.analysisNutrientGroupBox.ResumeLayout(false);
            this.analysisNutrientGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox analysisListBox;
        private System.Windows.Forms.Label analysisListLabel;
        private System.Windows.Forms.ComboBox productDropDown;
        private System.Windows.Forms.Label productLabel;
        private System.Windows.Forms.Label productUnitsLabel;
        private System.Windows.Forms.TextBox productUnitsValue;
        private System.Windows.Forms.ListBox analysisNutrientListBox;
        private System.Windows.Forms.Label nutrientsLabel;
        private System.Windows.Forms.GroupBox analysisNutrientGroupBox;
        private System.Windows.Forms.ComboBox nutrientDropDown;
        private System.Windows.Forms.Label nutrientLabel;
        private System.Windows.Forms.Label nutrientAmountLabel;
        private System.Windows.Forms.TextBox nutrientAmountValue;
        private System.Windows.Forms.Label nutrientUnitsLabel;
        private System.Windows.Forms.TextBox nutrientUnitsValue;
        private System.Windows.Forms.Button addNutrientButton;
        private System.Windows.Forms.Button createAnalysisButton;
        private System.Windows.Forms.Label analysisNameLabel;
        private System.Windows.Forms.TextBox analysisNameValue;
        private System.Windows.Forms.Button removeSelectedAnalysisNutrientButton;
    }
}