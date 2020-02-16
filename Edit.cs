using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AsgDThirdTry
{
    public partial class Edit : Form
    {
        public Edit()
        {
            InitializeComponent();
        }

        private void Edit_Load(object sender, EventArgs e)
        {


        }


        public Edit(String ID, String License, String Vechicle, String Comments)
        {
            InitializeComponent();
            this.CitationId = ID;
            this.CitationLicense = License;
            this.CitationVehicle = Vechicle;
        }



        public String CitationId
        {
            get
            {
                return CitationIdTextBox.Text;
            }
            set
            {
                CitationIdTextBox.Text = value;
            }
        }

        public String CitationLicense
        {
            get
            {
                return CitationLicenseTextBox.Text;
            }
            set
            {
                CitationLicenseTextBox.Text = value;
            }
        }


        public String CitationVehicle
        {
            get
            {
                return CitationVehicleTextBox.Text;
            }
            set
            {
                CitationVehicleTextBox.Text = value;
            }
        }

        public String CitationComments
        {
            get
            {
                return CitationCommentsTextBox.Text;
            }
            set
            {
                CitationCommentsTextBox.Text = value;
            }
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
