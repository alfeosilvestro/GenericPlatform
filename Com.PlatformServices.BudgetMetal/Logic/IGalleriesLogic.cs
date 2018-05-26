using System.Collections.Generic;
using System.Threading.Tasks;
using Com.PlatformServices.Common.DAL.Entities.BudgetMetal;
using Com.PlatformServices.Common.FoundationClasses;

namespace Com.PlatformServices.BudgetMetal.Logic
{
    public interface IGalleriesLogic
    {
        Task<ResponseBase<PagedResult<BM_Gallery>>> GetGalleriesByPage(string keyword, int page);

        ResponseBase<IEnumerable<BM_Gallery>> GetActiveGallery();

        Task<ResponseBase<OperationResult<BM_Gallery>>> GetGalleryById(int id);
    }
}
