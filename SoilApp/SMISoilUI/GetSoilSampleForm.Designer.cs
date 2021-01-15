
namespace SMISoilUI
{
    partial class CreateSoilSampleIntentionsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateSoilSampleIntentionsForm));
            this.filtersGroupBox = new System.Windows.Forms.GroupBox();
            this.yearValue = new System.Windows.Forms.TextBox();
            this.cropLabel = new System.Windows.Forms.Label();
            this.cropDropDown = new System.Windows.Forms.ComboBox();
            this.yearLabel = new System.Windows.Forms.Label();
            this.generateSoilDataButton = new System.Windows.Forms.Button();
            this.lastSampledLabel = new System.Windows.Forms.Label();
            this.lastSampledYearValue = new System.Windows.Forms.TextBox();
            this.folderBrowserBox = new System.Windows.Forms.FolderBrowserDialog();
            this.filtersGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // filtersGroupBox
            // 
            this.filtersGroupBox.Controls.Add(this.lastSampledYearValue);
            this.filtersGroupBox.Controls.Add(this.yearValue);
            this.filtersGroupBox.Controls.Add(this.cropLabel);
            this.filtersGroupBox.Controls.Add(this.lastSampledLabel);
            this.filtersGroupBox.Controls.Add(this.cropDropDown);
            this.filtersGroupBox.Controls.Add(this.yearLabel);
            this.filtersGroupBox.Location = new System.Drawing.Point(35, 53);
            this.filtersGroupBox.Name = "filtersGroupBox";
            this.filtersGroupBox.Size = new System.Drawing.Size(416, 212);
            this.filtersGroupBox.TabIndex = 1;
            this.filtersGroupBox.TabStop = false;
            this.filtersGroupBox.Text = "Filters";
            // 
            // yearValue
            // 
            this.yearValue.Location = new System.Drawing.Point(192, 39);
            this.yearValue.Name = "yearValue";
            this.yearValue.Size = new System.Drawing.Size(208, 35);
            this.yearValue.TabIndex = 10;
            // 
            // cropLabel
            // 
            this.cropLabel.AutoSize = true;
            this.cropLabel.Location = new System.Drawing.Point(6, 151);
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
            this.cropDropDown.Location = new System.Drawing.Point(192, 151);
            this.cropDropDown.Name = "cropDropDown";
            this.cropDropDown.Size = new System.Drawing.Size(208, 38);
            this.cropDropDown.TabIndex = 6;
            // 
            // yearLabel
            // 
            this.yearLabel.AutoSize = true;
            this.yearLabel.Location = new System.Drawing.Point(6, 42);
            this.yearLabel.Name = "yearLabel";
            this.yearLabel.Size = new System.Drawing.Size(136, 30);
            this.yearLabel.TabIndex = 5;
            this.yearLabel.Text = "Rotation Year";
            // 
            // generateSoilDataButton
            // 
            this.generateSoilDataButton.Location = new System.Drawing.Point(517, 126);
            this.generateSoilDataButton.Name = "generateSoilDataButton";
            this.generateSoilDataButton.Size = new System.Drawing.Size(122, 65);
            this.generateSoilDataButton.TabIndex = 2;
            this.generateSoilDataButton.Text = "Generate";
            this.generateSoilDataButton.UseVisualStyleBackColor = true;
            this.generateSoilDataButton.Click += new System.EventHandler(this.generateSoilDataButton_Click);
            // 
            // lastSampledLabel
            // 
            this.lastSampledLabel.AutoSize = true;
            this.lastSampledLabel.Location = new System.Drawing.Point(5, 100);
            this.lastSampledLabel.Name = "lastSampledLabel";
            this.lastSampledLabel.Size = new System.Drawing.Size(181, 30);
            this.lastSampledLabel.TabIndex = 5;
            this.lastSampledLabel.Text = "Last Sampled Year";
            // 
            // lastSampledYearValue
            // 
            this.lastSampledYearValue.Location = new System.Drawing.Point(192, 97);
            this.lastSampledYearValue.Name = "lastSampledYearValue";
            this.lastSampledYearValue.Size = new System.Drawing.Size(208, 35);
            this.lastSampledYearValue.TabIndex = 10;
            // 
            // CreateSoilSampleIntentionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(675, 358);
            this.Controls.Add(this.generateSoilDataButton);
            this.Controls.Add(this.filtersGroupBox);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "CreateSoilSampleIntentionsForm";
            this.Text = "Get Soil Sample Intentions";
            this.filtersGroupBox.ResumeLayout(false);
            this.filtersGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox filtersGroupBox;
        private System.Windows.Forms.TextBox yearValue;
        private System.Windows.Forms.Label cropLabel;
        private System.Windows.Forms.ComboBox cropDropDown;
        private System.Windows.Forms.Label yearLabel;
        private System.Windows.Forms.Button generateSoilDataButton;
        private System.Windows.Forms.TextBox lastSampledYearValue;
        private System.Windows.Forms.Label lastSampledLabel;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserBox;
    }
}