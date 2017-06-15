using Broadband4Wote.DataLayer.DataContext;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Broadband4Wote.DataLayer.DatabaseModels.UniModel
{
    [Table(nameof(BroadBandContext.Tracker))]
    public class TrackerModel
    {
        [Key]
        public int Tracker_ID { get; set; }
        public string Student_ID { get; set; }
        public string Staff_Id { get; set; }
        public string Progress { get; set; }
        public DateTime TimeStamp { get; set; }



        [ForeignKey(nameof(Student_ID))]
        public virtual StudentModel Student { get; set; }
        [ForeignKey(nameof(Staff_Id))]
        public virtual StaffModel staff { get; set; }
    }
}