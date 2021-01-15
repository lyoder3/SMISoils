
namespace SMISoilUI
{
    partial class HomeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeForm));
            this.getSoilDataMenuButton = new System.Windows.Forms.Button();
            this.createMenuButton = new System.Windows.Forms.Button();
            this.getSoilSampleDataButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // getSoilDataMenuButton
            // 
            this.getSoilDataMenuButton.Location = new System.Drawing.Point(67, 104);
            this.getSoilDataMenuButton.Name = "getSoilDataMenuButton";
            this.getSoilDataMenuButton.Size = new System.Drawing.Size(152, 71);
            this.getSoilDataMenuButton.TabIndex = 1;
            this.getSoilDataMenuButton.Text = "Get Soil Data";
            this.getSoilDataMenuButton.UseVisualStyleBackColor = true;
            this.getSoilDataMenuButton.Click += new System.EventHandler(this.getSoilDataMenuButton_Click);
            // 
            // createMenuButton
            // 
            this.createMenuButton.Location = new System.Drawing.Point(67, 12);
            this.createMenuButton.Name = "createMenuButton";
            this.createMenuButton.Size = new System.Drawing.Size(152, 71);
            this.createMenuButton.TabIndex = 2;
            this.createMenuButton.Text = "Create";
            this.createMenuButton.UseVisualStyleBackColor = true;
            this.createMenuButton.Click += new System.EventHandler(this.createMenuButton_Click);
            // 
            // getSoilSampleDataButton
            // 
            this.getSoilSampleDataButton.Location = new System.Drawing.Point(67, 201);
            this.getSoilSampleDataButton.Name = "getSoilSampleDataButton";
            this.getSoilSampleDataButton.Size = new System.Drawing.Size(152, 71);
            this.getSoilSampleDataButton.TabIndex = 1;
            this.getSoilSampleDataButton.Text = "Generate Sample Sheets";
            this.getSoilSampleDataButton.UseVisualStyleBackColor = true;
            this.getSoilSampleDataButton.Click += new System.EventHandler(this.getSoilSampleDataButton_Click);
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(297, 303);
            this.Controls.Add(this.createMenuButton);
            this.Controls.Add(this.getSoilSampleDataButton);
            this.Controls.Add(this.getSoilDataMenuButton);
            this.Font = new System.Drawing.Font("Segoe UI", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "HomeForm";
            this.Text = "SMI Soils";
            this.Load += new System.EventHandler(this.Home_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button getSoilDataMenuButton;
        private System.Windows.Forms.Button createMenuButton;
        private System.Windows.Forms.Button getSoilSampleDataButton;
    }
}

