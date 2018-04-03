using Com.PlatformServices.Common.DAL;
using Com.PlatformServices.Common.DAL.Entities.FileSystem;
using Com.PlatformServices.Common.FoundationClasses;
using Com.PlatformServices.Common.Repository;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Com.PlatformServices.FileSystem.Repository
{
    public class FileSystemRepository : BaseRepository<Sys_File_System>, IFileSystemRepository
    {
        public FileSystemRepository(AppDbContext context, ILoggerFactory loggerFactory) :
        base(context, loggerFactory, "Sys_File_System_Repository")
        {

        }

        public override async Task<PagedResult<Sys_File_System>> GetPage(string keyword, int page, int totalRecords = 10)
        {
            if (string.IsNullOrEmpty(keyword.Trim()))
            {
                return await base.GetPage(keyword, page, totalRecords);
            }

            var records = this.entities.Where(e =>
                e.OriginalFileName.Contains(keyword) ||
                e.FileDescription.Contains(keyword) ||
                e.FileName.Contains(keyword)
            );
            
            var recordList = records.OrderBy(e => e.FileName)
            .Skip((totalRecords * page) - totalRecords)
            .Take(totalRecords)
            .ToList();

            var count = records.Count();

            var result = new PagedResult<Sys_File_System>()
            {
                Records = recordList,
                TotalPage = (count + totalRecords - 1) / totalRecords,
                CurrentPage = page,
                TotalRecords = count
            };

            return result;
            
        }

    }
}
