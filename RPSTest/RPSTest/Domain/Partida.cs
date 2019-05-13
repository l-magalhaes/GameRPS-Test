using System;
using System.Collections.Generic;
using System.Text;

namespace RPSTest.Domain
{
    public class Partida
    {
        public Jogador Vencedor { get; set; }
        public List<Jogador> Jogadores { get; set; }

        public Partida()
        {
            Jogadores = new List<Jogador>();
        }

        public void AddJogador(Jogador Jogador)
        {
            Jogadores.Add(Jogador);
        }

        public List<Jogador> RetornaJogadores()
        {
            return Jogadores;
        }
    }
}
