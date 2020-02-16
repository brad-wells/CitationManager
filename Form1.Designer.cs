namespace AsgDThirdTry
{
    partial class Form1
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
            this.citationComboBox = new System.Windows.Forms.ComboBox();
            this.addCitationButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.LicensePlateTextBox = new System.Windows.Forms.TextBox();
            this.VehicleTextBox = new System.Windows.Forms.TextBox();
            this.OffenseDescTextBox = new System.Windows.Forms.TextBox();
            this.CitationCommentsRTextBox = new System.Windows.Forms.RichTextBox();
            this.OffenseIdTextBox = new System.Windows.Forms.TextBox();
            this.CitationIdTextBox = new System.Windows.Forms.TextBox();
            this.OfficerIdComboBox = new System.Windows.Forms.ComboBox();
            this.viewByLicenseButton = new System.Windows.Forms.Button();
            this.LicenseListBox = new System.Windows.Forms.ListBox();
            this.LicenseSearchTextBox = new System.Windows.Forms.TextBox();
            this.citationLabel = new System.Windows.Forms.Label();
            this.OffenseIdlabel = new System.Windows.Forms.Label();
            this.CitationCommentsLabel = new System.Windows.Forms.Label();
            this.OffenseDescriptionLabel = new System.Windows.Forms.Label();
            this.OfficerLabel = new System.Windows.Forms.Label();
            this.OffenseLabel = new System.Windows.Forms.Label();
            this.VehicleModelLabel = new System.Windows.Forms.Label();
            this.LicensePlateLabel = new System.Windows.Forms.Label();
            this.CitationGroupBox = new System.Windows.Forms.GroupBox();
            this.SearchGroupBox = new System.Windows.Forms.GroupBox();
            this.editButton = new System.Windows.Forms.Button();
            this.deleteSelectedButton = new System.Windows.Forms.Button();
            this.searchLabel = new System.Windows.Forms.Label();
            this.CitationGroupBox.SuspendLayout();
            this.SearchGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // citationComboBox
            // 
            this.citationComboBox.FormattingEnabled = true;
            this.citationComboBox.Items.AddRange(new object[] {
            "Speeding",
            "Public Intoxication",
            "Noise Violation"});
            this.citationComboBox.Location = new System.Drawing.Point(150, 288);
            this.citationComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.citationComboBox.Name = "citationComboBox";
            this.citationComboBox.Size = new System.Drawing.Size(160, 27);
            this.citationComboBox.TabIndex = 1;
            this.citationComboBox.SelectedIndexChanged += new System.EventHandler(this.citationComboBox_SelectedIndexChanged);
            // 
            // addCitationButton
            // 
            this.addCitationButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addCitationButton.Location = new System.Drawing.Point(212, 552);
            this.addCitationButton.Margin = new System.Windows.Forms.Padding(4);
            this.addCitationButton.Name = "addCitationButton";
            this.addCitationButton.Size = new System.Drawing.Size(100, 34);
            this.addCitationButton.TabIndex = 2;
            this.addCitationButton.Text = "Add";
            this.addCitationButton.UseVisualStyleBackColor = true;
            this.addCitationButton.Click += new System.EventHandler(this.addCitationButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteButton.Location = new System.Drawing.Point(278, 552);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(4);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(86, 44);
            this.deleteButton.TabIndex = 3;
            this.deleteButton.Text = "delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // LicensePlateTextBox
            // 
            this.LicensePlateTextBox.Location = new System.Drawing.Point(178, 150);
            this.LicensePlateTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.LicensePlateTextBox.Name = "LicensePlateTextBox";
            this.LicensePlateTextBox.Size = new System.Drawing.Size(132, 27);
            this.LicensePlateTextBox.TabIndex = 5;
            // 
            // VehicleTextBox
            // 
            this.VehicleTextBox.Location = new System.Drawing.Point(178, 196);
            this.VehicleTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.VehicleTextBox.Name = "VehicleTextBox";
            this.VehicleTextBox.Size = new System.Drawing.Size(132, 27);
            this.VehicleTextBox.TabIndex = 7;
            // 
            // OffenseDescTextBox
            // 
            this.OffenseDescTextBox.Location = new System.Drawing.Point(178, 334);
            this.OffenseDescTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.OffenseDescTextBox.Name = "OffenseDescTextBox";
            this.OffenseDescTextBox.Size = new System.Drawing.Size(132, 27);
            this.OffenseDescTextBox.TabIndex = 16;
            // 
            // CitationCommentsRTextBox
            // 
            this.CitationCommentsRTextBox.Location = new System.Drawing.Point(180, 389);
            this.CitationCommentsRTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.CitationCommentsRTextBox.Name = "CitationCommentsRTextBox";
            this.CitationCommentsRTextBox.Size = new System.Drawing.Size(132, 138);
            this.CitationCommentsRTextBox.TabIndex = 20;
            this.CitationCommentsRTextBox.Text = "";
            // 
            // OffenseIdTextBox
            // 
            this.OffenseIdTextBox.Location = new System.Drawing.Point(178, 242);
            this.OffenseIdTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.OffenseIdTextBox.Name = "OffenseIdTextBox";
            this.OffenseIdTextBox.Size = new System.Drawing.Size(132, 27);
            this.OffenseIdTextBox.TabIndex = 23;
            // 
            // CitationIdTextBox
            // 
            this.CitationIdTextBox.Location = new System.Drawing.Point(178, 104);
            this.CitationIdTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.CitationIdTextBox.Name = "CitationIdTextBox";
            this.CitationIdTextBox.Size = new System.Drawing.Size(132, 27);
            this.CitationIdTextBox.TabIndex = 25;
            // 
            // OfficerIdComboBox
            // 
            this.OfficerIdComboBox.FormattingEnabled = true;
            this.OfficerIdComboBox.Location = new System.Drawing.Point(152, 58);
            this.OfficerIdComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.OfficerIdComboBox.Name = "OfficerIdComboBox";
            this.OfficerIdComboBox.Size = new System.Drawing.Size(160, 27);
            this.OfficerIdComboBox.TabIndex = 27;
            // 
            // viewByLicenseButton
            // 
            this.viewByLicenseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewByLicenseButton.Location = new System.Drawing.Point(235, 145);
            this.viewByLicenseButton.Margin = new System.Windows.Forms.Padding(4);
            this.viewByLicenseButton.Name = "viewByLicenseButton";
            this.viewByLicenseButton.Size = new System.Drawing.Size(100, 34);
            this.viewByLicenseButton.TabIndex = 28;
            this.viewByLicenseButton.Text = "Search";
            this.viewByLicenseButton.UseVisualStyleBackColor = true;
            this.viewByLicenseButton.Click += new System.EventHandler(this.viewByLicenseButton_Click);
            // 
            // LicenseListBox
            // 
            this.LicenseListBox.FormattingEnabled = true;
            this.LicenseListBox.ItemHeight = 19;
            this.LicenseListBox.Location = new System.Drawing.Point(65, 192);
            this.LicenseListBox.Margin = new System.Windows.Forms.Padding(4);
            this.LicenseListBox.Name = "LicenseListBox";
            this.LicenseListBox.Size = new System.Drawing.Size(268, 137);
            this.LicenseListBox.TabIndex = 29;
            this.LicenseListBox.SelectedIndexChanged += new System.EventHandler(this.LicenseListBox_SelectedIndexChanged);
            // 
            // LicenseSearchTextBox
            // 
            this.LicenseSearchTextBox.Location = new System.Drawing.Point(201, 104);
            this.LicenseSearchTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.LicenseSearchTextBox.Name = "LicenseSearchTextBox";
            this.LicenseSearchTextBox.Size = new System.Drawing.Size(132, 27);
            this.LicenseSearchTextBox.TabIndex = 30;
            this.LicenseSearchTextBox.Text = "AAA123";
            // 
            // citationLabel
            // 
            this.citationLabel.AutoSize = true;
            this.citationLabel.Location = new System.Drawing.Point(36, 107);
            this.citationLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.citationLabel.Name = "citationLabel";
            this.citationLabel.Size = new System.Drawing.Size(78, 19);
            this.citationLabel.TabIndex = 62;
            this.citationLabel.Text = "Citation ID:";
            // 
            // OffenseIdlabel
            // 
            this.OffenseIdlabel.AutoSize = true;
            this.OffenseIdlabel.Location = new System.Drawing.Point(36, 245);
            this.OffenseIdlabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.OffenseIdlabel.Name = "OffenseIdlabel";
            this.OffenseIdlabel.Size = new System.Drawing.Size(76, 19);
            this.OffenseIdlabel.TabIndex = 61;
            this.OffenseIdlabel.Text = "Offense id:";
            // 
            // CitationCommentsLabel
            // 
            this.CitationCommentsLabel.AutoSize = true;
            this.CitationCommentsLabel.Location = new System.Drawing.Point(36, 389);
            this.CitationCommentsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CitationCommentsLabel.Name = "CitationCommentsLabel";
            this.CitationCommentsLabel.Size = new System.Drawing.Size(131, 19);
            this.CitationCommentsLabel.TabIndex = 58;
            this.CitationCommentsLabel.Text = "Citation Comments:";
            // 
            // OffenseDescriptionLabel
            // 
            this.OffenseDescriptionLabel.AutoSize = true;
            this.OffenseDescriptionLabel.Location = new System.Drawing.Point(36, 337);
            this.OffenseDescriptionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.OffenseDescriptionLabel.Name = "OffenseDescriptionLabel";
            this.OffenseDescriptionLabel.Size = new System.Drawing.Size(94, 19);
            this.OffenseDescriptionLabel.TabIndex = 57;
            this.OffenseDescriptionLabel.Text = "Offense Desc:";
            // 
            // OfficerLabel
            // 
            this.OfficerLabel.AutoSize = true;
            this.OfficerLabel.Location = new System.Drawing.Point(36, 61);
            this.OfficerLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.OfficerLabel.Name = "OfficerLabel";
            this.OfficerLabel.Size = new System.Drawing.Size(72, 19);
            this.OfficerLabel.TabIndex = 52;
            this.OfficerLabel.Text = "Officer ID:";
            // 
            // OffenseLabel
            // 
            this.OffenseLabel.AutoSize = true;
            this.OffenseLabel.Location = new System.Drawing.Point(36, 291);
            this.OffenseLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.OffenseLabel.Name = "OffenseLabel";
            this.OffenseLabel.Size = new System.Drawing.Size(60, 19);
            this.OffenseLabel.TabIndex = 50;
            this.OffenseLabel.Text = "Offense:";
            // 
            // VehicleModelLabel
            // 
            this.VehicleModelLabel.AutoSize = true;
            this.VehicleModelLabel.Location = new System.Drawing.Point(36, 199);
            this.VehicleModelLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.VehicleModelLabel.Name = "VehicleModelLabel";
            this.VehicleModelLabel.Size = new System.Drawing.Size(115, 19);
            this.VehicleModelLabel.TabIndex = 49;
            this.VehicleModelLabel.Text = "Model Of Vehicle:";
            // 
            // LicensePlateLabel
            // 
            this.LicensePlateLabel.AutoSize = true;
            this.LicensePlateLabel.Location = new System.Drawing.Point(36, 153);
            this.LicensePlateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LicensePlateLabel.Name = "LicensePlateLabel";
            this.LicensePlateLabel.Size = new System.Drawing.Size(100, 19);
            this.LicensePlateLabel.TabIndex = 48;
            this.LicensePlateLabel.Text = "License Plate: ";
            // 
            // CitationGroupBox
            // 
            this.CitationGroupBox.Controls.Add(this.citationLabel);
            this.CitationGroupBox.Controls.Add(this.OffenseIdlabel);
            this.CitationGroupBox.Controls.Add(this.CitationCommentsLabel);
            this.CitationGroupBox.Controls.Add(this.OffenseDescriptionLabel);
            this.CitationGroupBox.Controls.Add(this.OfficerLabel);
            this.CitationGroupBox.Controls.Add(this.OffenseLabel);
            this.CitationGroupBox.Controls.Add(this.VehicleModelLabel);
            this.CitationGroupBox.Controls.Add(this.LicensePlateLabel);
            this.CitationGroupBox.Controls.Add(this.OfficerIdComboBox);
            this.CitationGroupBox.Controls.Add(this.CitationIdTextBox);
            this.CitationGroupBox.Controls.Add(this.OffenseIdTextBox);
            this.CitationGroupBox.Controls.Add(this.CitationCommentsRTextBox);
            this.CitationGroupBox.Controls.Add(this.OffenseDescTextBox);
            this.CitationGroupBox.Controls.Add(this.VehicleTextBox);
            this.CitationGroupBox.Controls.Add(this.LicensePlateTextBox);
            this.CitationGroupBox.Controls.Add(this.addCitationButton);
            this.CitationGroupBox.Controls.Add(this.citationComboBox);
            this.CitationGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CitationGroupBox.ForeColor = System.Drawing.Color.Gold;
            this.CitationGroupBox.Location = new System.Drawing.Point(16, 22);
            this.CitationGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.CitationGroupBox.Name = "CitationGroupBox";
            this.CitationGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.CitationGroupBox.Size = new System.Drawing.Size(370, 616);
            this.CitationGroupBox.TabIndex = 63;
            this.CitationGroupBox.TabStop = false;
            this.CitationGroupBox.Text = "New Citation";
            // 
            // SearchGroupBox
            // 
            this.SearchGroupBox.Controls.Add(this.editButton);
            this.SearchGroupBox.Controls.Add(this.deleteSelectedButton);
            this.SearchGroupBox.Controls.Add(this.searchLabel);
            this.SearchGroupBox.Controls.Add(this.LicenseSearchTextBox);
            this.SearchGroupBox.Controls.Add(this.deleteButton);
            this.SearchGroupBox.Controls.Add(this.LicenseListBox);
            this.SearchGroupBox.Controls.Add(this.viewByLicenseButton);
            this.SearchGroupBox.ForeColor = System.Drawing.Color.Gold;
            this.SearchGroupBox.Location = new System.Drawing.Point(408, 22);
            this.SearchGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.SearchGroupBox.Name = "SearchGroupBox";
            this.SearchGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.SearchGroupBox.Size = new System.Drawing.Size(386, 616);
            this.SearchGroupBox.TabIndex = 64;
            this.SearchGroupBox.TabStop = false;
            this.SearchGroupBox.Text = "Search Citations";
            // 
            // editButton
            // 
            this.editButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editButton.Location = new System.Drawing.Point(109, 348);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(89, 33);
            this.editButton.TabIndex = 33;
            this.editButton.Text = "Edit";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // deleteSelectedButton
            // 
            this.deleteSelectedButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteSelectedButton.Location = new System.Drawing.Point(244, 348);
            this.deleteSelectedButton.Name = "deleteSelectedButton";
            this.deleteSelectedButton.Size = new System.Drawing.Size(89, 33);
            this.deleteSelectedButton.TabIndex = 32;
            this.deleteSelectedButton.Text = "Delete";
            this.deleteSelectedButton.UseVisualStyleBackColor = true;
            this.deleteSelectedButton.Click += new System.EventHandler(this.deleteSelectedButton_Click);
            // 
            // searchLabel
            // 
            this.searchLabel.AutoSize = true;
            this.searchLabel.Location = new System.Drawing.Point(39, 108);
            this.searchLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Size = new System.Drawing.Size(149, 19);
            this.searchLabel.TabIndex = 31;
            this.searchLabel.Text = "Enter License Number";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(51)))), ((int)(((byte)(23)))));
            this.ClientSize = new System.Drawing.Size(812, 658);
            this.Controls.Add(this.SearchGroupBox);
            this.Controls.Add(this.CitationGroupBox);
            this.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Gold;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Citation Tracker";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.CitationGroupBox.ResumeLayout(false);
            this.CitationGroupBox.PerformLayout();
            this.SearchGroupBox.ResumeLayout(false);
            this.SearchGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox citationComboBox;
        private System.Windows.Forms.Button addCitationButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.TextBox LicensePlateTextBox;
        private System.Windows.Forms.TextBox VehicleTextBox;
        private System.Windows.Forms.TextBox OffenseDescTextBox;
        private System.Windows.Forms.RichTextBox CitationCommentsRTextBox;
        private System.Windows.Forms.TextBox OffenseIdTextBox;
        private System.Windows.Forms.TextBox CitationIdTextBox;
        private System.Windows.Forms.ComboBox OfficerIdComboBox;
        private System.Windows.Forms.Button viewByLicenseButton;
        private System.Windows.Forms.ListBox LicenseListBox;
        private System.Windows.Forms.TextBox LicenseSearchTextBox;
        private System.Windows.Forms.Label citationLabel;
        private System.Windows.Forms.Label OffenseIdlabel;
        private System.Windows.Forms.Label CitationCommentsLabel;
        private System.Windows.Forms.Label OffenseDescriptionLabel;
        private System.Windows.Forms.Label OfficerLabel;
        private System.Windows.Forms.Label OffenseLabel;
        private System.Windows.Forms.Label VehicleModelLabel;
        private System.Windows.Forms.Label LicensePlateLabel;
        private System.Windows.Forms.GroupBox CitationGroupBox;
        private System.Windows.Forms.GroupBox SearchGroupBox;
        private System.Windows.Forms.Label searchLabel;
        private System.Windows.Forms.Button deleteSelectedButton;
        private System.Windows.Forms.Button editButton;
    }
}

