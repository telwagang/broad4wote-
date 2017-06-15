using Broadband4Wote.DataLayer.DataContext;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Broadband4Wote.DataLayer.DatabaseModels.UniModel
{
    [Table(nameof(BroadBandContext.Loan))]
    public class LoanModel
    {
        public LoanModel()
        {
            LoanType = new List<LoanTypeModel>();
            Verfied = new List<VerfiedModel>();
        }

        [Key,ForeignKey(nameof(Student))]
        public string Student_ID { get; set; }
        [ForeignKey(nameof(LoanType))]
        public int Type_ID { get; set; }
        public int Duration { get; set; }
        public DateTime TimeStamp { get; set; }


        public virtual ICollection<LoanTypeModel>  LoanType { get; set; }
        public virtual StudentModel Student { get; set; }
        public virtual ICollection<VerfiedModel> Verfied { get; set; }
    }
}