using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LIA2Project.Models.DataAccess
{
    public class UserDataAccessLayer
    {
        DuoSTATIONContext db = new DuoSTATIONContext();

        public IEnumerable<Users> GetAllUsers()
        {
            try
            {
                return db.Users.ToList();
            }
            catch
            {
                throw;
            }
        }

        public int AddUser(Users users)
        {
            try
            {
                db.Users.Add(users);
                db.SaveChanges();
                return 1;
            }
            catch
            {
                throw;
            }
        }


        public int UpdateUser(Users tbluser)
        {
            try
            {
                db.Entry(tbluser).State = EntityState.Modified;
                db.SaveChanges();

                return 1;
            }
            catch
            {
                throw;
            }
        }


        public Users GetUserDataById(Guid id)
        {
            try
            {
                Users tbluser = db.Users.Find(id);
                return tbluser;
            }
            catch
            {
                throw;
            }
        }

        public Users GetUserDataByName(string name)
        {
            try
            {
                Users tbluser = db.Users.SingleOrDefault(U => U.UserLoginName == name);
                return tbluser;
            }
            catch
            {
                throw;
            }
        }


        public int DeleteUser(int id)
        {
            try
            {
                Users emp = db.Users.Find(id);
                db.Users.Remove(emp);
                db.SaveChanges();
                return 1;
            }
            catch
            {
                throw;
            }
        }

    }
}
