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
    [Table(nameof(BroadBandContext.Reference))]
    public class ReferenceModel
    {
        [Key]
        public string RefernceID { get; set; }
        public string ApplicationID { get; set; }
        public string Email { get; set; }
        [DataType(DataType.Password)]
        public string Password { get; set; }


        [ForeignKey(nameof(ApplicationID))]
        public virtual ApplicationUser ApplicationUser { get; set; }
    }

}