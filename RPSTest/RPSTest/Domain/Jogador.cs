using RPSTest.Exceptions;
using System;
using System.Collections.Generic;
using System.Text;

namespace RPSTest.Domain
{
    public class Jogador
    {
        public string NomeJogador { get; set; }

        public MovimentoJogador Movimento { get; set; }

        public Jogador() { }

        public Jogador(string nomeJogador)
        {
            NomeJogador = nomeJogador;
        }

        public void RealizarJogada(string meuMovimento)
        {
            if (meuMovimento.ToUpper().Contains('R') || meuMovimento.ToUpper().Contains('P') || meuMovimento.ToUpper().Contains('S'))
            {
                Movimento = (MovimentoJogador)Enum.Parse(typeof(MovimentoJogador), meuMovimento.ToUpper());
            }
            else
            {
                try
                {
                    throw new NoSuchStrategyError();
                }
                catch
                {
                    Console.WriteLine("\r\nNo Such Strategy Error\r\n");
                    Console.ReadKey();
                    Environment.Exit(0);
                }
            }
        }

        public MovimentoJogador ApresentarJogada()
        {
            return Movimento;
        }   
    }
}
