using System.Linq;
using Com.PlatformServices.Common.Repository;
using Com.PlatformServices.Common.DAL.Entities.SystemSettings;
using Com.PlatformServices.Common.DAL;
using Microsoft.Extensions.Logging;
using Com.PlatformServices.Common.FoundationClasses;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Com.PlatformServices.SystemSettings.Repository
{
    public class CodeRepository : BaseRepository<Sys_Setting_Code>, ICodeRepository
    {
        public CodeRepository(AppDbContext context, ILoggerFactory loggerFactory): 
        base(context, loggerFactory, "Sys_Setting_Code_Repository")
        {

        }

        public IEnumerable<Sys_Setting_Code> GetCodesByParentId(int parentId)
        {
            return this.entities.Where(e =>
            e.Parent.Id == parentId).ToList();
        }

        public override async Task<PagedResult<Sys_Setting_Code>> GetPage(string keyword, int page, int totalRecords = 10)
        {
            if (string.IsNullOrEmpty(keyword.Trim()))
            {
                return await base.GetPage(keyword, page, totalRecords);
            }

            var records = this.entities.Where(e =>
                e.Name.Contains(keyword) ||
                e.Description.Contains(keyword)
            );

            var recordList = records.OrderBy(e => e.Name)
            .OrderBy(e => e.CreatedDate)
            .Skip((totalRecords * page) - totalRecords)
            .Take(totalRecords)
            .ToList();

            var count = records.Count();

            var result = new PagedResult<Sys_Setting_Code>()
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
