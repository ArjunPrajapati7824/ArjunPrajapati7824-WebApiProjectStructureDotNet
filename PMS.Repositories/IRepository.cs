using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMS.Repositories
{
    public interface IRepository<T>
    {
        List<T> getAllData<T>();
        T getById<T>(int id);
    }
}
