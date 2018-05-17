using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcourierRepository
{
    public interface IEmployeeRepository
    {
        List<Employee> GetAll();
        Employee Get(int id);
        int Insert(Employee employee);
        int Update(Employee employee);
        int Delete(int id);
    }
}
