using AutoMapper;
using LeadManagement.Application.DTOs;
using LeadManagement.Domain;

namespace LeadManagement.Application.Profiles
{
    /// <summary>
    /// Profiles for auto mapper
    /// </summary>
    public class AutoMapperProfiles : Profile
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AutoMapperProfiles"/> class.
        /// </summary>
        public AutoMapperProfiles()
        {
            CreateMap<Suburb, SuburbDto>();
            CreateMap<Category, CategoryDto>();
            CreateMap<Contact, ContactDto>();
            CreateMap<Job, JobDto>();
        }
    }
}