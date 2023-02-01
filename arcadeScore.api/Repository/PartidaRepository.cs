using arcadeScore.api.Data;
using arcadeScore.api.Domain;
using arcadeScore.api.Interfaces.Repositories;

namespace arcadeScore.api.Repository;

public class PartidaRepository : IRepositoryBase<Partida>
{
    public List<Partida> GetAll()
    {
        return FakeDatabase.Partidas;
    }

    public List<Partida> GetByCondition(Func<Partida, bool> predicate)
    {
        return FakeDatabase.Partidas.Where(predicate).ToList();
    }

    public Partida GetById(Func<Partida, bool> predicate)
    {
        return FakeDatabase.Partidas.FirstOrDefault(predicate);
    }

    public void Save(Partida partida)
    {
        FakeDatabase.Partidas.Add(partida);
    }
}
