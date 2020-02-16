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
using static AsgDThirdTry.Login;
//using System.ComponentModel.DataAnnotations.Schema;

namespace AsgDThirdTry
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //this.Hide();

        }

        private void addCitationButton_Click(object sender, EventArgs e)
        {
            using (var db = new CitationTracker())
            {

                Random rand = new Random();

                // int id = rand.Next();


                // int _offenseId = rand.Next();

                var citationId = CitationIdTextBox.Text;//rand.Next();
                var citationLicenseNumber = LicensePlateTextBox.Text;
                var citationVechicle = VehicleTextBox.Text;
                //var officerId = OfficerIdTextBox.Text;
                //var offenseId = rand.Next().ToString();//offenseId.ToString();
                //var offenseName = citationComboBox.Text;
                var citationComments = CitationCommentsRTextBox.Text;


                // var citationSelect = citationComboBox.Text;
                //var citation = new Citation { CitationName = citationSelect, CitationID=1 };

                //var officer = new Officer
                //{
                //    OfficerId = OfficerIdTextBox.Text,
                //    OfficerFirstName = OfficerFirstNameTextBox.Text,
                //    OfficerLastName = OfficerLastNameTextBox.Text,
                //    OfficerUsername = "a",
                //    OfficerPassword = "a"
                //};

                var offense = new Offense
                {
                    OffenseId = OffenseIdTextBox.Text,//"2",// rand.Next().ToString(),
                    OffenseName = citationComboBox.Text,
                    OffenseDescription = OffenseDescTextBox.Text
                };

                db.Offenses.Add(offense);
                db.SaveChanges();
                var citation = new Citation
                {
                    CitationID = citationId,
                    CitationLicenseNum = citationLicenseNumber,
                    CitationVehicle = citationVechicle,
                    CitationComments = citationComments,
                    OfficerId = OfficerIdComboBox.Text,
                    //OffenseName = offenseName,
                    OffenseId = OffenseIdTextBox.Text
                };

                //   db.Officers.Add(officer);
                //   db.SaveChanges();

                //    db.Offenses.Add(offense);
                //   db.SaveChanges();


                db.Citations.Add(citation);
                db.SaveChanges();

                var query = from c in db.Citations
                            orderby c.CitationID
                            select c;

                //citationList.Items.Clear();
                //foreach (var item in query)
                //{
                //   citationList.Items.Add(item.CitationID);
                //}
            }

            MessageBox.Show("Citation added!");
            

            OfficerIdComboBox.Enabled = true;
            CitationIdTextBox.Text = "";
            LicensePlateTextBox.Text = "";
            VehicleTextBox.Text = "";
            OffenseIdTextBox.Text = "";
            OffenseDescTextBox.Text = "";
            CitationCommentsRTextBox.Text = "";
            citationComboBox.Text = "";
        }

        private void citationComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            using (var db = new CitationTracker())
            {
                var delete = from del in db.Citations
                                 //where del.CitationID == 1
                             select del;


                var deleteOfficers = from del in db.Officers
                                     select del;

                var deleteOffenses = from del in db.Offenses
                                     select del;

                var query = from c in db.Citations
                            orderby c.CitationID
                            select c;

                foreach (var item in delete)
                {
                    db.Citations.Remove(item);
                }

                foreach (var item in deleteOfficers)
                {
                    db.Officers.Remove(item);
                }

                foreach (var item in deleteOffenses)
                {
                    db.Offenses.Remove(item);
                }


                //  citationList.Items.Clear();
                db.SaveChanges();
            }
        }

        private void LicensePlateLabel_Click(object sender, EventArgs e)
        {

        }

        private void OffenseButton_Click(object sender, EventArgs e)
        {
            using (var db = new CitationTracker())
            {
                Random rand = new Random();
                int id = rand.Next();
                var offense = new Offense
                {
                    OffenseId = (OffenseIdTextBox.Text),//id,// rand.Next().ToString(),
                    OffenseName = citationComboBox.Text,
                    OffenseDescription = OffenseDescTextBox.Text
                };


                db.Offenses.Add(offense);
                db.SaveChanges();

                var query = from c in db.Offenses
                            orderby c.OffenseName
                            select c;

                //citationList.Items.Clear();
                //foreach (var item in query)
                //{
                //    citationList.Items.Add(item.OffenseName);
                //}

            }
        }

        //private void OfficerButton_Click(object sender, EventArgs e)
        //{
        //    using (var db = new CitationTracker())
        //    {
        //        var officer = new Officer
        //        {
        //            OfficerId = OfficerIdTextBox.Text,
        //            OfficerFirstName = OfficerFirstNameTextBox.Text,
        //            OfficerLastName = OfficerLastNameTextBox.Text,
        //            OfficerUsername = "a",
        //            OfficerPassword = "a"
        //        };

        //        db.Officers.Add(officer);
        //        db.SaveChanges();



        //        var query = from c in db.Officers
        //                    orderby c.OfficerFirstName
        //                    select c;

        //        //foreach (var item in query)
        //        //{
        //        //    citationList.Items.Add(item.OfficerFirstName + " " +item.OfficerLastName +" "+ item.OfficerId);
        //        //}

        //    }
        //}

        private void citationList_SelectedIndexChanged(object sender, EventArgs e)
        {
            //MessageBox.Show(OffenseId)
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //this.Hide();
            //var login = new Login();
            //login.Show();

            using (var db = new CitationTracker())
            {
                var query = from o in db.Officers
                            orderby o.OfficerId
                            select o;

                foreach (var item in query)
                {
                    OfficerIdComboBox.Items.Add(item.OfficerId);
                }
            }


        }

        private void OfficerLastNameLabel_Click(object sender, EventArgs e)
        {

        }

        private void OfficerLastNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void OfficerFNameLabel_Click(object sender, EventArgs e)
        {

        }

        private void OfficerFirstNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void OfficerLabel_Click(object sender, EventArgs e)
        {

        }

        private void OfficerIdTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void viewByLicenseButton_Click(object sender, EventArgs e)
        {
            using (var db = new CitationTracker())
            {
                var query = from l in db.Citations
                            where l.CitationLicenseNum == LicenseSearchTextBox.Text
                            orderby l.CitationLicenseNum
                            select l;

                LicenseListBox.Items.Clear();
                foreach (var item in query)
                {
                    LicenseListBox.Items.Add(item.CitationID);//+ " " +item.CitationVehicle +" "+ item.CitationLicenseNum + " "+item.CitationComments);
                }
            }
        }

        private void LicenseListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (LicenseListBox.SelectedIndex != -1)
            {
                string citation = LicenseListBox.SelectedItem.ToString();

                using (var db = new CitationTracker())
                {
                    var query = from c in db.Citations
                                where c.CitationID == citation
                                select c;

                    //foreach (var item in query)
                    //{
                    //    MessageBox.Show(string.Format("Citation ID: {0} Citation Vehicle {1} Citation License Num {2} Citation Comments {3}", item.CitationID,
                    //        item.CitationVehicle, item.CitationLicenseNum, item.CitationComments));

                    //}

                    //MessageBox.Show(string.Format("Citation ID: {0} Citation Vehicle {1} Citation License Num {2} Citation Comments {3}"))

                }
            }
        }

        private void deleteSelectedButton_Click(object sender, EventArgs e)
        {
            if (LicenseListBox.SelectedItem == null)
            {
                MessageBox.Show("Select the citaion to delete");
                return;
            }

            if (MessageBox.Show("Are you sure?", "Delete Selected Item? ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) ==
                DialogResult.Yes)
            {
                //delete the citation from database

                using (var db = new CitationTracker())
                {
                    var delete = db.Citations.SingleOrDefault(c => c.CitationID == LicenseListBox.SelectedItem.ToString());

                    if (delete != null)
                    {
                        db.Citations.Remove(delete);
                        LicenseListBox.Items.Clear();
                        var result = db.SaveChanges();
                        MessageBox.Show(string.Format("Citation {0} delted!", result));
                    }

                }



            }

            if (LicenseListBox.Items.Count > 0)
            {
                LicenseListBox.SelectedIndex = 0;
            }

        }

        private void editButton_Click(object sender, EventArgs e)
        {
            //if(LicenseListBox.SelectedItem == null)
            //{
            //    MessageBox.Show("Select a citation to edit");
            //    return;
            //}

            //using (var db = new CitationTracker())
            //{
            //    var search = LicenseListBox.SelectedItem.ToString();
            //    var edit = from ed in db.Citations
            //               where ed.CitationID == search//LicenseSearchTextBox.Text//LicenseListBox.SelectedItem.ToString()
            //               select ed;//db.Citations.SingleOrDefault(c => c.CitationID == LicenseListBox.SelectedItem.ToString());
            //   // Edit editC = new Edit();

            //    foreach (var item in edit)
            //    {
            //        // Edit editCitation = new Edit(item.CitationID, item.CitationLicenseNum, item.CitationVehicle, item.CitationComments);
            //        ////editC.CitationId = item.CitationID;
            //        //// editC.Show();
            //        //editCitation.Show();

            //        //if (editCitation.ShowDialog() == DialogResult.OK)
            //        //{
            //        //    item.CitationID = editCitation.CitationId;
            //        //    item.CitationVehicle = editCitation.CitationVehicle;
            //        //    item.CitationLicenseNum = editCitation.CitationLicense;
            //        //    item.CitationComments = editCitation.CitationComments;


            //        //    var citation = new Citation
            //        //    {
            //        //        CitationID = editCitation.CitationId,
            //        //        CitationLicenseNum = editCitation.CitationLicense,
            //        //        CitationVehicle = editCitation.CitationVehicle,
            //        //        CitationComments = editCitation.CitationComments
            //        //        //OfficerId = officerId,
            //        //        //OffenseName = offenseName,
            //        //        //OffenseId = offenseId
            //        //    };





            //            db.Citations.Add(citation);
            //            db.SaveChanges();

            //        }

            // CitationIdTextBox.Text = item.CitationID;
            //  }


            //  }


            if (LicenseListBox.SelectedItem == null)
            {
                MessageBox.Show("Select the citaion to edit");
                return;
            }

            if (MessageBox.Show("Are you sure?", "Update the Citation?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) ==
                DialogResult.Yes)
            {
                //delete the citation from database

                using (var db = new CitationTracker())
                {
                    var edit = db.Citations.SingleOrDefault(c => c.CitationID == LicenseListBox.SelectedItem.ToString());

                  //  MessageBox.Show(edit.OffenseId.ToString());

                    var offense = db.Offenses.SingleOrDefault(c => c.OffenseId == edit.OffenseId);//LicenseListBox.SelectedItem.ToString());//from o in db.Offenses
                                                                                                  //where o.OffenseId == edit.OffenseId
                                                                                                  // select o;
                //    MessageBox.Show(offense.OffenseId.ToString());


                    var officer = db.Officers.SingleOrDefault(c => c.OfficerId == edit.OfficerId);

                 //   MessageBox.Show(officer.OfficerId.ToString());

                    if (edit != null)
                    {
                        db.Citations.Remove(edit);
                        db.Offenses.Remove(offense);
                        db.SaveChanges();

                        CitationIdTextBox.Text = edit.CitationID;
                        VehicleTextBox.Text = edit.CitationVehicle;
                        LicensePlateTextBox.Text = edit.CitationLicenseNum;
                        CitationCommentsRTextBox.Text = edit.CitationComments;

                        OffenseIdTextBox.Text = offense.OffenseId;
                        OffenseDescTextBox.Text = offense.OffenseDescription;
                        citationComboBox.Text = offense.OffenseName;

                        OfficerIdComboBox.Text = officer.OfficerId;
                        OfficerIdComboBox.Enabled = false;

                        //var citation = new Citation();

                        LicenseListBox.Items.Clear();
                        var result = db.SaveChanges();

                        //MessageBox.Show(string.Format("Citation {0} delted!", result));
                    }

                }
            }
        }
    }
    }

