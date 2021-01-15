
namespace SMISoilUI
{
    partial class CreateMenuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateMenuForm));
            this.updateMasterSheetButton = new System.Windows.Forms.Button();
            this.updateProductsButton = new System.Windows.Forms.Button();
            this.createSoilSampleFormButton = new System.Windows.Forms.Button();
            this.updateAnalysesButton = new System.Windows.Forms.Button();
            this.importIntentionsButton = new System.Windows.Forms.Button();
            this.updateNutrientsButton = new System.Windows.Forms.Button();
            this.updateUnitsButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // updateMasterSheetButton
            // 
            this.updateMasterSheetButton.Location = new System.Drawing.Point(47, 348);
            this.updateMasterSheetButton.Name = "updateMasterSheetButton";
            this.updateMasterSheetButton.Size = new System.Drawing.Size(278, 38);
            this.updateMasterSheetButton.TabIndex = 0;
            this.updateMasterSheetButton.Text = "Update Fields and Rotation";
            this.updateMasterSheetButton.UseVisualStyleBackColor = true;
            this.updateMasterSheetButton.Click += new System.EventHandler(this.updateMasterSheetButton_Click);
            // 
            // updateProductsButton
            // 
            this.updateProductsButton.Location = new System.Drawing.Point(46, 138);
            this.updateProductsButton.Name = "updateProductsButton";
            this.updateProductsButton.Size = new System.Drawing.Size(278, 38);
            this.updateProductsButton.TabIndex = 0;
            this.updateProductsButton.Text = "Update Products";
            this.updateProductsButton.UseVisualStyleBackColor = true;
            this.updateProductsButton.Click += new System.EventHandler(this.updateProductsButton_Click);
            // 
            // createSoilSampleFormButton
            // 
            this.createSoilSampleFormButton.Location = new System.Drawing.Point(46, 295);
            this.createSoilSampleFormButton.Name = "createSoilSampleFormButton";
            this.createSoilSampleFormButton.Size = new System.Drawing.Size(277, 38);
            this.createSoilSampleFormButton.TabIndex = 0;
            this.createSoilSampleFormButton.Text = "Import Soil Samples";
            this.createSoilSampleFormButton.UseVisualStyleBackColor = true;
            this.createSoilSampleFormButton.Click += new System.EventHandler(this.createSoilSampleFormButton_Click);
            // 
            // updateAnalysesButton
            // 
            this.updateAnalysesButton.Location = new System.Drawing.Point(46, 194);
            this.updateAnalysesButton.Name = "updateAnalysesButton";
            this.updateAnalysesButton.Size = new System.Drawing.Size(278, 38);
            this.updateAnalysesButton.TabIndex = 0;
            this.updateAnalysesButton.Text = "Update Analyses";
            this.updateAnalysesButton.UseVisualStyleBackColor = true;
            this.updateAnalysesButton.Click += new System.EventHandler(this.createAnalysesFormButton_Click);
            // 
            // importIntentionsButton
            // 
            this.importIntentionsButton.Location = new System.Drawing.Point(46, 243);
            this.importIntentionsButton.Name = "importIntentionsButton";
            this.importIntentionsButton.Size = new System.Drawing.Size(277, 38);
            this.importIntentionsButton.TabIndex = 0;
            this.importIntentionsButton.Text = "Import Intentions";
            this.importIntentionsButton.UseVisualStyleBackColor = true;
            this.importIntentionsButton.Click += new System.EventHandler(this.importIntentionsButton_Click);
            // 
            // updateNutrientsButton
            // 
            this.updateNutrientsButton.Location = new System.Drawing.Point(46, 82);
            this.updateNutrientsButton.Name = "updateNutrientsButton";
            this.updateNutrientsButton.Size = new System.Drawing.Size(278, 38);
            this.updateNutrientsButton.TabIndex = 1;
            this.updateNutrientsButton.Text = "Update Nutrients";
            this.updateNutrientsButton.UseVisualStyleBackColor = true;
            this.updateNutrientsButton.Click += new System.EventHandler(this.updateNutrientsButton_Click);
            // 
            // updateUnitsButton
            // 
            this.updateUnitsButton.Location = new System.Drawing.Point(47, 28);
            this.updateUnitsButton.Name = "updateUnitsButton";
            this.updateUnitsButton.Size = new System.Drawing.Size(278, 38);
            this.updateUnitsButton.TabIndex = 1;
            this.updateUnitsButton.Text = "Update Units";
            this.updateUnitsButton.UseVisualStyleBackColor = true;
            this.updateUnitsButton.Click += new System.EventHandler(this.updateUnitsButton_Click);
            // 
            // CreateMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(23F, 57F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(384, 410);
            this.Controls.Add(this.updateUnitsButton);
            this.Controls.Add(this.updateNutrientsButton);
            this.Controls.Add(this.importIntentionsButton);
            this.Controls.Add(this.updateAnalysesButton);
            this.Controls.Add(this.createSoilSampleFormButton);
            this.Controls.Add(this.updateProductsButton);
            this.Controls.Add(this.updateMasterSheetButton);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "CreateMenuForm";
            this.Text = "Create/Import";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button updateMasterSheetButton;
        private System.Windows.Forms.Button updateProductsButton;
        private System.Windows.Forms.Button createSoilSampleFormButton;
        private System.Windows.Forms.Button updateAnalysesButton;
        private System.Windows.Forms.Button importIntentionsButton;
        private System.Windows.Forms.Button updateNutrientsButton;
        private System.Windows.Forms.Button updateUnitsButton;
    }
}