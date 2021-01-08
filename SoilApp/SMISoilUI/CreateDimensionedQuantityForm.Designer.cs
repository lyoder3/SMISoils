
namespace SMISoilUI
{
    partial class CreateDimensionedQuantityForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateDimensionedQuantityForm));
            this.createUnitFormButton = new System.Windows.Forms.Button();
            this.itemUnitsDropDown = new System.Windows.Forms.ComboBox();
            this.itemUnitsLabel = new System.Windows.Forms.Label();
            this.quantityNameValue = new System.Windows.Forms.TextBox();
            this.createItemButton = new System.Windows.Forms.Button();
            this.itemNameLabel = new System.Windows.Forms.Label();
            this.measuredQuantityListLabel = new System.Windows.Forms.Label();
            this.quantityTypeLabel = new System.Windows.Forms.Label();
            this.selectedTypeDropDown = new System.Windows.Forms.ComboBox();
            this.measuredQuantityListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // createUnitFormButton
            // 
            this.createUnitFormButton.Location = new System.Drawing.Point(653, 175);
            this.createUnitFormButton.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.createUnitFormButton.Name = "createUnitFormButton";
            this.createUnitFormButton.Size = new System.Drawing.Size(72, 46);
            this.createUnitFormButton.TabIndex = 15;
            this.createUnitFormButton.Text = "Add";
            this.createUnitFormButton.UseVisualStyleBackColor = true;
            this.createUnitFormButton.Click += new System.EventHandler(this.createUnitFormButton_Click);
            // 
            // itemUnitsDropDown
            // 
            this.itemUnitsDropDown.FormattingEnabled = true;
            this.itemUnitsDropDown.Location = new System.Drawing.Point(395, 180);
            this.itemUnitsDropDown.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.itemUnitsDropDown.Name = "itemUnitsDropDown";
            this.itemUnitsDropDown.Size = new System.Drawing.Size(248, 38);
            this.itemUnitsDropDown.TabIndex = 14;
            // 
            // itemUnitsLabel
            // 
            this.itemUnitsLabel.AutoSize = true;
            this.itemUnitsLabel.Location = new System.Drawing.Point(270, 183);
            this.itemUnitsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.itemUnitsLabel.Name = "itemUnitsLabel";
            this.itemUnitsLabel.Size = new System.Drawing.Size(108, 30);
            this.itemUnitsLabel.TabIndex = 13;
            this.itemUnitsLabel.Text = "Item Units";
            // 
            // quantityNameValue
            // 
            this.quantityNameValue.Location = new System.Drawing.Point(395, 115);
            this.quantityNameValue.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.quantityNameValue.Name = "quantityNameValue";
            this.quantityNameValue.Size = new System.Drawing.Size(248, 35);
            this.quantityNameValue.TabIndex = 12;
            // 
            // createItemButton
            // 
            this.createItemButton.Location = new System.Drawing.Point(377, 263);
            this.createItemButton.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.createItemButton.Name = "createItemButton";
            this.createItemButton.Size = new System.Drawing.Size(194, 53);
            this.createItemButton.TabIndex = 11;
            this.createItemButton.Text = "Create Item";
            this.createItemButton.UseVisualStyleBackColor = true;
            this.createItemButton.Click += new System.EventHandler(this.createItemButton_Click);
            // 
            // itemNameLabel
            // 
            this.itemNameLabel.AutoSize = true;
            this.itemNameLabel.Location = new System.Drawing.Point(270, 118);
            this.itemNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.itemNameLabel.Name = "itemNameLabel";
            this.itemNameLabel.Size = new System.Drawing.Size(117, 30);
            this.itemNameLabel.TabIndex = 10;
            this.itemNameLabel.Text = "Item Name";
            // 
            // measuredQuantityListLabel
            // 
            this.measuredQuantityListLabel.AutoSize = true;
            this.measuredQuantityListLabel.Location = new System.Drawing.Point(89, 15);
            this.measuredQuantityListLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.measuredQuantityListLabel.Name = "measuredQuantityListLabel";
            this.measuredQuantityListLabel.Size = new System.Drawing.Size(84, 30);
            this.measuredQuantityListLabel.TabIndex = 9;
            this.measuredQuantityListLabel.Text = "Existing";
            // 
            // quantityTypeLabel
            // 
            this.quantityTypeLabel.AutoSize = true;
            this.quantityTypeLabel.Location = new System.Drawing.Point(322, 57);
            this.quantityTypeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.quantityTypeLabel.Name = "quantityTypeLabel";
            this.quantityTypeLabel.Size = new System.Drawing.Size(56, 30);
            this.quantityTypeLabel.TabIndex = 10;
            this.quantityTypeLabel.Text = "Type";
            // 
            // selectedTypeDropDown
            // 
            this.selectedTypeDropDown.FormattingEnabled = true;
            this.selectedTypeDropDown.Location = new System.Drawing.Point(395, 54);
            this.selectedTypeDropDown.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.selectedTypeDropDown.Name = "selectedTypeDropDown";
            this.selectedTypeDropDown.Size = new System.Drawing.Size(248, 38);
            this.selectedTypeDropDown.TabIndex = 14;
            this.selectedTypeDropDown.SelectedIndexChanged += new System.EventHandler(this.selectedTypeDropDown_SelectedIndexChanged);
            // 
            // measuredQuantityListBox
            // 
            this.measuredQuantityListBox.FormattingEnabled = true;
            this.measuredQuantityListBox.ItemHeight = 30;
            this.measuredQuantityListBox.Location = new System.Drawing.Point(12, 54);
            this.measuredQuantityListBox.Name = "measuredQuantityListBox";
            this.measuredQuantityListBox.Size = new System.Drawing.Size(251, 304);
            this.measuredQuantityListBox.TabIndex = 16;
            // 
            // CreateDimensionedQuantityForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(744, 397);
            this.Controls.Add(this.measuredQuantityListBox);
            this.Controls.Add(this.createUnitFormButton);
            this.Controls.Add(this.selectedTypeDropDown);
            this.Controls.Add(this.itemUnitsDropDown);
            this.Controls.Add(this.itemUnitsLabel);
            this.Controls.Add(this.quantityNameValue);
            this.Controls.Add(this.createItemButton);
            this.Controls.Add(this.quantityTypeLabel);
            this.Controls.Add(this.itemNameLabel);
            this.Controls.Add(this.measuredQuantityListLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "CreateDimensionedQuantityForm";
            this.Text = "Create Nutrient/Product";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button createUnitFormButton;
        private System.Windows.Forms.ComboBox itemUnitsDropDown;
        private System.Windows.Forms.Label itemUnitsLabel;
        private System.Windows.Forms.TextBox quantityNameValue;
        private System.Windows.Forms.Button createItemButton;
        private System.Windows.Forms.Label itemNameLabel;
        private System.Windows.Forms.Label measuredQuantityListLabel;
        private System.Windows.Forms.Label quantityTypeLabel;
        private System.Windows.Forms.ComboBox selectedTypeDropDown;
        private System.Windows.Forms.ListBox measuredQuantityListBox;
    }
}