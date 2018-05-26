﻿using Com.EzTender.DataModel.Base;
using Com.EzTender.Repository.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Com.EzTender.Repository.Base
{
    public class GenericRepository<T> : IGenericRepository<T> where T : GenericEntity
    {
        protected readonly DatabaseContext DbContext;
        protected readonly ILogger repoLogger;

        protected DbSet<T> entities;

        string errorMessage = string.Empty;

        public GenericRepository(DatabaseContext context, ILoggerFactory loggerFactory, string childClassName)
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

        public async Task<T> Get(int id)
        {
            repoLogger.LogDebug("Get by id " + id, null);

            var result = entities.SingleOrDefault(s => s.Id == id && s.IsActive == true);

            return result;
        }

        public void Commit()
        {
            this.DbContext.SaveChanges();
        }

        public T Add(T entity)
        {
            if (entity == null)
            {
                repoLogger.LogError("Cannot insert entiry as entity is null", null);
                throw new ArgumentNullException("entity");
            }

            entities.Add(entity);

            var result = entity;

            return result;
        }

        public T Update(T entity)
        {
            if (entity == null)
            {
                repoLogger.LogError("Cannot insert entiry as entity is null", null);
                throw new ArgumentNullException("entity");
            }

            var result = entity;

            return result;
        }

        public void Delete(T entity)
        {
            if (entity == null)
            {
                repoLogger.LogError("Cannot insert entiry as entity is null", null);
                throw new ArgumentNullException("entity");
            }

            entities.Remove(entity);
           
        }

        public virtual async Task<PagedResult<T>> GetPage(string keyword, int page, int totalRecords = 10)
        {
            var records = await entities.Where(e => e.IsActive == true)
                           .OrderBy(e => e.CreatedDate)
                           .Skip((totalRecords * page) - totalRecords)
                           .Take(totalRecords)
                           .ToListAsync<T>();

            int count = await entities.CountAsync(e => e.IsActive == true);

            var result = new PagedResult<T>()
            {
                Records = records,
                TotalPage = (count + totalRecords - 1) / totalRecords,
                CurrentPage = page,
                TotalRecords = count
            };

            return result;
        }
    }
}
