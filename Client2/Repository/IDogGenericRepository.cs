using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client2.Repository
{
    internal interface IDogGenericRepository <T> where T : class
    {
            T GetbyId(int id);

            bool Add(T entity);

            bool Update(T entity);

            bool Delete(T entity);
            string GetColumnValues(bool excludeKey = true);
        
    }
}
