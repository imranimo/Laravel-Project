using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcourierRepository
{
    public interface IOfficeRepository
    {
        List<Office> GetAll();
        Office Get(int id);
        int Insert(Office office);
        int Update(Office office);
        int Delete(int id);
    }
}
