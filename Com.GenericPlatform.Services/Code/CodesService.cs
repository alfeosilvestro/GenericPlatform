using Com.EzTender.Common;
using Com.EzTender.DataModel;
using Com.EzTender.DataModel.Base;
using Com.EzTender.Repository;
using Com.EzTender.ViewModels.Common;
using Com.EzTender.ViewModels.Sys_Setting_Code;
using Com.GenericPlatform.Services.Base;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Com.GenericPlatform.Services.Code
{
    public class CodesService : GenericService, ICodesService
    {
        private readonly AppSettings config;
        private readonly ICodeRepository repo;



        public CodesService(IOptions<AppSettings> config, ICodeRepository repo)
        {
            this.config = config.Value;
            this.repo = repo;
        }

        public async Task<ResponseBase<OperationResult<VM_Sys_Setting_Code>>> GetCodeById(int id)
        {
            var dbResult = await repo.Get(id);

            VM_Sys_Setting_Code resultObj = new VM_Sys_Setting_Code();

            Copy<Sys_Setting_Code, VM_Sys_Setting_Code>(dbResult, resultObj);

            ResponseBase<OperationResult<VM_Sys_Setting_Code>> result = new ResponseBase<OperationResult<VM_Sys_Setting_Code>>(config.App_Identity);
            result.ResultObject = new OperationResult<VM_Sys_Setting_Code>(){
                ResultObject = resultObj
            };

            return result;
        }

        public async Task<ResponseBase<PagedViewModel<VM_Sys_Setting_Code>>> GetCodesByPage(string keyword, int page)
        {
            var dbResult = await repo.GetPage(keyword, page);

            PagedViewModel<VM_Sys_Setting_Code> resultObj = new PagedViewModel<VM_Sys_Setting_Code>();

            Copy< PagedResult<Sys_Setting_Code>, PagedViewModel<VM_Sys_Setting_Code> >(dbResult, resultObj);

            List<VM_Sys_Setting_Code> resultObjList = new List<VM_Sys_Setting_Code>();

            foreach (var item in dbResult.Records)
            {
                VM_Sys_Setting_Code newData = new VM_Sys_Setting_Code();

                Copy<Sys_Setting_Code, VM_Sys_Setting_Code>(item, newData);

                resultObjList.Add(newData);
            }

            resultObj.Records = resultObjList;

            ResponseBase <PagedViewModel<VM_Sys_Setting_Code>> result = new ResponseBase<PagedViewModel<VM_Sys_Setting_Code>>(config.App_Identity);
            result.ResultObject = resultObj;

            return result;
        }

        public ResponseBase<IEnumerable<VM_Sys_Setting_Code>> GetCodesByParentId(int parentId)
        {
            var result = repo.GetCodesByParentId(parentId);

            List<VM_Sys_Setting_Code> resultObj = new List<VM_Sys_Setting_Code>();

            foreach (var item in result)
            {
                VM_Sys_Setting_Code newData = new VM_Sys_Setting_Code();

                Copy<Sys_Setting_Code, VM_Sys_Setting_Code>(item, newData);

                resultObj.Add(newData);
            }

            return new ResponseBase<IEnumerable<VM_Sys_Setting_Code>>(config.App_Identity) {
                ResultObject = resultObj
            };
        }
    }
}
