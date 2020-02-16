/*
 * Brad Wells
 * CIS229.2258
 * March 31 2019
 * Assigment D
 * This program uses the Microsoft Entity Framework and a code-first design to generate a database that is used by 
 * officers to create citations. They can then edit and delete them as needed. 
 * 
 * 
 * I still need to add validations and error messages. I need to add the date option to the citation as well. 
 * 
 * */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
namespace AsgDThirdTry
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login());
        }






        public class Officer
        {
            [Key]
            public string OfficerId { get; set; }

            [Required]
            public string OfficerFirstName { get; set; }

            [Required]
            public string OfficerLastName { get; set; }

            [Required]
            public string OfficerUsername { get; set; }

            [Required]
            public string OfficerPassword { get; set; }



            public virtual List<Citation> Citations { get; set; }

            public Officer()
            {
                this.Citations = new List<Citation>();
            }
        }


        public class Offense
        {
            [Required]
            [Key]
            public string OffenseId { get; set; }

            [Required]
            public string OffenseName { get; set; }

            [Required]
            public string OffenseDescription { get; set; }
        }



        public class Citation
        {
            [Key]
            public string CitationID { get; set; }

            //[Required]
            //public string CitationName { get; set; }

            [Required]
            public string CitationLicenseNum { get; set; }

            [Required]
            public string CitationVehicle { get; set; }

            // [Required]
            // public Officer Officer { get; set; }
            public string OfficerId { get; set; }

            //// [Required]
            //// public string OffenseName { get; set; }

            //// [Required]
             public string OffenseId { get; set; }
             public Offense Offense { get; set; }

            public string CitationComments { get; set; }

            public virtual Officer Officer { get; set; }
        }


        public class CitationTracker : DbContext
        {
            public DbSet<Citation> Citations { get; set; }
            public DbSet<Officer> Officers { get; set; }
            public DbSet<Offense> Offenses { get; set; }
        }


    }
}
