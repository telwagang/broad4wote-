using Broadband4Wote.DataLayer.DataContext;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Broadband4Wote.DataLayer.DatabaseModels.UniModel
{
    [Table(nameof(BroadBandContext.Verfied))]
    public class VerfiedModel
    {
        [Key]
        public int Verfied_ID { get; set; }
        public string Student_ID  { get; set; }

        [ForeignKey(nameof(staff))]
        public string Staff_Id { get; set; }
        public string Loan_ID { get; set; }
        public DateTime TimeStamp { get; set; }



        [ForeignKey(nameof(Student_ID))]
        public virtual StudentModel Student { get; set; }
        [ForeignKey(nameof(Loan_ID))]
        public virtual LoanModel Loan { get; set; }
       
        public virtual StaffModel staff { get; set; }
    }
}