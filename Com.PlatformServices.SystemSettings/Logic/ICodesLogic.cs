using System.Collections.Generic;
using Com.PlatformServices.Common.DAL.Entities.SystemSettings;
using Com.PlatformServices.Common.FoundationClasses;

namespace Com.PlatformServices.SystemSettings.Logic
{
    public interface ICodesLogic
    {
        ResponseBase<IEnumerable<Sys_Setting_Code>> GetCodesByPage(string keyword, int page);
    }
}