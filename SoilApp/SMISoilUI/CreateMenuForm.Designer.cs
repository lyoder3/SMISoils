
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
            this.masterSheetSyncButton = new System.Windows.Forms.Button();
            this.createMeasuredQuantityFormButton = new System.Windows.Forms.Button();
            this.createSoilSampleFormButton = new System.Windows.Forms.Button();
            this.createAnalysesFormButton = new System.Windows.Forms.Button();
            this.createOperationsFormButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // masterSheetSyncButton
            // 
            this.masterSheetSyncButton.Location = new System.Drawing.Point(89, 12);
            this.masterSheetSyncButton.Name = "masterSheetSyncButton";
            this.masterSheetSyncButton.Size = new System.Drawing.Size(251, 38);
            this.masterSheetSyncButton.TabIndex = 0;
            this.masterSheetSyncButton.Text = "Sync Master Sheet";
            this.masterSheetSyncButton.UseVisualStyleBackColor = true;
            this.masterSheetSyncButton.Click += new System.EventHandler(this.masterSheetSyncButton_Click);
            // 
            // createMeasuredQuantityFormButton
            // 
            this.createMeasuredQuantityFormButton.Location = new System.Drawing.Point(89, 230);
            this.createMeasuredQuantityFormButton.Name = "createMeasuredQuantityFormButton";
            this.createMeasuredQuantityFormButton.Size = new System.Drawing.Size(251, 38);
            this.createMeasuredQuantityFormButton.TabIndex = 0;
            this.createMeasuredQuantityFormButton.Text = "New Product/Nutrient";
            this.createMeasuredQuantityFormButton.UseVisualStyleBackColor = true;
            this.createMeasuredQuantityFormButton.Click += new System.EventHandler(this.createMeasuredQuantityFormButton_Click);
            // 
            // createSoilSampleFormButton
            // 
            this.createSoilSampleFormButton.Location = new System.Drawing.Point(89, 65);
            this.createSoilSampleFormButton.Name = "createSoilSampleFormButton";
            this.createSoilSampleFormButton.Size = new System.Drawing.Size(251, 38);
            this.createSoilSampleFormButton.TabIndex = 0;
            this.createSoilSampleFormButton.Text = "Import Soil Samples";
            this.createSoilSampleFormButton.UseVisualStyleBackColor = true;
            this.createSoilSampleFormButton.Click += new System.EventHandler(this.createSoilSampleFormButton_Click);
            // 
            // createAnalysesFormButton
            // 
            this.createAnalysesFormButton.Location = new System.Drawing.Point(89, 173);
            this.createAnalysesFormButton.Name = "createAnalysesFormButton";
            this.createAnalysesFormButton.Size = new System.Drawing.Size(251, 38);
            this.createAnalysesFormButton.TabIndex = 0;
            this.createAnalysesFormButton.Text = "New Analysis";
            this.createAnalysesFormButton.UseVisualStyleBackColor = true;
            // 
            // createOperationsFormButton
            // 
            this.createOperationsFormButton.Location = new System.Drawing.Point(89, 118);
            this.createOperationsFormButton.Name = "createOperationsFormButton";
            this.createOperationsFormButton.Size = new System.Drawing.Size(251, 38);
            this.createOperationsFormButton.TabIndex = 0;
            this.createOperationsFormButton.Text = "Import Intentions";
            this.createOperationsFormButton.UseVisualStyleBackColor = true;
            // 
            // CreateMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(434, 295);
            this.Controls.Add(this.createOperationsFormButton);
            this.Controls.Add(this.createAnalysesFormButton);
            this.Controls.Add(this.createSoilSampleFormButton);
            this.Controls.Add(this.createMeasuredQuantityFormButton);
            this.Controls.Add(this.masterSheetSyncButton);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "CreateMenuForm";
            this.Text = "Create/Import";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button masterSheetSyncButton;
        private System.Windows.Forms.Button createMeasuredQuantityFormButton;
        private System.Windows.Forms.Button createSoilSampleFormButton;
        private System.Windows.Forms.Button createAnalysesFormButton;
        private System.Windows.Forms.Button createOperationsFormButton;
    }
}