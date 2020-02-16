using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using static AsgDThirdTry.Program;
namespace AsgDThirdTry
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void OfficerButton_Click(object sender, EventArgs e)
        {
            using (var db = new CitationTracker())
            {
                var officer = new Officer
                {
                    OfficerId = OfficerIdTextBox.Text,
                    OfficerFirstName = OfficerFirstNameTextBox.Text,
                    OfficerLastName = OfficerLastNameTextBox.Text,
                    OfficerUsername = OfficerAddUsernameTextBox.Text,//"a",
                    OfficerPassword = OfficerAddPasswordTextBox.Text//"a"
                };

                db.Officers.Add(officer);
                db.SaveChanges();
                pictureBox1.Visible = true;


                
             //   this.Hide();
             //   var form1 = new Form1();

                //form1.Controls[OfficerIdTextBox.Text] = OfficerIdTextBox.Text;

            //    form1.Show();
            }

        }

        private void LoginWithUandPButton_Click(object sender, EventArgs e)
        {
            using (var db = new CitationTracker())
            {
                var credentials = db.Officers
                    .Where(c => c.OfficerUsername == OfficerUsernameTextBox.Text && c.OfficerPassword == OfficerPasswordTextBox.Text);

                foreach(var item in credentials)
                {
                    if(credentials == null)
                    {
                        MessageBox.Show("Officer not found");
                    }
                    else
                    {
                        this.Hide();
                        var form1 = new Form1();
                        form1.Show();
                    }
                }
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void AddOfficerButton_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
        }
    }
}
