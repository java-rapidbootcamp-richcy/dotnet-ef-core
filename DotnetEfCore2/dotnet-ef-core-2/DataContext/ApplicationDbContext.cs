using Microsoft.EntityFrameworkCore;
using System;
using System.Security.Policy;

namespace dotnet_ef_core_2.DataContext
{
    public class ApplicationDbContext : DbContext
    {
        // injection
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<CategoryEntity> CategoryEntities => Set<CategoryEntity>();
        public DbSet<AssetEntity> AssetEntities => Set<AssetEntity>();

    }

}
