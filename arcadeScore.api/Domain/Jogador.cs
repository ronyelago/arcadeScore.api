
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
    public int PontuacaoMedia 
    { 
        get 
        {  
            if (!Partidas.Any())
                return 0; 
            
            return Partidas.Sum(p => p.Pontuacao) / Partidas.Count;
        } 
    }

    public int MaiorPontuacao 
    { 
        get 
        {
            if (!Partidas.Any())
                return 0;   

            return Partidas.Max(p => p.Pontuacao); 
        } 
    }
    public int MenorPontuacao 
    { 
        get
        {
            if (!Partidas.Any())
                return 0;

            return Partidas.Min(p => p.Pontuacao);
        }
    }
    public int RecordePessoal { get; set; }
    public List<Partida> Partidas { get; set; }
}