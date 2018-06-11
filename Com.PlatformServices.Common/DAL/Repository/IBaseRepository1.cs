using Com.PlatformServices.Common.FoundationClasses;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Com.PlatformServices.Common.Repository
{
    public interface IBaseEntity<T> where T : BaseEntity
    {
        OperationResult<T> Add(T entity);
        OperationResult<T> Update(T entity);
        Task<OperationResult<T>> Delete(T entity);
        Task<OperationResult<T>> Get(int id);
        IEnumerable<T> GetAll();
        Task<PagedResult<T>> GetPage(string keyword, int page, int totalRecords = 10);
    }

    public interface IBaseRepository<T> where T : BaseEntity
    {
        OperationResult<T> Add(T entity);
        OperationResult<T> Update(T entity);
        Task<OperationResult<T>> Delete(T entity);
        Task<OperationResult<T>> Get(int id);
        IEnumerable<T> GetAll();
        Task<PagedResult<T>> GetPage(string keyword, int page, int totalRecords = 10);
    }
}