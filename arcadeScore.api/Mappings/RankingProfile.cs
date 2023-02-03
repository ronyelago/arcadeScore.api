using arcadeScore.api.Domain;
using arcadeScore.api.ViewModel;
using AutoMapper;

namespace arcadeScore.api.Mappings;

public class RankingProfile : Profile
{
    public RankingProfile()
    {
        CreateMap<Partida, Ranking>();
    }
}