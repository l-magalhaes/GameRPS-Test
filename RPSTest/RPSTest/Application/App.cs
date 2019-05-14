using RPSTest.Domain;
using RPSTest.Exceptions;
using System;
using System.Collections.Generic;
using System.Text;

namespace RPSTest.Application
{
    public class App
    {
        public static void Main(string[] args)
        {
            Jogador jogador = new Jogador();
            Jogador vencedor = new Jogador();
            Partida partida = new Partida();
            RegraJogo regras = new RegraJogo();
            List<Jogador> jogadores = new List<Jogador>();
            List<Jogador> listaVencedores = new List<Jogador>();

            int verificaOpcao = 0;
            int verificaQuantidade = 0;
            string inserirJogador;

            int ConverterStringParaInt(string opcaoJogador)
            {
                int numeroConvertido;
                if (int.TryParse(opcaoJogador, out numeroConvertido))
                {
                    return numeroConvertido = Convert.ToInt32(opcaoJogador);
                }
                else
                {
                    try
                    {
                        throw new YouHaveEnteredIncorrectValue();
                    }
                    catch
                    {
                        Console.WriteLine("\r\nYou Have Entered an Incorrect Value\r\n");
                        return numeroConvertido = 0;
                    }                                 
                }
            }

            Console.WriteLine("GAME ROCK-PAPER-SCISSORS \r\n");


            while (verificaOpcao == 0)
            {
                Console.WriteLine("1 - Adicionar Partida");
                Console.WriteLine("2 - Resultado Partida");
                Console.WriteLine("3 - Adicionar Torneio");
                Console.WriteLine("4 - Resultado Torneio");

                Console.WriteLine("\r\n5 - Sair ");

                inserirJogador = Console.ReadLine();
                verificaOpcao =  ConverterStringParaInt(inserirJogador);
                
                if (verificaOpcao == 1)
                {
                    Console.WriteLine("Uma partida deve ter 2 jogadores, insira um jogador");

                    Console.WriteLine("\r\nInsira o Nome do Jogador");
                    jogador = new Jogador();
                    jogador.NomeJogador = Console.ReadLine();

                    Console.WriteLine("\r\nInsira o movimento do Jogador");
                    var movimento = Console.ReadLine();
                    jogador.RealizarJogada(movimento);

                    jogadores.Add(jogador);

                    verificaOpcao = 0;
                }
                else if (verificaOpcao == 2)
                {
                    partida.Jogadores = jogadores;
                    regras.VerificaRegraPartida(partida);
                    vencedor = regras.RealizarPartida(jogadores[0], jogadores[1]);
                    Console.WriteLine("O vencedor foi: {0:A} ", vencedor.NomeJogador);
                    Console.WriteLine("Com a jogada: {0:G} \r\n", vencedor.Movimento);

                    jogadores = new List<Jogador>();
                    verificaOpcao = 0;
                }
                else if (verificaOpcao == 3)
                {
                    int contadorJogadores = 0;
                    jogadores = new List<Jogador>();

                    Console.WriteLine("\r\nQuantos jogadores voce deseja inserir nesse torneio?");
                    var quantidadeJogadores = Console.ReadLine();
                    verificaQuantidade = ConverterStringParaInt(quantidadeJogadores);

                    while (contadorJogadores != verificaQuantidade)
                    {
                        jogador = new Jogador();

                        Console.WriteLine("\r\nInsira o Nome do Jogador");
                        jogador.NomeJogador = Console.ReadLine();

                        Console.WriteLine("\r\nInsira o movimento do Jogador");
                        var movimento = Console.ReadLine();
                        jogador.RealizarJogada(movimento);

                        jogadores.Add(jogador);

                        contadorJogadores++;

                        verificaOpcao = 0;
                    }
                }
                else if (verificaOpcao == 4)
                {
                    if (verificaQuantidade == 0)
                    {
                        Console.WriteLine("\r\nNenhum Jogador Encontrado");
                        verificaOpcao = 0;

                    }
                    else
                    {
                        vencedor = new Jogador();
                        int quantidadeDeRodadas = verificaQuantidade / 2;

                        while (jogadores.Count != 1)
                        {

                            if (verificaQuantidade % 2 == 0 || quantidadeDeRodadas == 1)
                            {
                                listaVencedores = regras.RealizaCampeonatoChavePar(quantidadeDeRodadas, regras, jogadores);
                                jogadores = listaVencedores;
                                quantidadeDeRodadas = quantidadeDeRodadas / 2;

                            }
                            else
                            {
                                Console.WriteLine("EM DESENVOLVIMENTO");
                                Console.ReadKey();
                                Environment.Exit(0);

                                //listaVencedores = regras.RealizaCampeonatoChaveImpar(quantidadeDeRodadas, regras, jogadores);
                                //jogadores = listaVencedores;
                                //quantidadeDeRodadas = quantidadeDeRodadas - 1;
                            }

                        }
                        vencedor = jogadores[0];
                        
                        Console.WriteLine("O vencedor foi: {0:A} ", vencedor.NomeJogador);
                        Console.WriteLine("Com a jogada: {0:G} \r\n", vencedor.Movimento);

                        jogadores = new List<Jogador>();
                       
                        verificaOpcao = 0;
                    }

                }
                else if (verificaOpcao == 5)
                {
                    Console.WriteLine("\r\nGame Over");
                }

            }
         
            Console.ReadKey();
        }
    }
}
