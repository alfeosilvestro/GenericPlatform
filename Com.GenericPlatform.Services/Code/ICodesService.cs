using System.Collections.Generic;
using System.Threading.Tasks;
using Com.EzTender.Common;
using Com.EzTender.ViewModels;
using Com.EzTender.ViewModels.Common;
using Com.EzTender.ViewModels.Sys_Setting_Code;

namespace Com.GenericPlatform.Services.Code
{
    public interface ICodesService
    {
        Task<ResponseBase<PagedViewModel<VM_Sys_Setting_Code>>> GetCodesByPage(string keyword, int page);

        ResponseBase<IEnumerable<VM_Sys_Setting_Code>> GetCodesByParentId(int parentId);

        Task<ResponseBase<OperationResult<VM_Sys_Setting_Code>>> GetCodeById(int id);
    }
}