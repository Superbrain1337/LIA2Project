﻿using Microsoft.EntityFrameworkCore;
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
