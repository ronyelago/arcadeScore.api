using arcadeScore.api.Domain;
using arcadeScore.api.Repository;

namespace arcadeScore.api.Services;

public class PontuacaoService
{
    private readonly PartidaRepository _partidaRepository;
    private readonly JogadorRepository _jogadorRepository;

    public PontuacaoService(PartidaRepository partidaRepository, JogadorRepository jogadorRepository)
    {
        _partidaRepository = partidaRepository;
        _jogadorRepository = jogadorRepository;
    }

    public void RegistrarPontuacao(Partida partida, string jogadorId)
    {
        var jogador = _jogadorRepository.GetById(j => j.Id == jogadorId);

        if (jogador == null)
        {
            jogador = new Jogador(jogadorId);
            _jogadorRepository.Save(jogador);
        }

        jogador.Partidas.Add(partida);
        partida.Jogador = jogador;
        _partidaRepository.Save(partida);
    }
}