using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcourierRepository
{
    class ProductRepository : IProductRepository
    {
        EcourierDbContext context = new EcourierDbContext();

        public List<Product> GetAll()
        {
            return context.Products.ToList();
        }

        public Product Get(int id)
        {
            return context.Products.SingleOrDefault(p => p.PId == id);
        }

        public int Insert(Product product)
        {
            context.Products.Add(product);
            return context.SaveChanges();
        }

        public int Update(Product product)
        {
            Product productToUpdate = context.Products.SingleOrDefault(p => p.PId == product.PId);
            productToUpdate.Category = product.Category;
            productToUpdate.WeightRange = product.WeightRange;
            productToUpdate.Price = product.Price;
            return context.SaveChanges();
        }

        public int Delete(int id)
        {
            Product productToDelete = context.Products.SingleOrDefault(p => p.PId == id);
            context.Products.Remove(productToDelete);
            return context.SaveChanges();
        }
    }
}
