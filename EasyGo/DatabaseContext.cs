﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.Entity;
using System.Runtime.Remoting.Contexts;
namespace EasyGo
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // Configure additional settings here if necessary
            base.OnModelCreating(modelBuilder);
        }
    }
}