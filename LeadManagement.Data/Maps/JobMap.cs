using LeadManagement.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeadManagement.Data.Maps
{
    /// <summary>
    /// The mapper for <see cref="JobModel"/>
    /// </summary>
    public class JobMap
    {
        #region Constructor

        public JobMap(EntityTypeBuilder<JobModel> entityBuilder)
        {
            entityBuilder.HasKey(j => j.Id);
            entityBuilder.ToTable("jobs");

            entityBuilder.Property(j => j.Id).HasColumnName("id");
            entityBuilder.Property(j => j.SuburbId).HasColumnName("suburb_id");
            entityBuilder.Property(j => j.ContactName).HasColumnName("contact_name");
            entityBuilder.Property(j => j.ContactPhone).HasColumnName("contact_phone");
            entityBuilder.Property(j => j.ContactEmail).HasColumnName("contactEmail");
            entityBuilder.Property(j => j.CategoryId).HasColumnName("category_id");
            entityBuilder.Property(j => j.Description).HasColumnName("description");
            entityBuilder.Property(j => j.Time).HasColumnName("created_at");
            entityBuilder.Property(j => j.Price).HasColumnName("price");
            entityBuilder.Property(j => j.Status).HasColumnName("status");
        }

        #endregion
    }
}
