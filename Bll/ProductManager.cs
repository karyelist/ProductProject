using Dal;
using Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bll
{
    public class ProductManager
    {

        Repository<Product> repoProduct = new Repository<Product>();

        public List<Product> GetAll()
        {

            return repoProduct.List();
        }

        public List<Product> GetByName(string p)
        {
            return repoProduct.ListWithParameters(x => x.ProductName == p);

        }
    }
}
