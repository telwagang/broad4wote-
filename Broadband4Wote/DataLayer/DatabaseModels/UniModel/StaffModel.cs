using Broadband4Wote.DataLayer.DatabaseModels.Broadband;
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
    [Table(nameof(BroadBandContext.Staff))]
    public class StaffModel
    {
        public StaffModel()
        {
            Rejected = new List<RejectedModel>();
            Tracker = new List<TrackerModel>();
            Verfied = new List<VerfiedModel>();
            BroadBand = new List<Broadband4WoteModel>();
            Document = new List<DocumentModel>();

        }


        [Key]
        public string Staff_ID { get; set; }

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

        [ForeignKey(nameof(uni))]
        public string UniversiyID { get; set; }


        public virtual ApplicationUser ApplicationUser { get; set; }

        public virtual UniversityModel  uni { get; set; }
        public virtual ICollection<RejectedModel> Rejected { get; set; }
        public virtual ICollection<DocumentModel> Document { get; set; }
        public virtual ICollection<TrackerModel> Tracker { get; set; }
        public virtual ICollection<VerfiedModel> Verfied { get; set; }
        public virtual ICollection<Broadband4WoteModel> BroadBand { get; set; }

    }
}