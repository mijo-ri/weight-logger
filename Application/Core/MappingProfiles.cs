using Application.Logs;
using AutoMapper;
using Domain;

namespace Application.Core
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<Log, Log>();
            CreateMap<Log, LogDto>()
                .ForMember(d => d.Profile, o => o.MapFrom(s => s.AppUser));
            CreateMap<AppUser, Profiles.Profile>()
                .ForMember(d => d.Username, o => o.MapFrom(s => s.UserName))
                .ForMember(d => d.DisplayName, o => o.MapFrom(s => s.DisplayName))
                .ForMember(d => d.Bio, o => o.MapFrom(s => s.Bio));
        }
    }
}
