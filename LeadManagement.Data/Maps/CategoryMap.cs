using System.Collections.Generic;

using LeadManagement.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeadManagement.Data.Maps
{
    /// <summary>
    /// The mapper for <see cref="CategoryModel"/>
    /// </summary>
    public class CategoryMap
    {
        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="CategoryMap"/> class.
        /// </summary>
        /// <param name="entityBuilder">
        /// The entity builder
        /// </param>
        public CategoryMap(EntityTypeBuilder<CategoryModel> entityBuilder)
        {
            entityBuilder.HasKey(a => a.Id);
            entityBuilder.ToTable("categories");

            entityBuilder.Property(a => a.Id).HasColumnName("id");
            entityBuilder.Property(a => a.Name).HasColumnName("name");

            entityBuilder.HasMany(c => c.JobModels).WithOne(j => j.Category);

            entityBuilder.HasData(new List<CategoryModel>() { new CategoryModel() { Id = 1, Name = "Plumbing" } });
        }

        #endregion
    }
}