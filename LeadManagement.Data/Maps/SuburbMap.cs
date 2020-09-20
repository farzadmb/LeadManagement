using System.Collections.Generic;

using LeadManagement.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeadManagement.Data.Maps
{
    /// <summary>
    /// The mapper for <see cref="SuburbModel"/>
    /// </summary>
    public class SuburbMap
    {
        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="SuburbMap"/> class.
        /// </summary>
        /// <param name="entityBuilder">
        /// The entity builder
        /// </param>
        public SuburbMap(EntityTypeBuilder<SuburbModel> entityBuilder)
        {
            entityBuilder.HasKey(a => a.Id);
            entityBuilder.ToTable("suburbs");

            entityBuilder.Property(a => a.Id).HasColumnName("id");
            entityBuilder.Property(a => a.Name).HasColumnName("name");
            entityBuilder.Property(a => a.PostCode).HasColumnName("postcode");

            entityBuilder.HasMany(c => c.JobModels).WithOne(j => j.Suburb);

            entityBuilder.HasData(
                new List<SuburbModel>()
                    {
                        new SuburbModel() { Id = 21, Name = "CBD", PostCode = "2000" },
                        new SuburbModel() { Id = 22, Name = "North Sydney", PostCode = "2006" }
                    });
        }

        #endregion
    }
}