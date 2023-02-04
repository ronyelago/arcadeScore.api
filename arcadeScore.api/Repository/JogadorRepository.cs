
using arcadeScore.api.Data;
using arcadeScore.api.Domain;
using arcadeScore.api.Interfaces.Repositories;

namespace arcadeScore.api.Repository;

public class JogadorRepository : IRepositoryBase<Jogador>
{
    public List<Jogador> GetAll()
    {
        return FakeDatabase.Jogadores;
    }

    public List<Jogador> GetByCondition(Func<Jogador, bool> predicate)
    {
        return FakeDatabase.Jogadores.Where(predicate).ToList();
    }

    public Jogador GetById(Func<Jogador, bool> predicate)
    {
        Jogador jogador = FakeDatabase.Jogadores.FirstOrDefault(predicate);

        return jogador;
    }

    public void Save(Jogador jogador)
    {
        FakeDatabase.Jogadores.Add(jogador);
    }
}
