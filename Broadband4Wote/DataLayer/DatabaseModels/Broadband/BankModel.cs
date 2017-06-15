using Broadband4Wote.DataLayer.DataContext;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Broadband4Wote.DataLayer.DatabaseModels.Broadband
{
    [Table(nameof(BroadBandContext.Bank))]
    public class BankModel
    {
        
        [Key,ForeignKey(nameof(BroadBand))]
        
        public int Bank_ID { get; set; }

        public bool status { get; set; }
        public DateTime Timestamp { get; set; }



        public virtual Broadband4WoteModel BroadBand { get; set; }

    }
}