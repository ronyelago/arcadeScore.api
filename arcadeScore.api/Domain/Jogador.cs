
namespace arcadeScore.api.Domain;

public class Jogador
{
    public Jogador(string id)
    {
        Id = id;
        Partidas = new List<Partida>();
    }

    public string Id { get; set; }
    public int PartidasJogadas { get => Partidas.Count(); }
    public int PontuacaoMedia { get => Partidas.Sum(p => p.Pontuacao) / Partidas.Count; }
    public int MaiorPontuacao { get => Partidas.Max(p => p.Pontuacao); }
    public int MenorPontuacao { get => Partidas.Min(p => p.Pontuacao); }
    public int RecordePessoal { get; set; }
    public List<Partida> Partidas { get; set; }
}