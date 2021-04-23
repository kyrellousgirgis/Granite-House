using final_MVC_Test.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace final_MVC_Test.Services
{
    public interface IProductTypeRepoService
    {
        public List<ProductType> GetAll();
        public ProductType GetById(int id);
        public void Delete(int id);
        public void Create(ProductType productType);
        public void Edit(int id,ProductType productType);

    }
}
