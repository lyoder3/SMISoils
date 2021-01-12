
namespace SMISoilUI
{
    partial class CreateProductForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateProductForm));
            this.createUnitFormButton = new System.Windows.Forms.Button();
            this.productUnitsDropDown = new System.Windows.Forms.ComboBox();
            this.productUnitsLabel = new System.Windows.Forms.Label();
            this.productNameValue = new System.Windows.Forms.TextBox();
            this.createProductButton = new System.Windows.Forms.Button();
            this.productNameLabel = new System.Windows.Forms.Label();
            this.productListLabel = new System.Windows.Forms.Label();
            this.productListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // createUnitFormButton
            // 
            this.createUnitFormButton.Location = new System.Drawing.Point(681, 127);
            this.createUnitFormButton.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.createUnitFormButton.Name = "createUnitFormButton";
            this.createUnitFormButton.Size = new System.Drawing.Size(72, 46);
            this.createUnitFormButton.TabIndex = 15;
            this.createUnitFormButton.Text = "Add";
            this.createUnitFormButton.UseVisualStyleBackColor = true;
            this.createUnitFormButton.Click += new System.EventHandler(this.createUnitFormButton_Click);
            // 
            // productUnitsDropDown
            // 
            this.productUnitsDropDown.FormattingEnabled = true;
            this.productUnitsDropDown.Location = new System.Drawing.Point(425, 132);
            this.productUnitsDropDown.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.productUnitsDropDown.Name = "productUnitsDropDown";
            this.productUnitsDropDown.Size = new System.Drawing.Size(248, 38);
            this.productUnitsDropDown.TabIndex = 14;
            // 
            // productUnitsLabel
            // 
            this.productUnitsLabel.AutoSize = true;
            this.productUnitsLabel.Location = new System.Drawing.Point(287, 135);
            this.productUnitsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.productUnitsLabel.Name = "productUnitsLabel";
            this.productUnitsLabel.Size = new System.Drawing.Size(138, 30);
            this.productUnitsLabel.TabIndex = 13;
            this.productUnitsLabel.Text = "Product Units";
            // 
            // productNameValue
            // 
            this.productNameValue.Location = new System.Drawing.Point(425, 65);
            this.productNameValue.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.productNameValue.Name = "productNameValue";
            this.productNameValue.Size = new System.Drawing.Size(248, 35);
            this.productNameValue.TabIndex = 12;
            // 
            // createProductButton
            // 
            this.createProductButton.Location = new System.Drawing.Point(379, 305);
            this.createProductButton.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.createProductButton.Name = "createProductButton";
            this.createProductButton.Size = new System.Drawing.Size(194, 53);
            this.createProductButton.TabIndex = 11;
            this.createProductButton.Text = "Create Product";
            this.createProductButton.UseVisualStyleBackColor = true;
            this.createProductButton.Click += new System.EventHandler(this.createProductButton_Click);
            // 
            // productNameLabel
            // 
            this.productNameLabel.AutoSize = true;
            this.productNameLabel.Location = new System.Drawing.Point(270, 65);
            this.productNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.productNameLabel.Name = "productNameLabel";
            this.productNameLabel.Size = new System.Drawing.Size(147, 30);
            this.productNameLabel.TabIndex = 10;
            this.productNameLabel.Text = "Product Name";
            // 
            // productListLabel
            // 
            this.productListLabel.AutoSize = true;
            this.productListLabel.Location = new System.Drawing.Point(89, 15);
            this.productListLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.productListLabel.Name = "productListLabel";
            this.productListLabel.Size = new System.Drawing.Size(84, 30);
            this.productListLabel.TabIndex = 9;
            this.productListLabel.Text = "Existing";
            // 
            // productListBox
            // 
            this.productListBox.FormattingEnabled = true;
            this.productListBox.ItemHeight = 30;
            this.productListBox.Location = new System.Drawing.Point(12, 54);
            this.productListBox.Name = "productListBox";
            this.productListBox.Size = new System.Drawing.Size(251, 304);
            this.productListBox.TabIndex = 16;
            // 
            // CreateProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(794, 397);
            this.Controls.Add(this.productListBox);
            this.Controls.Add(this.createUnitFormButton);
            this.Controls.Add(this.productUnitsDropDown);
            this.Controls.Add(this.productUnitsLabel);
            this.Controls.Add(this.productNameValue);
            this.Controls.Add(this.createProductButton);
            this.Controls.Add(this.productNameLabel);
            this.Controls.Add(this.productListLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "CreateProductForm";
            this.Text = "Create Product";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button createUnitFormButton;
        private System.Windows.Forms.ComboBox productUnitsDropDown;
        private System.Windows.Forms.Label productUnitsLabel;
        private System.Windows.Forms.TextBox productNameValue;
        private System.Windows.Forms.Button createProductButton;
        private System.Windows.Forms.Label productNameLabel;
        private System.Windows.Forms.Label productListLabel;
        private System.Windows.Forms.ListBox productListBox;
    }
}