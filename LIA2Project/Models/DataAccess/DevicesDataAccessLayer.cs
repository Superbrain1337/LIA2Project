using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LIA2Project.Models.DataAccess
{
    public class DevicesDataAccessLayer
    {
        DuoSTATIONContext db = new DuoSTATIONContext();
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

        public Inventory GetDeviceInventory(Guid id)
        {
            try
            {
                Inventory tbldeviceinvetory = db.Inventory.Find(id);
                return tbldeviceinvetory;
            }
            catch
            {
                throw;
            }
        }
    }
}
