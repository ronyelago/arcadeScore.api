using arcadeScore.api.Domain;
using arcadeScore.api.ViewModel;
using AutoMapper;

namespace arcadeScore.api.Mappings;

public class PartidaProfile : Profile
{
    public PartidaProfile()
    {
        CreateMap<RegistrarPontuacao, Partida>()
            .ForMember(dest => dest.JogadorId, opt => opt .MapFrom(src => src.JogadorId .ToUpper()) )
            .ReverseMap();
    }
}