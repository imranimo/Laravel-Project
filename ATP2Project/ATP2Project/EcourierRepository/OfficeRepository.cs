using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcourierRepository
{
    class OfficeRepository : IOfficeRepository
    {
        EcourierDbContext context = new EcourierDbContext();

        public List<Office> GetAll()
        {
            return context.Offices.ToList();
        }

        public Office Get(int id)
        {
            return context.Offices.SingleOrDefault(o => o.OfficeId == id);
        }

        public int Insert(Office office)
        {
            context.Offices.Add(office);
            return context.SaveChanges();
        }

        public int Update(Office office)
        {
            Office officeToUpdate = context.Offices.SingleOrDefault(u => u.OfficeId == office.OfficeId);
            officeToUpdate.ContactNo = office.ContactNo;
            officeToUpdate.EmployeeName = office.EmployeeName;
            officeToUpdate.PostmanName = office.PostmanName;
            officeToUpdate.City = office.City;
            officeToUpdate.Address = office.Address;
            return context.SaveChanges();
        }

        public int Delete(int id)
        {
            Office officeToDelete = context.Offices.SingleOrDefault(o => o.OfficeId == id);
            context.Offices.Remove(officeToDelete);
            return context.SaveChanges();
        }
    }
}
