using Com.EzTender.DataModel;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Com.EzTender.Repository.Context
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {

        }

        public virtual DbSet<Sys_Setting_Code> Codes { get; set; }
        public virtual DbSet<Sys_File_System> FileSystems { get; set; }

        public virtual DbSet<Sys_Role> Roles { get; set; }

        public virtual DbSet<Sys_Permission> Permissions { get; set; }
        public virtual DbSet<Sys_User_Role> UserRoles { get; set; }

        public virtual DbSet<Sys_Logger> Loggers { get; set; }
    }
}
