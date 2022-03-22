using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Threading.Tasks;
using CodewarsBack.Models;
using Microsoft.EntityFrameworkCore;

namespace CodewarsBack.Services.Context
{
    public class DataContext: DbContext
    {
        public DbSet<UserModel>UserInfo{get;set;}
        public DbSet<ReserveModel> ReserveInfo {get; set;}

        public DataContext (DbContextOptions options) : base (options) {}

        protected override void onModelCreating(ModuleBuilder builder)
        {
            base.onModelCreating(builder);
        }
    }
}