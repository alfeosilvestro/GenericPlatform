using Com.EzTender.DataModel.Base;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Com.EzTender.DataModel.Base
{
    public interface IGenericRepository<T> where T : GenericEntity
    {
        T Add(T entity);
        T Update(T entity);
        void Delete(T entity);
        
        Task<T> Get(int id);
        IEnumerable<T> GetAll();
        Task<PagedResult<T>> GetPage(string keyword, int page, int totalRecords = 10);

        void Commit();
    }
}
