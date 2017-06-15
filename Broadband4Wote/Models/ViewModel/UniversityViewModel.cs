using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Broadband4Wote.Models
{
    
   
        public class registerStudentViewModel
        {
            [Display(Name = "Student ID")]
            public string Student_ID { get; set; }
            [Display(Name = "National ID")]
            public int National_ID { get; set; }
            [Display(Name = "First Name")]
            public string First_Name { get; set; }
            [Display(Name = "Middle Name")]
            public string Middle_Name { get; set; }
            [Display(Name = "Last Name")]
            public string Last_Name { get; set; }

            [Display(Name = "Email Address")]
            [DataType(DataType.EmailAddress)]
            public string Email { get; set; }

            [Display(Name = "Phone Number")]
            public int Phone_number { get; set; }

            [Required]
            [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
            [DataType(DataType.Password)]
            [Display(Name = "New password")]
            public string NewPassword { get; set; }

            [DataType(DataType.Password)]
            [Display(Name = "Confirm new password")]
            [Compare("NewPassword", ErrorMessage = "The new password and confirmation password do not match.")]
            public string ConfirmPassword { get; set; }

            [DataType(DataType.Date)]
            [Display(Name = "Birth Date")]
            public DateTime Birth_Date { get; set; }
            [Display(Name = "Course")]
            public int Course_ID { get; set; }
            [Display(Name = "Loan Type")]
            public int Loan_ID { get; set; }
            [Display(Name = "Address")]
            [DataType(DataType.MultilineText)]
            public string Address { get; set; }
            [Display(Name = "Wilaya")]
            public string Division { get; set; }
            [Display(Name = "Region")]
            public string Region { get; set; }
            [Display(Name = "City")]
            public string City { get; set; }
        }

    public class studentReference
    {
        [Display(Name="Name")]
        [Required]
        public string name { get; set; }

        [Display(Name ="Email")]
        [DataType(DataType.EmailAddress)]
        public string email { get; set; }

        [Display(Name ="Is that your Email")]
      
        public bool isEmailValid { get; set; }
        [Display(Name ="Reference Key")]
        public string key { get; set; }
    }

    public class studentStatus
    {
        [Display(Name ="Has Sign Up")]
        public bool  SignUp{ get; set; }

        [Display(Name ="Signed a Consent form")]
        public bool signDoc { get; set; }

        [Display(Name ="Viewed By University")]
        public bool viewByUni { get; set; }

        [Display(Name ="Verfied By University")]
        public bool approveByUni{ get; set; }

        [Display(Name ="Viewed By UhuruOne")]
        public bool viewedByUhuru{ get; set; }

        [Display(Name ="Ready for Pickup")]
        public bool readyPick { get; set; }

        [Display(Name ="Picked Up")]
        public bool picked { get; set; }
    }

    public class StatusViewModel
    {
        [Display(Name = "Has Sign Up")]
        public bool SignUp { get; set; }

        [Display(Name = "Signed a Consent form")]
        public bool signDoc { get; set; }

        [Display(Name = "Viewed By University")]
        public bool viewByUni { get; set; }

        [Display(Name = "Verfied By University")]
        public bool approveByUni { get; set; }

        [Display(Name = "Viewed By UhuruOne")]
        public bool viewedByUhuru { get; set; }

        [Display(Name = "Ready for Pickup")]
        public bool readyPick { get; set; }

        [Display(Name = "Picked Up")]
        public bool picked { get; set; }
    }
    public class profileViewModel
    {
        public HttpPostedFileBase url { get; set; }
    }
}