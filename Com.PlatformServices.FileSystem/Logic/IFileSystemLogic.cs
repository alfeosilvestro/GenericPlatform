using System.Collections.Generic;
using System.Threading.Tasks;
using Com.PlatformServices.Common.DAL.Entities.FileSystem;
using Com.PlatformServices.Common.FoundationClasses;

namespace Com.PlatformServices.FileSystem.Logic
{
    public interface IFileSystemLogic
    {
        ResponseBase<IEnumerable<Sys_File_System>> GetFilesByPage(string keyword, int page);

        Task<OperationResult<Sys_File_System>> GetFileById(int id);
    }
}