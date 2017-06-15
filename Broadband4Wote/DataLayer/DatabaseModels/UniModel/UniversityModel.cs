using Broadband4Wote.DataLayer.DataContext;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Broadband4Wote.DataLayer.DatabaseModels.UniModel
{
    [Table(nameof(BroadBandContext.University))]
    public class UniversityModel
    {
        public UniversityModel()
        {
            Student = new List<StudentModel>();
            Staff = new List<StaffModel>();
        }

        [Key]
        public string Universty_ID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Registration_no { get; set; }
        public int Phone { get; set; }
        public DateTime Date { get; set; }



        public virtual ICollection<StudentModel> Student { get; set; }
        public virtual ICollection<StaffModel> Staff { get; set; }
    }
}