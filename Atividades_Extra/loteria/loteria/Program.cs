using System;

namespace loteria
{
    class Program
    {
        // coleta a aposta do usuario
        static void apostar(int[,] apostado)
        {
            // instrucoes
            Console.WriteLine("Digite para apostar (0 - Empate | 1 - Time 1 | 2 - Time 2)");

            // coletar aposta do usuario em matriz
            for (int i = 0; i < apostado.GetLength(0); i++)
            {
                Console.Write("Jogo {0}: ", (i + 1));
                string selecao = Console.ReadLine();

                switch (selecao)
                {
                    case "0":
                        apostado[i, 0] = 1;
                        break;
                    case "1":
                        apostado[i, 2] = 1;
                        break;
                    case "2":
                        apostado[i, 1] = 1;
                        break;
                }
            }
        }
        
        // resultados reais dos jogos
        static void resultadoDoJogo(int[,] resultado)
        {
            // aleatorizar resultado
            Random resultadoAleatorio = new Random();

            // criar matriz de resultados
            for (int i = 0; i < resultado.GetLength(0); i++)
            {
                resultado[i, resultadoAleatorio.Next(3)] = 1; // resultado entre 0 e 2 na coluna
            }
        }

        // comparar resultados das matrizes
        static void compararResultado(int[,] resultado, int[,] apostado)
        {
            int pontos = 0;

            // cabeçalho
            Console.WriteLine("  Resultado     e     Aposta");
            Console.WriteLine("\n\t   | 0 | 1 | 2 || 0 | 1 | 2 |");

            for (int i = 0; i < resultado.GetLength(0); i++)
            {
                // variavel booleana (se acertou ou nao)
                bool comparacao = false;
                
                // texto do lado da matriz
                Console.Write("\n\t {0} |", (i + 1));

                // marcação do resultado na matriz
                for (int j = 0; j < resultado.GetLength(1); j++) // comprimento - numero de colunas
                {
                    if (resultado[i, j] == 1)
                    {
                        Console.Write(" X |");
                    }
                    else
                    {
                        Console.Write("   |");
                    }
                }

                // marcação e comparação da aposta com resultado
                for (int j = 0; j <  apostado.GetLength(1); j++) 
                {
                    if (apostado[i, j] == 1)
                    {
                        Console.Write(" X |");
                        if (apostado[i, j] == resultado[i, j])
                        {
                            comparacao = true;

                            if (comparacao)
                            {
                                Console.Write("\t Correto");
                                pontos++;
                            }
                        }
                        else
                        {
                            Console.Write("   |");
                        }
                    }                    
                }                

            }
            Console.WriteLine("\n\t Resultado: {0} pontos!", pontos);

        }

        // utilizar os modulos criados
        static void Main(string[] args)
        {
            int numeroDeJogos = 13;
            int[,] apostado = new int[numeroDeJogos, 3];
            int[,] resultado = new int[numeroDeJogos, 3];

            apostar(apostado);
            resultadoDoJogo(resultado);
            compararResultado(resultado, apostado);
        }

    }
}