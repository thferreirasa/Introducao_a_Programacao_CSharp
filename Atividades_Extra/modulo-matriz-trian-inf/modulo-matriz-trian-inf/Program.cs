using System;

namespace matriz
{
    public class Program
    {
        // modulo para criar a matriz
        static void matrizTriangularInferior(int[,] matriz, int tamanho)
        {
           // preenche a matriz com linhas e colunas
            for (int linha = 0; linha < tamanho; linha++)
            {
                for (int coluna = 0; coluna <= linha; coluna++) // <= linha - so vai ate a posicao da linha, forma da matriz
                {
                    matriz[linha, coluna] = linha * tamanho + 1; // valores nas linhas e colunas
                }
            }

        }

        // módulo para imprimir/mostrar a matriz
        static void imprimeMatriz(int[,] matriz, int tamanho)
        {

            for (int linha = 0; linha < tamanho; linha++)
            {
                for (int coluna = 0; coluna < tamanho; coluna++)
                {
                    Console.Write(matriz[linha, coluna] + "\t"); // imprime posicao atual
                }
                Console.WriteLine(); // pular para proxima linha
            }

        }

        // dados para gerar a matriz com os modulos
        static void Main(string[] args)
        {
            
            int tamanho = 4;
            int[,] matriz = new int[tamanho, tamanho];

            matrizTriangularInferior(matriz, tamanho);

            imprimeMatriz(matriz, tamanho);


        }

    }
}
