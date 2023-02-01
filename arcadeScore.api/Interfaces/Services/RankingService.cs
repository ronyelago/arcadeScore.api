using arcadeScore.api.Domain;
using arcadeScore.api.Repository;

namespace arcadeScore.api.Services;

public class RankingService
{
    private readonly PartidaRepository _partidaRepository;
    private readonly JogadorRepository _jogadorRepository;

    public RankingService(PartidaRepository partidaRepository, JogadorRepository jogadorRepository)
    {
        _partidaRepository = partidaRepository;
        _jogadorRepository = jogadorRepository;
    }

    public List<Partida> GerarRanking()
    {
        return _partidaRepository.GetAll()
            .OrderByDescending(x => x.Pontuacao)
            .Take(10)
            .ToList();
    }
}