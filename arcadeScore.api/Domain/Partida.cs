
namespace arcadeScore.api.Domain;

public record Partida
{
    public int Id { get; set; }
    public int Pontuacao { get; set; }
    public DateTime DataPartida { get; set; }
    public string JogadorId { get; set; }
    public Jogador Jogador { get; set; }
}