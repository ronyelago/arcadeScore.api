
namespace arcadeScore.api.Domain;

public class Jogador
{
    public Jogador(string id)
    {
        Id = id;
        Partidas = new List<Partida>();
    }

    public string Id { get; set; }
    public List<Partida> Partidas { get; set; }
}