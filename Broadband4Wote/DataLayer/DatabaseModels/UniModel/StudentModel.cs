using Broadband4Wote.DataLayer.DataContext;
using Broadband4Wote.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Broadband4Wote.DataLayer.DatabaseModels.UniModel
{
    [Table(nameof(BroadBandContext.Student))]
    public class StudentModel
    {
       public  StudentModel ()
        {
            Rejected = new List<RejectedModel>();
            Tracker = new List<TrackerModel>();
            Verfied = new List<VerfiedModel>();
            Document = new List<DocumentModel>();
        }

        [Key]
        public string Student_ID { get; set; }
        [ForeignKey(nameof(ApplicationUser))]
        public string ApplicationUser_Id { get; set; }
        public int National_ID { get; set; }
        [Required]
        public string First_Name { get; set; }
        [Required]
        public string Middle_Name { get; set; }
        [Required]
        public string Last_Name { get; set; }
        [DataType(DataType.Date)]
        public DateTime Birth_Date { get; set; }
        [DataType(DataType.PhoneNumber)]
        public int Phone { get; set; }
        public int Age { get; set; }
        [Required]
        public string University_ID { get; set; }
        [Required]
        public string Course { get; set; }
        public int Study_Year { get; set; }
        public string Address { get; set; }
        public string Division { get; set; }
        public string Region { get; set; }
        public string City { get; set; }
        public DateTime TimeStamp { get; set; }


        [ForeignKey(nameof(University_ID))]
        public virtual UniversityModel University { get; set; }
        public virtual ApplicationUser   ApplicationUser { get; set; }
        public virtual LoanModel Loan { get; set; }
        public virtual ICollection<RejectedModel> Rejected { get; set; }
        public virtual ICollection<DocumentModel> Document { get; set; }
        public virtual ICollection<TrackerModel> Tracker { get; set; }
        public virtual ICollection<VerfiedModel> Verfied { get; set; }

    }
}