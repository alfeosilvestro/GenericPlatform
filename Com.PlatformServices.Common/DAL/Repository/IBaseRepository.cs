using System;
using System.Collections.Generic;
using Com.PlatformServices.Common.FoundationClasses;

namespace Com.PlatformServices.Common.Repository
{
    public interface IBaseRepository<T> where T : BaseEntity
    {
        OperationResult<T> Add(T entity);
        OperationResult<T> Update(T entity);
        OperationResult<T> Delete(T entity);
        OperationResult<T> Get(int id);
        IEnumerable<T> GetAll();
        IEnumerable<T> GetPage(string keyword, int totalRecords, int page);
    }
}
