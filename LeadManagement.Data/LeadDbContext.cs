using LeadManagement.Data.Maps;
using LeadManagement.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace LeadManagement.Data
{
    public class LeadDbContext : DbContext
    {
        #region DbSets

        public DbSet<JobModel> JobModels { get; set; }

        public DbSet<CategoryModel> CategoryModels { get; set; }

        public DbSet<SuburbModel> SuburbModels { get; set; }

        #endregion

        #region Configurations

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            new SuburbMap(modelBuilder.Entity<SuburbModel>());
            new CategoryMap(modelBuilder.Entity<CategoryModel>());
            new JobMap(modelBuilder.Entity<JobModel>());
        }

        #endregion
    }
}