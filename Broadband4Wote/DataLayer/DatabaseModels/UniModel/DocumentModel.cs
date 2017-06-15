using Broadband4Wote.DataLayer.DataContext;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Broadband4Wote.DataLayer.DatabaseModels.UniModel
{
    [Table(nameof(BroadBandContext.Document))]
    public class DocumentModel
    {
        [Key]
        public int DocumentID { get; set; }

        [ForeignKey(nameof(Student))]
        public string StudentID { get; set; }

        [ForeignKey(nameof(staff))]
        public string  staffId { get; set; }
        public string Profile_Url { get; set; }
        public string Doc_Url { get; set; }
        public DateTime Date { get; set; }


        public virtual  StudentModel Student { get; set; }
        public virtual StaffModel staff { get; set; }
    }
}