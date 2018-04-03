using Com.PlatformServices.Common.DAL.Entities.FileSystem;
using Com.PlatformServices.Common.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Com.PlatformServices.FileSystem.Repository
{
    public interface IFileSystemRepository : IBaseRepository<Sys_File_System>
    {
        Task<List<Sys_File_System>> GetFileByReference(string applicationId, string reference1, string reference2, string reference3);
    }
}
