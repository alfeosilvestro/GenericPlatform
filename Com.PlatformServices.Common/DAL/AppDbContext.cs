﻿using System;
using Microsoft.EntityFrameworkCore;
using Com.PlatformServices.Common.DAL.Entities.SystemSettings;
using Com.PlatformServices.Common.DAL.Entities.SystemUser;

namespace Com.PlatformServices.Common.DAL
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public virtual DbSet<Sys_Setting_Code> Codes { get; set; }
        public virtual DbSet<Sys_User_Role> UserRoles { get; set; }

    }
}
