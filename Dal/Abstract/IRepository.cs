using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Dal.Abstract
{
    public interface IRepository<T>
    {
        int Insert(T p);
        int Update(T p);
        int Delete(T p);

        List<T> List();

        T GetById(int Id);

        T Find(Expression<Func<T, bool>> where);
        List<T> ListWithParameters(Expression<Func<T, bool>> expression);
    }
}
