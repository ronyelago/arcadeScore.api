using arcadeScore.api.Domain;
using arcadeScore.api.Repository;
using arcadeScore.api.Services;
using arcadeScore.api.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace arcadeScore.api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class PartidaController : ControllerBase
{
    private readonly PontuacaoService _pontuacaoService;
    private readonly RankingService _rankingService;
    private readonly PartidaRepository _partidaRepository;
    private readonly JogadorRepository _jogadorRepository;

    public PartidaController(RankingService rankingService, PontuacaoService pontuacaoService, PartidaRepository partidaRepository, JogadorRepository jogadorRepository)
    {
        _rankingService = rankingService;
        _pontuacaoService = pontuacaoService;
        _partidaRepository = partidaRepository;
        _jogadorRepository = jogadorRepository;
    }

    [HttpGet("GerarRanking")]
    public IActionResult Get()
    {
        return Ok(_rankingService.GerarRanking());
    }

    [HttpGet("ObterJogador/{jogadorId}")]
    public IActionResult Get(string jogadorId)
    {
        return Ok(_jogadorRepository.GetById(x => x.Id == jogadorId));
    }

    [HttpPost("RegistrarPontuacao")]
    public IActionResult Post([FromBody] RegistrarPontuacao viewModel)
    {
        try
        {
            Partida partidaMap = new Partida
            {
                Pontuacao = viewModel.Pontuacao,
                DataPartida = viewModel.DataPartida,
                JogadorId = viewModel.JogadorId
            };
            _pontuacaoService.RegistrarPontuacao(partidaMap, viewModel.JogadorId);

            return Created("RegistrarPontuacao", null);
        }
        catch(Exception ex)
        {
            return BadRequest(new { Message = ex.Message, InnerExceptionMessage = ex.InnerException?.Message});
        }
    }
}