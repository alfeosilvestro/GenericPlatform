using System;
using Com.PlatformServices.Common.Repository;
using Com.PlatformServices.Common.DAL.Entities.SystemSettings;
using Com.PlatformServices.Common.DAL;
using Microsoft.Extensions.Logging;

namespace Com.PlatformServices.SystemSettings.Repository
{
    public class CodeRepository : BaseRepository<Sys_Setting_Code>, ICodeRepository
    {
        public CodeRepository(AppDbContext context, ILoggerFactory loggerFactory): 
        base(context, loggerFactory, "Sys_Setting_Code_Repository")
        {

        }


    }
}
