using Broadband4Wote.DataLayer.DatabaseModels.UniModel;
using Broadband4Wote.DataLayer.DataContext;
using System;
using System.Threading.Tasks;

namespace Broadband4Wote.Models.Rules
{
    public class UniverstyRules : BroadBandContext
    {
        public  async Task<Tuple<bool,object>> RegisterStudent(registerStudentViewModel model, ApplicationUserManager UserManager)
        {
            if (model != null)
            {
                if (model.Course_ID == 0 && model.Loan_ID == 0)
                {
                    return new Tuple<bool,object> (false,null);
                }
                var user = new ApplicationUser { UserName = model.Email, Email = model.Email, PhoneNumber = model.Phone_number.ToString() };

                var reference = new ReferenceModel
                {
                    RefernceID = Guid.NewGuid().ToString("N").Substring(14, 14).ToUpper(),
                    Email = model.Email,
                    Password = String.Concat(model.Birth_Date,
                    ".",
                    model.Last_Name.ToUpper(),
                    Guid.NewGuid().ToString("N").Substring(4))
                };


                var result = await UserManager.CreateAsync(user, reference.Password);
                
                var sm = new StudentModel {
                    First_Name = model.First_Name,
                    Middle_Name = model.Middle_Name,
                    Last_Name = model.Last_Name,
                    Address = model.Address,
                   // Age = ,
                    ApplicationUser_Id = user.Id,
                    Birth_Date = model.Birth_Date,
                    City = model.City,
                    //Course = model.Course_ID,
                    Division = model.Division,
                    National_ID = model.National_ID,
                    Phone = model.Phone_number,
                    Region = model.Region,
                    Student_ID = Guid.NewGuid().ToString("N").Substring(6).ToUpper()
                    //Study_Year = model.y
           
                };
                
                if (result.Succeeded)
                {
                    Student.Add(sm);
                    Reference.Add(reference);
                   
                   await SaveChangesAsync();

                    return new Tuple<bool, object>(true, reference);
                }
            }

            return new Tuple<bool, object>(false, null);
        }

        public bool UplaodStudentPic(profileViewModel pv)
        {
            if (pv != null)
            {
                return true;
            }

            return false;
        }
    }
}