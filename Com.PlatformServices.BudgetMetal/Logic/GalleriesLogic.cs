using Com.PlatformServices.Common.DAL.Entities.BudgetMetal;
using Com.PlatformServices.Common.FoundationClasses;
using Com.PlatformServices.BudgetMetal.Configurations;
using Com.PlatformServices.BudgetMetal.Repository;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Com.PlatformServices.BudgetMetal.Logic
{
    public class GalleriesLogic : IGalleriesLogic
    {
        private readonly AppSettings config;
        private readonly IGalleryRepository repo;

        public GalleriesLogic(IOptions<AppSettings> config, IGalleryRepository repo)
        {
            this.config = config.Value;
            this.repo = repo;
        }

        public async Task<ResponseBase<OperationResult<BM_Gallery>>> GetGalleryById(int id)
        {
            var dbResult = await repo.Get(id);

            ResponseBase<OperationResult<BM_Gallery>> result = new ResponseBase<OperationResult<BM_Gallery>>(config.App_Identity);
            result.ResultObject = dbResult;

            return result;
        }

        public async Task<ResponseBase<PagedResult<BM_Gallery>>> GetGalleriesByPage(string keyword, int page)
        {
            var dbResult = await repo.GetPage(keyword, page);

            ResponseBase<PagedResult<BM_Gallery>> result = new ResponseBase<PagedResult<BM_Gallery>>(config.App_Identity);
            result.ResultObject = dbResult;

            return result;
        }

        public ResponseBase<IEnumerable<BM_Gallery>> GetActiveGallery()
        {
            return new ResponseBase<IEnumerable<BM_Gallery>>(config.App_Identity)
            {
                ResultObject = repo.GetActiveGallery()
            };
        }
    }
}
