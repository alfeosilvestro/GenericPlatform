using System.Collections.Generic;
using System.Threading.Tasks;
using Com.PlatformServices.Common.DAL.Entities.FileSystem;
using Com.PlatformServices.Common.FoundationClasses;

namespace Com.PlatformServices.FileSystem.Logic
{
    public interface IFileSystemLogic
    {
        Task<ResponseBase<PagedResult<Sys_File_System>>> GetFilesByPage(string keyword, int page);

        Task<OperationResult<Sys_File_System>> GetFileById(int id);
        Task<OperationResult<Sys_File_System>> DeleteFileById(int id);
        Task<List<Sys_File_System>> GetFileByReference(string applicationId, string reference1, string reference2, string reference3);
    }
}