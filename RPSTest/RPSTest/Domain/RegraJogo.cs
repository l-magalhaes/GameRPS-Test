using RPSTest.Exceptions;
using System;
using System.Collections.Generic;
using System.Text;

namespace RPSTest.Domain
{
    public class RegraJogo
    {

        public Partida VerificaRegraPartida(Partida partida)
        {
            List<Jogador> jogadores = new List<Jogador>();
            jogadores = partida.RetornaJogadores();

            foreach (var jogador in jogadores)
            {
                if (jogadores.Count != 2)
                {
                    try
                    {
                        throw new WrongNumberOfPlayersError();
                    }
                    catch
                    {
                        Console.WriteLine("\r\nWrong Number Of Players Error\r\n");
                        Console.ReadKey();
                        Environment.Exit(0);
                    }

                }
            }

            return partida;
        }

        public Jogador RealizarPartida(Jogador jogador1, Jogador jogador2)
        {
            var R = (MovimentoJogador)Enum.Parse(typeof(MovimentoJogador), "R");
            var S = (MovimentoJogador)Enum.Parse(typeof(MovimentoJogador), "S");
            var P = (MovimentoJogador)Enum.Parse(typeof(MovimentoJogador), "P");

            if (jogador1.Movimento == jogador2.Movimento)
            {
                return jogador1;
            }
            else if (jogador1.Movimento == R && jogador2.Movimento == S)
            {
                return jogador1;
            }
            else if (jogador1.Movimento == S && jogador2.Movimento == P)
            {
                return jogador1;
            }
            else if (jogador1.Movimento == P && jogador2.Movimento == R)
            {
                return jogador1;
            }
            else
            {
                return jogador2;
            }

        }

        public List<Jogador> RealizaCampeonatoChavePar(int quantidadeDeRodadas, RegraJogo regra, List<Jogador> jogadores)
        {
            List<Jogador> listaVencedores = new List<Jogador>();
            int index = 0;

            for (int contador = 0; contador < quantidadeDeRodadas; contador++)
            { 
                Jogador vencedor = new Jogador();

                vencedor = regra.RealizarPartida(jogadores[index], jogadores[index + 1]);

                listaVencedores.Add(vencedor);

                if (quantidadeDeRodadas > 1)
                {
                    index = index + 2;
                }
               
            }

            return listaVencedores;
        }

        public List<Jogador> RealizaCampeonatoChaveImpar(double quantidadeDeRodadas, RegraJogo regra, List<Jogador> jogadores)
        {
            List<Jogador> listaVencedores = new List<Jogador>();

            int index = 0;

            for (int contador = 0; contador < quantidadeDeRodadas; contador++)
            {
                Jogador vencedor = new Jogador();

                //EM CONSTRUÇÃO
                vencedor = regra.RealizarPartida(jogadores[index], jogadores[index + 1]);

                listaVencedores.Add(vencedor);

                if (quantidadeDeRodadas > 1)
                {
                    index = index + 2;
                }

            }

            return listaVencedores;
        }
    }
}
