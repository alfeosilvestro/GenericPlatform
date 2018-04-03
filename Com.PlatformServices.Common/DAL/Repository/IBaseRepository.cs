using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Com.PlatformServices.Common.FoundationClasses;

namespace Com.PlatformServices.Common.Repository
{
    public interface IBaseRepository<T> where T : BaseEntity
    {
        OperationResult<T> Add(T entity);
        OperationResult<T> Update(T entity);
        Task<OperationResult<T>> Delete(T entity);
        Task<OperationResult<T>> Get(int id);
        IEnumerable<T> GetAll();
        IEnumerable<T> GetPage(string keyword, int totalRecords, int page);
    }
}
