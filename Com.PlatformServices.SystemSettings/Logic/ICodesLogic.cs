using System.Collections.Generic;
using System.Threading.Tasks;
using Com.PlatformServices.Common.DAL.Entities.SystemSettings;
using Com.PlatformServices.Common.FoundationClasses;

namespace Com.PlatformServices.SystemSettings.Logic
{
    public interface ICodesLogic
    {
        Task<ResponseBase<PagedResult<Sys_Setting_Code>>> GetCodesByPage(string keyword, int page);

        ResponseBase<IEnumerable<Sys_Setting_Code>> GetCodesByParentId(int parentId);
    }
}