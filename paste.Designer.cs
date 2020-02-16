namespace AsgDThirdTry
{
    partial class paste
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
            this.OfficerButton = new System.Windows.Forms.Button();
            this.OffenseButton = new System.Windows.Forms.Button();
            this.OfficerLastNameLabel = new System.Windows.Forms.Label();
            this.OfficerLastNameTextBox = new System.Windows.Forms.TextBox();
            this.OfficerFNameLabel = new System.Windows.Forms.Label();
            this.OfficerFirstNameTextBox = new System.Windows.Forms.TextBox();
            this.OfficerIdTextBox = new System.Windows.Forms.TextBox();
            this.citationList = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // OfficerButton
            // 
            this.OfficerButton.Location = new System.Drawing.Point(471, 418);
            this.OfficerButton.Name = "OfficerButton";
            this.OfficerButton.Size = new System.Drawing.Size(75, 23);
            this.OfficerButton.TabIndex = 68;
            this.OfficerButton.Text = "Officer";
            this.OfficerButton.UseVisualStyleBackColor = true;
            // 
            // OffenseButton
            // 
            this.OffenseButton.Location = new System.Drawing.Point(471, 392);
            this.OffenseButton.Name = "OffenseButton";
            this.OffenseButton.Size = new System.Drawing.Size(75, 23);
            this.OffenseButton.TabIndex = 67;
            this.OffenseButton.Text = "Offense";
            this.OffenseButton.UseVisualStyleBackColor = true;
            // 
            // OfficerLastNameLabel
            // 
            this.OfficerLastNameLabel.AutoSize = true;
            this.OfficerLastNameLabel.Location = new System.Drawing.Point(259, 428);
            this.OfficerLastNameLabel.Name = "OfficerLastNameLabel";
            this.OfficerLastNameLabel.Size = new System.Drawing.Size(98, 13);
            this.OfficerLastNameLabel.TabIndex = 66;
            this.OfficerLastNameLabel.Text = "Officer Last  Name:";
            // 
            // OfficerLastNameTextBox
            // 
            this.OfficerLastNameTextBox.Location = new System.Drawing.Point(365, 425);
            this.OfficerLastNameTextBox.Name = "OfficerLastNameTextBox";
            this.OfficerLastNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.OfficerLastNameTextBox.TabIndex = 65;
            // 
            // OfficerFNameLabel
            // 
            this.OfficerFNameLabel.AutoSize = true;
            this.OfficerFNameLabel.Location = new System.Drawing.Point(259, 395);
            this.OfficerFNameLabel.Name = "OfficerFNameLabel";
            this.OfficerFNameLabel.Size = new System.Drawing.Size(94, 13);
            this.OfficerFNameLabel.TabIndex = 64;
            this.OfficerFNameLabel.Text = "Officer First Name:";
            // 
            // OfficerFirstNameTextBox
            // 
            this.OfficerFirstNameTextBox.Location = new System.Drawing.Point(365, 392);
            this.OfficerFirstNameTextBox.Name = "OfficerFirstNameTextBox";
            this.OfficerFirstNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.OfficerFirstNameTextBox.TabIndex = 63;
            // 
            // OfficerIdTextBox
            // 
            this.OfficerIdTextBox.Location = new System.Drawing.Point(259, 413);
            this.OfficerIdTextBox.Name = "OfficerIdTextBox";
            this.OfficerIdTextBox.Size = new System.Drawing.Size(100, 20);
            this.OfficerIdTextBox.TabIndex = 62;
            // 
            // citationList
            // 
            this.citationList.FormattingEnabled = true;
            this.citationList.Location = new System.Drawing.Point(255, 5);
            this.citationList.Name = "citationList";
            this.citationList.Size = new System.Drawing.Size(291, 381);
            this.citationList.TabIndex = 61;
            // 
            // paste
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.OfficerButton);
            this.Controls.Add(this.OffenseButton);
            this.Controls.Add(this.OfficerLastNameLabel);
            this.Controls.Add(this.OfficerLastNameTextBox);
            this.Controls.Add(this.OfficerFNameLabel);
            this.Controls.Add(this.OfficerFirstNameTextBox);
            this.Controls.Add(this.OfficerIdTextBox);
            this.Controls.Add(this.citationList);
            this.Name = "paste";
            this.Text = "paste";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OfficerButton;
        private System.Windows.Forms.Button OffenseButton;
        private System.Windows.Forms.Label OfficerLastNameLabel;
        private System.Windows.Forms.TextBox OfficerLastNameTextBox;
        private System.Windows.Forms.Label OfficerFNameLabel;
        private System.Windows.Forms.TextBox OfficerFirstNameTextBox;
        private System.Windows.Forms.TextBox OfficerIdTextBox;
        private System.Windows.Forms.ListBox citationList;
    }
}