using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD.Infra.Interfaces
{
    public interface IBaseRepository<T> where T : class
    {
        Task<T> Create(T obj);
        Task<T> Remove(long id);
        Task<T> Update(T obj);
        Task<T> Get(long id);
    }
}
