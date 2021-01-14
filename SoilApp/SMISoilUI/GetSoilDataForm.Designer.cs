
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
            this.farmNameLabel = new System.Windows.Forms.Label();
            this.farmDropDown = new System.Windows.Forms.ComboBox();
            this.generateSoilDataButton = new System.Windows.Forms.Button();
            this.fieldLabel = new System.Windows.Forms.Label();
            this.fieldDropDown = new System.Windows.Forms.ComboBox();
            this.yearLabel = new System.Windows.Forms.Label();
            this.yearDropDown = new System.Windows.Forms.ComboBox();
            this.cropLabel = new System.Windows.Forms.Label();
            this.cropDropDown = new System.Windows.Forms.ComboBox();
            this.filtersGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // filtersGroupBox
            // 
            this.filtersGroupBox.Controls.Add(this.cropLabel);
            this.filtersGroupBox.Controls.Add(this.cropDropDown);
            this.filtersGroupBox.Controls.Add(this.yearLabel);
            this.filtersGroupBox.Controls.Add(this.yearDropDown);
            this.filtersGroupBox.Controls.Add(this.fieldLabel);
            this.filtersGroupBox.Controls.Add(this.fieldDropDown);
            this.filtersGroupBox.Controls.Add(this.farmNameLabel);
            this.filtersGroupBox.Controls.Add(this.farmDropDown);
            this.filtersGroupBox.Location = new System.Drawing.Point(22, 51);
            this.filtersGroupBox.Name = "filtersGroupBox";
            this.filtersGroupBox.Size = new System.Drawing.Size(416, 316);
            this.filtersGroupBox.TabIndex = 0;
            this.filtersGroupBox.TabStop = false;
            this.filtersGroupBox.Text = "Filters";
            // 
            // farmNameLabel
            // 
            this.farmNameLabel.AutoSize = true;
            this.farmNameLabel.Location = new System.Drawing.Point(17, 61);
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
            this.farmDropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.farmDropDown.FormattingEnabled = true;
            this.farmDropDown.Location = new System.Drawing.Point(123, 58);
            this.farmDropDown.Name = "farmDropDown";
            this.farmDropDown.Size = new System.Drawing.Size(274, 38);
            this.farmDropDown.TabIndex = 0;
            // 
            // generateSoilDataButton
            // 
            this.generateSoilDataButton.Location = new System.Drawing.Point(465, 196);
            this.generateSoilDataButton.Name = "generateSoilDataButton";
            this.generateSoilDataButton.Size = new System.Drawing.Size(122, 65);
            this.generateSoilDataButton.TabIndex = 1;
            this.generateSoilDataButton.Text = "Generate";
            this.generateSoilDataButton.UseVisualStyleBackColor = true;
            // 
            // fieldLabel
            // 
            this.fieldLabel.AutoSize = true;
            this.fieldLabel.Location = new System.Drawing.Point(17, 120);
            this.fieldLabel.Name = "fieldLabel";
            this.fieldLabel.Size = new System.Drawing.Size(56, 30);
            this.fieldLabel.TabIndex = 3;
            this.fieldLabel.Text = "Field";
            // 
            // fieldDropDown
            // 
            this.fieldDropDown.AllowDrop = true;
            this.fieldDropDown.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.fieldDropDown.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.fieldDropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.fieldDropDown.FormattingEnabled = true;
            this.fieldDropDown.Location = new System.Drawing.Point(123, 117);
            this.fieldDropDown.Name = "fieldDropDown";
            this.fieldDropDown.Size = new System.Drawing.Size(274, 38);
            this.fieldDropDown.TabIndex = 2;
            // 
            // yearLabel
            // 
            this.yearLabel.AutoSize = true;
            this.yearLabel.Location = new System.Drawing.Point(17, 180);
            this.yearLabel.Name = "yearLabel";
            this.yearLabel.Size = new System.Drawing.Size(52, 30);
            this.yearLabel.TabIndex = 5;
            this.yearLabel.Text = "Year";
            // 
            // yearDropDown
            // 
            this.yearDropDown.AllowDrop = true;
            this.yearDropDown.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.yearDropDown.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.yearDropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.yearDropDown.FormattingEnabled = true;
            this.yearDropDown.Location = new System.Drawing.Point(123, 177);
            this.yearDropDown.Name = "yearDropDown";
            this.yearDropDown.Size = new System.Drawing.Size(274, 38);
            this.yearDropDown.TabIndex = 4;
            // 
            // cropLabel
            // 
            this.cropLabel.AutoSize = true;
            this.cropLabel.Location = new System.Drawing.Point(17, 243);
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
            this.cropDropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cropDropDown.FormattingEnabled = true;
            this.cropDropDown.Location = new System.Drawing.Point(123, 240);
            this.cropDropDown.Name = "cropDropDown";
            this.cropDropDown.Size = new System.Drawing.Size(274, 38);
            this.cropDropDown.TabIndex = 6;
            // 
            // GetSoilDataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(608, 450);
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
        private System.Windows.Forms.Label fieldLabel;
        private System.Windows.Forms.ComboBox fieldDropDown;
        private System.Windows.Forms.Label cropLabel;
        private System.Windows.Forms.ComboBox cropDropDown;
        private System.Windows.Forms.Label yearLabel;
        private System.Windows.Forms.ComboBox yearDropDown;
    }
}