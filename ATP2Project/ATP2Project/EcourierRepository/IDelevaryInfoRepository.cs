using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcourierRepository
{
    public interface IDelevaryInfoRepository
    {
        List<DelevaryInfo> GetAll();
        DelevaryInfo Get(int id);
        int Insert(DelevaryInfo delevaryInfo);
        int Update(DelevaryInfo delevaryInfo);
        int Delete(int id);
    }
}
