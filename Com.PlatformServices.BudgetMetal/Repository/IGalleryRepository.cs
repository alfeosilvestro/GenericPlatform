using System;
using System.Collections.Generic;
using Com.PlatformServices.Common.DAL.Entities.BudgetMetal;
using Com.PlatformServices.Common.Repository;

namespace Com.PlatformServices.BudgetMetal.Repository
{ 
    public interface IGalleryRepository : IBaseRepository<BM_Gallery>
    {
        IEnumerable<BM_Gallery> GetActiveGallery();
    }
}
