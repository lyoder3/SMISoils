
namespace SMISoilUI
{
    partial class CreateNutrientForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateNutrientForm));
            this.nutrientListBox = new System.Windows.Forms.ListBox();
            this.createUnitFormButton = new System.Windows.Forms.Button();
            this.nutrientUnitsDropDown = new System.Windows.Forms.ComboBox();
            this.nutrientUnitsLabel = new System.Windows.Forms.Label();
            this.nutrientNameValue = new System.Windows.Forms.TextBox();
            this.createNutrientButton = new System.Windows.Forms.Button();
            this.nutrientNameLabel = new System.Windows.Forms.Label();
            this.nutrientListLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // nutrientListBox
            // 
            this.nutrientListBox.FormattingEnabled = true;
            this.nutrientListBox.ItemHeight = 30;
            this.nutrientListBox.Location = new System.Drawing.Point(23, 72);
            this.nutrientListBox.Name = "nutrientListBox";
            this.nutrientListBox.Size = new System.Drawing.Size(251, 304);
            this.nutrientListBox.TabIndex = 24;
            // 
            // createUnitFormButton
            // 
            this.createUnitFormButton.Location = new System.Drawing.Point(692, 145);
            this.createUnitFormButton.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.createUnitFormButton.Name = "createUnitFormButton";
            this.createUnitFormButton.Size = new System.Drawing.Size(72, 46);
            this.createUnitFormButton.TabIndex = 23;
            this.createUnitFormButton.Text = "Add";
            this.createUnitFormButton.UseVisualStyleBackColor = true;
            this.createUnitFormButton.Click += new System.EventHandler(this.createUnitFormButton_Click);
            // 
            // nutrientUnitsDropDown
            // 
            this.nutrientUnitsDropDown.FormattingEnabled = true;
            this.nutrientUnitsDropDown.Location = new System.Drawing.Point(436, 150);
            this.nutrientUnitsDropDown.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.nutrientUnitsDropDown.Name = "nutrientUnitsDropDown";
            this.nutrientUnitsDropDown.Size = new System.Drawing.Size(248, 38);
            this.nutrientUnitsDropDown.TabIndex = 22;
            // 
            // nutrientUnitsLabel
            // 
            this.nutrientUnitsLabel.AutoSize = true;
            this.nutrientUnitsLabel.Location = new System.Drawing.Point(290, 153);
            this.nutrientUnitsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nutrientUnitsLabel.Name = "nutrientUnitsLabel";
            this.nutrientUnitsLabel.Size = new System.Drawing.Size(143, 30);
            this.nutrientUnitsLabel.TabIndex = 21;
            this.nutrientUnitsLabel.Text = "Nutrient Units";
            // 
            // nutrientNameValue
            // 
            this.nutrientNameValue.Location = new System.Drawing.Point(436, 83);
            this.nutrientNameValue.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.nutrientNameValue.Name = "nutrientNameValue";
            this.nutrientNameValue.Size = new System.Drawing.Size(248, 35);
            this.nutrientNameValue.TabIndex = 20;
            // 
            // createNutrientButton
            // 
            this.createNutrientButton.Location = new System.Drawing.Point(390, 323);
            this.createNutrientButton.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.createNutrientButton.Name = "createNutrientButton";
            this.createNutrientButton.Size = new System.Drawing.Size(194, 53);
            this.createNutrientButton.TabIndex = 19;
            this.createNutrientButton.Text = "Create Nutrient";
            this.createNutrientButton.UseVisualStyleBackColor = true;
            this.createNutrientButton.Click += new System.EventHandler(this.createNutrientButton_Click);
            // 
            // nutrientNameLabel
            // 
            this.nutrientNameLabel.AutoSize = true;
            this.nutrientNameLabel.Location = new System.Drawing.Point(281, 83);
            this.nutrientNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nutrientNameLabel.Name = "nutrientNameLabel";
            this.nutrientNameLabel.Size = new System.Drawing.Size(152, 30);
            this.nutrientNameLabel.TabIndex = 18;
            this.nutrientNameLabel.Text = "Nutrient Name";
            // 
            // nutrientListLabel
            // 
            this.nutrientListLabel.AutoSize = true;
            this.nutrientListLabel.Location = new System.Drawing.Point(100, 33);
            this.nutrientListLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nutrientListLabel.Name = "nutrientListLabel";
            this.nutrientListLabel.Size = new System.Drawing.Size(84, 30);
            this.nutrientListLabel.TabIndex = 17;
            this.nutrientListLabel.Text = "Existing";
            // 
            // CreateNutrientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 441);
            this.Controls.Add(this.nutrientListBox);
            this.Controls.Add(this.createUnitFormButton);
            this.Controls.Add(this.nutrientUnitsDropDown);
            this.Controls.Add(this.nutrientUnitsLabel);
            this.Controls.Add(this.nutrientNameValue);
            this.Controls.Add(this.createNutrientButton);
            this.Controls.Add(this.nutrientNameLabel);
            this.Controls.Add(this.nutrientListLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "CreateNutrientForm";
            this.Text = "Create Nutrient";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox nutrientListBox;
        private System.Windows.Forms.Button createUnitFormButton;
        private System.Windows.Forms.ComboBox nutrientUnitsDropDown;
        private System.Windows.Forms.Label nutrientUnitsLabel;
        private System.Windows.Forms.TextBox nutrientNameValue;
        private System.Windows.Forms.Button createNutrientButton;
        private System.Windows.Forms.Label nutrientNameLabel;
        private System.Windows.Forms.Label nutrientListLabel;
    }
}