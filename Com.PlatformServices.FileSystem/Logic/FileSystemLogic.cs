using Com.PlatformServices.Common.DAL.Entities.FileSystem;
using Com.PlatformServices.Common.DAL.Entities.SystemSettings;
using Com.PlatformServices.Common.FoundationClasses;
using Com.PlatformServices.FileSystem.Configurations;
using Com.PlatformServices.FileSystem.Repository;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Com.PlatformServices.FileSystem.Logic
{
    public class FileSystemLogic : IFileSystemLogic
    {
        private readonly AppSettings config;
        private readonly IFileSystemRepository repo;

        public FileSystemLogic(IOptions<AppSettings> config, IFileSystemRepository repo)
        {
            this.config = config.Value;
            this.repo = repo;
        }

        public async Task<ResponseBase<PagedResult<Sys_File_System>>> GetFilesByPage(string keyword, int page)
        {
            var dbResult = await repo.GetPage(keyword, page);

            ResponseBase<PagedResult<Sys_File_System>> result = new ResponseBase<PagedResult<Sys_File_System>>(config.App_Identity);
            result.ResultObject = dbResult;
            return result;
        }

        public async Task<OperationResult<Sys_File_System>> GetFileById(int id)
        {
            var result = await repo.Get(id);

            return result;
        }

        public async Task<OperationResult<Sys_File_System>> DeleteFileById(int id)
        {
            var fileToDeleteResult = await repo.Get(id);

            if (fileToDeleteResult.IsSuccessful && fileToDeleteResult.ResultObject != null)
            {
                var deleteResult = await repo.Delete(fileToDeleteResult.ResultObject);

                return deleteResult;
            }
            else
            {
                return new OperationResult<Sys_File_System>()
                {
                    IsSuccessful = false,
                    Message = "File not found",
                    Error = new System.IO.FileNotFoundException("File with provided id, " + id + ", does not exist in database")
                };
            }
        }
    }
}
