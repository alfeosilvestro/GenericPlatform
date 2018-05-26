using System.Linq;
using Com.PlatformServices.Common.Repository;
using Com.PlatformServices.Common.DAL.Entities.BudgetMetal;
using Com.PlatformServices.Common.DAL;
using Microsoft.Extensions.Logging;
using Com.PlatformServices.Common.FoundationClasses;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Com.PlatformServices.BudgetMetal.Repository
{
    public class GalleryRepository : BaseRepository<BM_Gallery>, IGalleryRepository
    {
        public GalleryRepository(AppDbContext context, ILoggerFactory loggerFactory) :
        base(context, loggerFactory, "BM_Gallery_Repository")
        {

        }

        public IEnumerable<BM_Gallery> GetActiveGallery()
        {
            return this.entities.Where(e =>
            e.IsActive == true).ToList();
        }

        public override async Task<PagedResult<BM_Gallery>> GetPage(string keyword, int page, int totalRecords = 10)
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

            var result = new PagedResult<BM_Gallery>()
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
