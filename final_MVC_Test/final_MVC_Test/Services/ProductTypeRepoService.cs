using final_MVC_Test.Data;
using final_MVC_Test.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace final_MVC_Test.Services
{
    public class ProductTypeRepoService : IProductTypeRepoService
    {
        private readonly ApplicationDbContext db;

        public ProductTypeRepoService(ApplicationDbContext db)
        {
            this.db = db;
        }
        public void Create(ProductType productType)
        {
            db.ProductTypes.Add(productType);
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            var producType = db.ProductTypes.Find(id);
            if(producType is not null)
            {
                db.ProductTypes.Remove(producType);
                db.SaveChanges();

            }
            else
            {
                throw new Exception();
            }
        }

        public void Edit(int id, ProductType productType)
        {
            if (productType is not null)
            {
                if (id == productType.Id)
                {
                    var prodType = db.ProductTypes.Local.FirstOrDefault(pt=>pt.Id == id);
                    prodType = productType;
                    db.Entry<ProductType>(prodType).State = EntityState.Modified;
                    db.SaveChanges();

                }
                else
                {
                    throw new Exception();
                }
            }
            else
            {
                    throw new Exception();
            }
        }

        public List<ProductType> GetAll()
        {
            return db.ProductTypes.ToList();
        }

        public ProductType GetById(int id)
        {
            return db.ProductTypes.Find(id);
        }
    }
}
