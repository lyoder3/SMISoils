
namespace SMISoilUI
{
    partial class CreateUnitForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateUnitForm));
            this.unitLabel = new System.Windows.Forms.Label();
            this.unitValue = new System.Windows.Forms.TextBox();
            this.createUnitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // unitLabel
            // 
            this.unitLabel.AutoSize = true;
            this.unitLabel.Location = new System.Drawing.Point(33, 25);
            this.unitLabel.Name = "unitLabel";
            this.unitLabel.Size = new System.Drawing.Size(51, 30);
            this.unitLabel.TabIndex = 0;
            this.unitLabel.Text = "Unit";
            // 
            // unitValue
            // 
            this.unitValue.Location = new System.Drawing.Point(107, 22);
            this.unitValue.Name = "unitValue";
            this.unitValue.Size = new System.Drawing.Size(178, 35);
            this.unitValue.TabIndex = 1;
            // 
            // createUnitButton
            // 
            this.createUnitButton.Location = new System.Drawing.Point(78, 83);
            this.createUnitButton.Name = "createUnitButton";
            this.createUnitButton.Size = new System.Drawing.Size(146, 43);
            this.createUnitButton.TabIndex = 2;
            this.createUnitButton.Text = "Create Unit";
            this.createUnitButton.UseVisualStyleBackColor = true;
            this.createUnitButton.Click += new System.EventHandler(this.createUnitButton_Click);
            // 
            // CreateUnitForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(310, 159);
            this.Controls.Add(this.createUnitButton);
            this.Controls.Add(this.unitValue);
            this.Controls.Add(this.unitLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "CreateUnitForm";
            this.Text = "Create Unit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label unitLabel;
        private System.Windows.Forms.TextBox unitValue;
        private System.Windows.Forms.Button createUnitButton;
    }
}