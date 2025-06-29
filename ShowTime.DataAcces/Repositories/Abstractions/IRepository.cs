using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShowTime.DataAcces.Repositories.Abstractions
{
    public interface IRepository<T> where T:class
    {
        Task<ICollection<T>> GetAll();

        Task<T> GetById(int id);

        Task DeleteById(int id);

        Task Add(T entity);

        Task Update(T entity);


    }
}
