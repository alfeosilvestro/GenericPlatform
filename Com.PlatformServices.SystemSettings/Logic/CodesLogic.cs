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

        public ResponseBase<IEnumerable<Sys_Setting_Code>> GetCodesByPage(string keyword, int page)
        {
            var dbResult = repo.GetAll();

            ResponseBase<IEnumerable<Sys_Setting_Code>> result = new ResponseBase<IEnumerable<Sys_Setting_Code>>(config.App_Identity);
            result.ResultObject = dbResult;

            return result;
        }
    }
}
