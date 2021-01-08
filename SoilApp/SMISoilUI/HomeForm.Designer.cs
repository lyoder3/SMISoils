
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
            this.updateMenuButton = new System.Windows.Forms.Button();
            this.deleteMenuButton = new System.Windows.Forms.Button();
            this.createMenuButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // getSoilDataMenuButton
            // 
            this.getSoilDataMenuButton.Location = new System.Drawing.Point(67, 68);
            this.getSoilDataMenuButton.Name = "getSoilDataMenuButton";
            this.getSoilDataMenuButton.Size = new System.Drawing.Size(152, 40);
            this.getSoilDataMenuButton.TabIndex = 1;
            this.getSoilDataMenuButton.Text = "Get Soil Data";
            this.getSoilDataMenuButton.UseVisualStyleBackColor = true;
            // 
            // updateMenuButton
            // 
            this.updateMenuButton.Location = new System.Drawing.Point(67, 124);
            this.updateMenuButton.Name = "updateMenuButton";
            this.updateMenuButton.Size = new System.Drawing.Size(152, 40);
            this.updateMenuButton.TabIndex = 1;
            this.updateMenuButton.Text = "Update";
            this.updateMenuButton.UseVisualStyleBackColor = true;
            // 
            // deleteMenuButton
            // 
            this.deleteMenuButton.Location = new System.Drawing.Point(67, 180);
            this.deleteMenuButton.Name = "deleteMenuButton";
            this.deleteMenuButton.Size = new System.Drawing.Size(152, 40);
            this.deleteMenuButton.TabIndex = 1;
            this.deleteMenuButton.Text = "Delete";
            this.deleteMenuButton.UseVisualStyleBackColor = true;
            // 
            // createMenuButton
            // 
            this.createMenuButton.Location = new System.Drawing.Point(67, 12);
            this.createMenuButton.Name = "createMenuButton";
            this.createMenuButton.Size = new System.Drawing.Size(152, 40);
            this.createMenuButton.TabIndex = 2;
            this.createMenuButton.Text = "Create";
            this.createMenuButton.UseVisualStyleBackColor = true;
            this.createMenuButton.Click += new System.EventHandler(this.createMenuButton_Click);
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(295, 246);
            this.Controls.Add(this.createMenuButton);
            this.Controls.Add(this.deleteMenuButton);
            this.Controls.Add(this.updateMenuButton);
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
        private System.Windows.Forms.Button updateMenuButton;
        private System.Windows.Forms.Button deleteMenuButton;
        private System.Windows.Forms.Button createMenuButton;
    }
}

