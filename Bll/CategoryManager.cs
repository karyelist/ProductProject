using Dal;
using Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Bll
{
    public class CategoryManager
    {
        Repository<Category> repoCat = new Repository<Category>();

        public List<Category> GetAll()
        {

            return repoCat.List();
        }

        public int BllAdd(Category c)
        {
            if(c.CategoryName.Length<=3)
            {
                return -1;
            }

            return repoCat.Insert(c);
        }

        public int BllDelete(int Id)
        {
           if(Id<0)
            {
                Category c = repoCat.Find(x => x.Id == Id);
                return repoCat.Delete(c);
            }
            else
            {
                return -1;
            }
        }

        public  int BllUpdate(Category c)
        {
            if(c.CategoryName=="" || c.CategoryName.Length<=3)
            {
                return -1;

            }
            else
            {
                Category newC = repoCat.Find(x => x.Id == c.Id);
                newC.CategoryName = c.CategoryName; 
                return repoCat.Update(newC);
            }
        }
    }
}
