using System;
using System.Collections.Generic;
using System.Text;

namespace HRLeaveManagement.Application.Presistence.Contracts
{
    public interface  IGenericRepository<T> where T : class
    {
        Task<T> Get(int  id);
        Task<IReadOnlyList<T>> GetAll();
        //Task<IReadOnlyCollection<T>> GetAll();
        Task<T> Add(T entity);
        Task<bool> Exist(int id);
        Task Update(T entity);
        Task Delete(int id);

    }
}
