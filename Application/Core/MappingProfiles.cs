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
                .ForMember(d => d.UserName, o => o.MapFrom(s => s.UserName))
                .ForMember(d => d.DisplayName, o => o.MapFrom(s => s.DisplayName))
                .ForMember(d => d.Bio, o => o.MapFrom(s => s.Bio));

            CreateMap<LogDto, Log>()
                .ForMember(d => d.AppUser, o => o.MapFrom(s => s.Profile));
            CreateMap<Profiles.Profile, AppUser>()
                .ForMember(d => d.UserName, o => o.MapFrom(s => s.UserName))
                .ForMember(d => d.DisplayName, o => o.MapFrom(s => s.DisplayName))
                .ForMember(d => d.Bio, o => o.MapFrom(s => s.Bio));
        }
    }
}
