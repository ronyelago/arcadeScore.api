using arcadeScore.api.Domain;
using arcadeScore.api.ViewModel;
using AutoMapper;

namespace arcadeScore.api.Mappings;

public class PartidaProfile : Profile
{
    public PartidaProfile()
    {
        CreateMap<RegistrarPontuacao, Partida>().ReverseMap();
    }
}