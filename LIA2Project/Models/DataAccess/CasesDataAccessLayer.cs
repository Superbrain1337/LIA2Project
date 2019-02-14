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


        //To Add new employee record     
        public int AddCase(Cases tblcase)
        {
            try
            {
                db.Cases.Add(tblcase);
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


        //Get the details of a particular employee    
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


        //To Delete the record of a particular employee    
        public int DeleteCase(int id)
        {
            try
            {
                Cases cas = db.Cases.Find(id);
                db.Cases.Remove(cas);
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
