using arcadeScore.api.Domain;

namespace arcadeScore.api.Data;

public static class FakeDatabase
{
    public static List<Partida> Partidas { get; set; }
    public static List<Jogador> Jogadores { get; set; }
    private static int identity = 1;

    public static void GerarDadosEmMemoria()
    {
        Partidas = new();
        Jogadores = new();

        Jogador jogador1 = new("RNY");
        Jogador jogador2 = new("RNN");
        Jogador jogador3 = new("LCS");
        Jogador jogador4 = new("KRN");

        Jogadores.Add(jogador1);
        Jogadores.Add(jogador2);
        Jogadores.Add(jogador3);
        Jogadores.Add(jogador4);

        Partida partida1 = new Partida {
            Id = ObterId(),
            Pontuacao = 19712,
            DataPartida = new(day: 24, month: 05, year: 2015),
            JogadorId = jogador1.Id,
            Jogador = jogador1
        };
        Partida partida2 = new Partida {
            Id = ObterId(),
            Pontuacao = 21716,
            DataPartida = new(day: 30, month: 06, year: 2015),
            JogadorId = jogador2.Id,
            Jogador = jogador2
        };
        Partida partida3 = new Partida {
            Id = ObterId(),
            Pontuacao = 18980,
            DataPartida = new(day: 30, month: 06, year: 2015),
            JogadorId = jogador3.Id,
            Jogador = jogador3
        };
        Partida partida4 = new Partida {
            Id = ObterId(),
            Pontuacao = 12700,
            DataPartida = new(day: 26, month: 05, year: 2015),
            JogadorId = jogador4.Id,
            Jogador = jogador4
        };
        Partida partida5 = new Partida {
            Id = ObterId(),
            Pontuacao = 30900,
            DataPartida = new(day: 24, month: 05, year: 2016),
            JogadorId = jogador1.Id,
            Jogador = jogador1
        };
        Partida partida6 = new Partida {
            Id = ObterId(),
            Pontuacao = 30300,
            DataPartida = new(day: 30, month: 06, year: 2016),
            JogadorId = jogador2.Id,
            Jogador = jogador2
        };
        Partida partida7 = new Partida {
            Id = ObterId(),
            Pontuacao = 30100,
            DataPartida = new(day: 30, month: 06, year: 2016),
            JogadorId = jogador3.Id,
            Jogador = jogador3
        };
        Partida partida8 = new Partida {
            Id = ObterId(),
            Pontuacao = 28200,
            DataPartida = new(day: 26, month: 05, year: 2016),
            JogadorId = jogador4.Id,
            Jogador = jogador4
        };
        Partida partida9 = new Partida {
            Id = ObterId(),
            Pontuacao = 35200,
            DataPartida = new(day: 24, month: 05, year: 2017),
            JogadorId = jogador1.Id,
            Jogador = jogador1
        };
        Partida partida10 = new Partida {
            Id = ObterId(),
            Pontuacao = 35000,
            DataPartida = new(day: 30, month: 06, year: 2017),
            JogadorId = jogador2.Id,
            Jogador = jogador2
        };

        Partidas.Add(partida1);
        Partidas.Add(partida2);
        Partidas.Add(partida3);
        Partidas.Add(partida4);
        Partidas.Add(partida5);
        Partidas.Add(partida6);
        Partidas.Add(partida7);
        Partidas.Add(partida8);
        Partidas.Add(partida9);
        Partidas.Add(partida10);
    }

    private static int ObterId() => identity++;
}