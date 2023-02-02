using arcadeScore.api.Domain;
using arcadeScore.api.Repository;
using arcadeScore.api.Services;
using arcadeScore.api.ViewModel;
using AutoMapper;
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
    private IMapper _mapper;

    public PartidaController(RankingService rankingService, 
        PontuacaoService pontuacaoService, 
        PartidaRepository partidaRepository, 
        JogadorRepository jogadorRepository, 
        IMapper mapper)
    {
        _rankingService = rankingService;
        _pontuacaoService = pontuacaoService;
        _partidaRepository = partidaRepository;
        _jogadorRepository = jogadorRepository;
        _mapper = mapper;
    }

    [HttpGet("GerarRanking")]
    public IActionResult Get()
    {
        return Ok(_rankingService.GerarRanking());
    }

    [HttpGet("ObterJogador/{jogadorId}")]
    public IActionResult Get(string jogadorId)
    {
        return Ok(_jogadorRepository.GetById(x => x.Id.ToUpper() == jogadorId.ToUpper()));
    }

    [HttpPost("RegistrarPontuacao")]
    public IActionResult Post([FromBody] RegistrarPontuacao viewModel)
    {
        if (!ModelState.IsValid)
            return BadRequest(ModelState);
        
        try
        {
            _pontuacaoService.RegistrarPontuacao(_mapper.Map<Partida>(viewModel));

            return StatusCode(StatusCodes.Status201Created);
        }
        catch(Exception ex)
        {
            return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
        }
    }
}