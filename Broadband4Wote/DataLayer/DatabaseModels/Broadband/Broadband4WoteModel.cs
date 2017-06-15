using Broadband4Wote.DataLayer.DatabaseModels.UniModel;
using Broadband4Wote.DataLayer.DataContext;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Broadband4Wote.DataLayer.DatabaseModels.Broadband
{
    [Table(nameof(BroadBandContext.BroadBand4Wote))]
    public class Broadband4WoteModel
    {
        [Key]
        public int ID { get; set; }
        public string Student_ID { get; set; }
        public string Uni_ID { get; set; }
        public string StaffId { get; set; }
        public string Mac_address { get; set; }
        public int Uhurone_ID { get; set; }
        public DateTime Timestamp { get; set; }



        [ForeignKey(nameof(Student_ID))]
        public virtual StudentModel Student { get; set; }
        [ForeignKey(nameof(Uni_ID))]
        public virtual UniversityModel Universty { get; set; }
        public virtual BankModel Bank { get; set; }
        [ForeignKey(nameof(StaffId))]
        public virtual StaffModel staff { get; set; }
    }
}