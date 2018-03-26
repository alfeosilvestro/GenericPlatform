using System;
using System.Collections.Generic;
using System.Linq;
using Com.PlatformServices.Common.DAL;
using Com.PlatformServices.Common.FoundationClasses;
using Com.PlatformServices.Common.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace Com.PlatformServices.Common.Repository
{
    public class BaseRepository<T> : IBaseRepository<T> where T : BaseEntity
    {
        protected readonly AppDbContext DbContext;
        protected readonly ILogger repoLogger;

        protected DbSet<T> entities;

        string errorMessage = string.Empty;

        public BaseRepository(AppDbContext context, ILoggerFactory loggerFactory, string childClassName)
        {
            this.DbContext = context;
            entities = context.Set<T>();
            repoLogger = loggerFactory.CreateLogger(childClassName);
        }

        public IEnumerable<T> GetAll()
        {
            repoLogger.LogDebug("GetAll", null);
            return entities.Where(s => s.IsActive == true).ToList();
        }

        public OperationResult<T> Get(int id)
        {
            repoLogger.LogDebug("Get by id " + id, null);

            var result = new OperationResult<T>()
            {
                IsSuccessful = true,
                Message = "Successfully updated.",
                ResultObject = (entities.SingleOrDefault(s => s.Id == id && s.IsActive == true))
            };

            return result;
        }

        public OperationResult<T> Add(T entity)
        {
            if (entity == null)
            {
                repoLogger.LogError("Cannot insert entiry as entity is null", null);
                throw new ArgumentNullException("entity");
            }

            entities.Add(entity);
            this.DbContext.SaveChanges();

            var result = new OperationResult<T>() { 
                IsSuccessful = true, 
                Message = "Successfully saved.", 
                ResultObject = entity 
            };

            return result;
        }

        public OperationResult<T> Update(T entity)
        {
            if (entity == null)
            {
                repoLogger.LogError("Cannot insert entiry as entity is null", null);
                throw new ArgumentNullException("entity");
            }

            this.DbContext.SaveChanges();

            var result = new OperationResult<T>()
            {
                IsSuccessful = true,
                Message = "Successfully updated.",
                ResultObject = entity
            };

            return result;
        }

        public OperationResult<T> Delete(T entity)
        {
            if (entity == null)
            {
                repoLogger.LogError("Cannot insert entiry as entity is null", null);
                throw new ArgumentNullException("entity");
            }
            entities.Remove(entity);
            this.DbContext.SaveChanges();

            var result = new OperationResult<T>()
            {
                IsSuccessful = true,
                Message = "Successfully deleted."
            };

            return result;
        }

        public virtual IEnumerable<T> GetPage(string keyword, int totalRecords, int page)
        {
            return entities.Where(e => e.IsActive == true)
                           .Skip((totalRecords * page) - totalRecords);
        }
    }
}
