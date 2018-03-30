﻿using Com.PlatformServices.Common.DAL.Entities.FileSystem;
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

        public ResponseBase<IEnumerable<Sys_File_System>> GetFilesByPage(string keyword, int page)
        {
            var dbResult = repo.GetAll();

            ResponseBase<IEnumerable<Sys_File_System>> result = new ResponseBase<IEnumerable<Sys_File_System>>(config.App_Identity);
            result.ResultObject = dbResult;
            return result;
        }

        public async Task<OperationResult<Sys_File_System>> GetFileById(int id)
        {
            var result = await repo.Get(id);

            return result;
        }
    }
}
