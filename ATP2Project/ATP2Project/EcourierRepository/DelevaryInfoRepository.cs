using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcourierRepository
{
    class DelevaryInfoRepository : IDelevaryInfoRepository
    {
        EcourierDbContext context = new EcourierDbContext();

        public List<DelevaryInfo> GetAll()
        {
            return context.DelevaryInfos.ToList();
        }

        public DelevaryInfo Get(int id)
        {
            return context.DelevaryInfos.SingleOrDefault(d => d.DId == id);
        }

        public int Insert(DelevaryInfo delevaryInfo)
        {
            context.DelevaryInfos.Add(delevaryInfo);
            return context.SaveChanges();
        }

        public int Update(DelevaryInfo delevaryInfo)
        {
            DelevaryInfo delevaryInfoToUpdate = context.DelevaryInfos.SingleOrDefault(i => i.DId == delevaryInfo.DId);
            delevaryInfoToUpdate.DelevaryAddress = delevaryInfo.DelevaryAddress;
            delevaryInfoToUpdate.DelevaryCity = delevaryInfo.DelevaryCity;
            delevaryInfoToUpdate.DelevaryStatus = delevaryInfo.DelevaryStatus;
            delevaryInfoToUpdate.Pcategory = delevaryInfo.Pcategory;
            delevaryInfoToUpdate.PickUpAddress = delevaryInfo.PickUpAddress;
            delevaryInfoToUpdate.PickUpCity = delevaryInfo.PickUpCity;
            delevaryInfoToUpdate.price = delevaryInfo.price;
            delevaryInfoToUpdate.weight = delevaryInfo.weight;
            return context.SaveChanges();
        }

        public int Delete(int id)
        {
            DelevaryInfo delevaryInfoToDelete = context.DelevaryInfos.SingleOrDefault(d => d.DId == id);
            context.DelevaryInfos.Remove(delevaryInfoToDelete);
            return context.SaveChanges();
        }
    }
}
