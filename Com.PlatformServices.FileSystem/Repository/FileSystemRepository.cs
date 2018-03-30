using Com.PlatformServices.Common.DAL;
using Com.PlatformServices.Common.DAL.Entities.FileSystem;
using Com.PlatformServices.Common.Repository;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Com.PlatformServices.FileSystem.Repository
{
    public class FileSystemRepository : BaseRepository<Sys_File_System>, IFileSystemRepository
    {
        public FileSystemRepository(AppDbContext context, ILoggerFactory loggerFactory) :
        base(context, loggerFactory, "Sys_File_System_Repository")
        {

        }


    }
}
