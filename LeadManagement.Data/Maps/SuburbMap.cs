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
        }

        #endregion
    }
}