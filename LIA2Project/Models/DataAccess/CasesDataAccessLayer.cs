using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LIA2Project.Models.DataAccess
{
    public class CasesDataAccessLayer
    {


        DuoSTATIONContext db = new DuoSTATIONContext();

        public IEnumerable<Cases> GetAllCases()
        {
            try
            {
                return db.Cases.ToList();
            }
            catch
            {
                throw;
            }
        }

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

        public IEnumerable<CaseDevices> GetAllDevices()
        {
            try
            {
                return db.CaseDevices.ToList();
            }
            catch
            {
                throw;
            }
        }


        //To Add new employee record     
        public int AddCase(Cases cases)
        {
            try
            {
                db.Cases.Add(cases);
                db.SaveChanges();
                return 1;
            }
            catch
            {
                throw;
            }
        }

        //To Update the records of a particluar employee    
        public int UpdateCase(Cases tblcase)
        {
            try
            {
                db.Entry(tblcase).State = EntityState.Modified;
                db.SaveChanges();

                return 1;
            }
            catch
            {
                throw;
            }
        }
        //To Update the records of a particluar device    
        public int UpdateDevice(CaseDevices tbldevice)
        {
            try
            {
                db.Entry(tbldevice).State = EntityState.Modified;
                db.SaveChanges();

                return 1;
            }
            catch
            {
                throw;
            }
        }



        //Get the details of a particular case   
        public Cases GetCaseData(int id)
        {
            try
            {
                Cases tblcase = db.Cases.Find(id);
                return tblcase;
            }
            catch
            {
                throw;
            }
        }
        //Get the details of a particular user
        public Users GetUserData(int id)
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
        //Get the details of a particular device   
        public CaseDevices GetDeviceData(int id)
        {
            try
            {
                CaseDevices tblcasedevice = db.CaseDevices.Find(id);
                return tblcasedevice;
            }
            catch
            {
                throw;
            }
        }


        //To Delete the record of a particular case    
        public int DeleteCase(int id)
        {
            try
            {
                Cases emp = db.Cases.Find(id);
                db.Cases.Remove(emp);
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
