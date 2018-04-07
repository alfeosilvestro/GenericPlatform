using Com.PlatformServices.Common.DAL.Entities.SystemSettings;
using Com.PlatformServices.Common.FoundationClasses;
using Com.PlatformServices.SystemSettings.Configurations;
using Com.PlatformServices.SystemSettings.Repository;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Com.PlatformServices.SystemSettings.Logic
{
    public class CodesLogic : ICodesLogic
    {
        private readonly AppSettings config;
        private readonly ICodeRepository repo;

        public CodesLogic(IOptions<AppSettings> config, ICodeRepository repo)
        {
            this.config = config.Value;
            this.repo = repo;
        }

        public async Task<ResponseBase<OperationResult<Sys_Setting_Code>>> GetCodeById(int id)
        {
            var dbResult = await repo.Get(id);

            ResponseBase<OperationResult<Sys_Setting_Code>> result = new ResponseBase<OperationResult<Sys_Setting_Code>>(config.App_Identity);
            result.ResultObject = dbResult;

            return result;
        }

        public async Task<ResponseBase<PagedResult<Sys_Setting_Code>>> GetCodesByPage(string keyword, int page)
        {
            var dbResult = await repo.GetPage(keyword, page);

            ResponseBase<PagedResult<Sys_Setting_Code>> result = new ResponseBase<PagedResult<Sys_Setting_Code>>(config.App_Identity);
            result.ResultObject = dbResult;

            return result;
        }

        public ResponseBase<IEnumerable<Sys_Setting_Code>> GetCodesByParentId(int parentId)
        {
            return new ResponseBase<IEnumerable<Sys_Setting_Code>>(config.App_Identity) {
                ResultObject = repo.GetCodesByParentId(parentId)
            };
        }
    }
}
