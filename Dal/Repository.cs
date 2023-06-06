using Dal.Abstract;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Dal
{
    public class Repository<T> : IRepository<T> where T:class
    {
        Context context = new Context();
        DbSet<T> _object;

        public Repository()
        {
            
            _object =context.Set<T>();
        }

        public int Delete(T p)
        {
            _object.Remove(p);
            return context.SaveChanges();
        }

        public T Find(Expression<Func<T, bool>> where)
        {
           return _object.FirstOrDefault(where);
        }

        public T GetById(int Id)
        {
            return _object.Find(Id);
        }

        public int Insert(T p)
        {
            _object.Add(p);
           return context.SaveChanges();
        }

        public List<T> List()
        {
            return  _object.ToList();
        }

        public List<T> ListWithParameters(Expression<Func<T, bool>> expression)
        {
            return _object.Where(expression).ToList();
        }

        public int Update(T p)
        {
            _object.AddOrUpdate(p);
            return  context.SaveChanges();
        }

        
    }
}
