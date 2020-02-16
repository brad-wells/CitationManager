namespace AsgDThirdTry
{
    partial class Edit
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
            this.CitationIdTextBox = new System.Windows.Forms.TextBox();
            this.CitationLicenseTextBox = new System.Windows.Forms.TextBox();
            this.CitationVehicleTextBox = new System.Windows.Forms.TextBox();
            this.CitationCommentsTextBox = new System.Windows.Forms.TextBox();
            this.EditButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CitationIdTextBox
            // 
            this.CitationIdTextBox.Location = new System.Drawing.Point(148, 58);
            this.CitationIdTextBox.Name = "CitationIdTextBox";
            this.CitationIdTextBox.Size = new System.Drawing.Size(100, 20);
            this.CitationIdTextBox.TabIndex = 0;
            // 
            // CitationLicenseTextBox
            // 
            this.CitationLicenseTextBox.Location = new System.Drawing.Point(148, 115);
            this.CitationLicenseTextBox.Name = "CitationLicenseTextBox";
            this.CitationLicenseTextBox.Size = new System.Drawing.Size(100, 20);
            this.CitationLicenseTextBox.TabIndex = 1;
            // 
            // CitationVehicleTextBox
            // 
            this.CitationVehicleTextBox.Location = new System.Drawing.Point(148, 168);
            this.CitationVehicleTextBox.Name = "CitationVehicleTextBox";
            this.CitationVehicleTextBox.Size = new System.Drawing.Size(100, 20);
            this.CitationVehicleTextBox.TabIndex = 2;
            // 
            // CitationCommentsTextBox
            // 
            this.CitationCommentsTextBox.Location = new System.Drawing.Point(148, 209);
            this.CitationCommentsTextBox.Name = "CitationCommentsTextBox";
            this.CitationCommentsTextBox.Size = new System.Drawing.Size(100, 20);
            this.CitationCommentsTextBox.TabIndex = 3;
            // 
            // EditButton
            // 
            this.EditButton.Location = new System.Drawing.Point(172, 266);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(75, 23);
            this.EditButton.TabIndex = 4;
            this.EditButton.Text = "Edit";
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // Edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.CitationCommentsTextBox);
            this.Controls.Add(this.CitationVehicleTextBox);
            this.Controls.Add(this.CitationLicenseTextBox);
            this.Controls.Add(this.CitationIdTextBox);
            this.Name = "Edit";
            this.Text = "Edit";
            this.Load += new System.EventHandler(this.Edit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox CitationIdTextBox;
        private System.Windows.Forms.TextBox CitationLicenseTextBox;
        private System.Windows.Forms.TextBox CitationVehicleTextBox;
        private System.Windows.Forms.TextBox CitationCommentsTextBox;
        private System.Windows.Forms.Button EditButton;
    }
}