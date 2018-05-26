using System;
using System.Collections.Generic;
using Com.EzTender.DataModel;
using Com.EzTender.DataModel.Base;

namespace Com.EzTender.Repository
{
    public interface ICodeRepository : IGenericRepository<Sys_Setting_Code>
    {
        IEnumerable<Sys_Setting_Code> GetCodesByParentId(int parentId);
    }
}
