using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMS.Repositories
{
    public class Repository<T> : IRepository<T>
    {
        public List<T> getAllData<T>()
        {
            throw new NotImplementedException();
        }

        public T getById<T>(int id)
        {
            throw new NotImplementedException();
        }
    }
}
