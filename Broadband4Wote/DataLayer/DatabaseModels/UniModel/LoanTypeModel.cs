using Broadband4Wote.DataLayer.DataContext;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Broadband4Wote.DataLayer.DatabaseModels.UniModel
{
    [Table(nameof(BroadBandContext.LoanType))]
    public class LoanTypeModel
    {
        [Key]
        public int LoanType_ID { get; set; }
        public string Type_name { get; set; }


        public virtual LoanModel Loan { get; set; }
    }
}