using System;

namespace matriz
{
    class Program
    {
        static void Main(string[] args)
        {
            // criar matriz triangular inferior

            // estabelecer o tamanho da matriz
            int tamanho = 4;

            // cria a matriz
            int[,] matriz = new int[tamanho, tamanho];

            // preenche a matriz
            for (int linha = 0; linha < tamanho; linha ++)
            {
                for (int coluna = 0; coluna <= linha; coluna++)
                {
                    matriz[linha, coluna] = linha * tamanho + coluna + 1;
                }
            }

            // exibe a matriz
            Console.WriteLine("Matriz triangular inferior");

            for (int linha = 0; linha < tamanho; linha ++)
            {
                for (int coluna = 0; coluna < tamanho; coluna++)
                {
                    Console.Write(matriz[linha, coluna] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}