using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcourierRepository
{
    class EmployeeRepository : IEmployeeRepository
    {
        EcourierDbContext context = new EcourierDbContext();

        public List<Employee> GetAll()
        {
            return context.Employees.ToList();
        }

        public Employee Get(int id)
        {
            return context.Employees.SingleOrDefault(e => e.EId == id);
        }

        public int Insert(Employee employee)
        {
            employee.Estatus = "valid";
            context.Employees.Add(employee);
            return context.SaveChanges();
        }

        public int Update(Employee employee)
        {
            Employee employeeToUpdate = context.Employees.SingleOrDefault(e => e.EId == employee.EId);
            employeeToUpdate.EAddress = employee.EAddress;
            employeeToUpdate.ECity = employee.ECity;
            employeeToUpdate.EContactNo = employee.EContactNo;
            employeeToUpdate.EDob = employee.EDob;
            employeeToUpdate.EEmail = employee.EEmail;
            employeeToUpdate.EGender = employee.EGender;
            employeeToUpdate.EName = employee.EName;
            employeeToUpdate.Estatus = employee.Estatus;
            return context.SaveChanges();
        }

        public int Delete(int id)
        {
            Employee employeeToDelete = context.Employees.SingleOrDefault(e => e.EId == id);
            context.Employees.Remove(employeeToDelete);
            return context.SaveChanges();
        }
    }
}
