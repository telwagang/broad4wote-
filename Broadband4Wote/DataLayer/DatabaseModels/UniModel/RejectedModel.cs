using Broadband4Wote.DataLayer.DataContext;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Broadband4Wote.DataLayer.DatabaseModels.UniModel
{
    [Table(nameof(BroadBandContext.Rejected))]
    public class RejectedModel
    {
        [Key]
        public int Rejected_ID { get; set; }
        public string Student_ID { get; set; }
        public string Staff_Id { get; set; }
        public string Reason { get; set; }
        public DateTime Timestamp { get; set; }



        [ForeignKey(nameof(Student_ID))]
        public virtual StudentModel student { get; set; }
        [ForeignKey(nameof(Staff_Id))]
        public virtual StaffModel staff { get; set; }


    }
}