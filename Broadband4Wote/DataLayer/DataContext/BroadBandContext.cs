using Broadband4Wote.DataLayer.DatabaseModels.Broadband;
using Broadband4Wote.DataLayer.DatabaseModels.UniModel;
using Broadband4Wote.Models;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace Broadband4Wote.DataLayer.DataContext
{
    public class BroadBandContext : IdentityDbContext<ApplicationUser>
    {

        public BroadBandContext() : base(nameOrConnectionString:"Sql4Wote")
        { }
        public static BroadBandContext Create()
        {
            return new BroadBandContext();
        }
        // UNiModel
        public DbSet<LoanModel> Loan { get; set; }
        public DbSet<RejectedModel> Rejected { get; set; }
        public DbSet<StudentModel> Student { get; set; }
        public DbSet<TrackerModel> Tracker { get; set; }
        public DbSet<UniversityModel> University { get; set; }
        public DbSet<VerfiedModel> Verfied { get; set; }
        public DbSet<LoanTypeModel> LoanType { get; set; }

        public DbSet<StaffModel> Staff { get; set; }
        public DbSet<DocumentModel> Document { get; set; }
        public DbSet<ReferenceModel> Reference { get; set; }

        //Broadband Model
        public DbSet<Broadband4WoteModel> BroadBand4Wote { get; set; }
        public DbSet<BankModel> Bank { get; set; }



        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();



            modelBuilder.Entity<IdentityUserLogin>().HasKey<string>(l => l.UserId);
            modelBuilder.Entity<IdentityRole>().HasKey<string>(r => r.Id);
            modelBuilder.Entity<IdentityUserRole>().HasKey(r => new { r.RoleId, r.UserId });
        }
    }
}