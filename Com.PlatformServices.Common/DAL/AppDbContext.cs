using System;
using Microsoft.EntityFrameworkCore;
using Com.PlatformServices.Common.DAL.Entities.SystemSettings;
using Com.PlatformServices.Common.DAL.Entities.FileSystem;

namespace Com.PlatformServices.Common.DAL
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public virtual DbSet<Sys_Setting_Code> Codes { get; set; }
        public virtual DbSet<Sys_File_System> FileSystems { get; set; }

        public virtual DbSet<Sys_Role> Roles { get; set; }

        public virtual DbSet<Sys_Permission> Permissions { get; set; }

    }
}
