using System;

namespace repeticao
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
// QUESTAO 1 - Escreva um algoritmo que efetue a soma de todos os números
// ímpares num intervalo (a, b) dado

Console.WriteLine("Qual o primeiro número do intervalo?");
int inicio = int.Parse(Console.ReadLine());
Console.WriteLine("Qual o último número do intervalo?");
int final = int.Parse(Console.ReadLine());
int soma = 0;


for (int i = inicio; i <= final; i++)
{
    if (i % 2 != 0)
    {
        soma = soma + i;
        Console.WriteLine(soma);
    } else
    {
        i++;
        soma = soma + i;
        Console.WriteLine(soma);
    }
}
*/

            /*
            // QUESTÃO 2 Escreva um programa que imprima a tabuada de um número N lido

            Console.WriteLine("Indique o número da Tabuada que você quer acessar:");
            int numero = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 9; i++)
            {
                int soma = numero + i;
                Console.WriteLine("{0} + {1} = {2}", numero, i, soma);
            }
            
            for (int i = 1; i <= 9; i++)
            {
                int multiplicacao = numero * i;
                Console.WriteLine("{0} x {1} = {2}", numero, i, multiplicacao);
            }

            for (int i = 1; i <= 9; i++)
            {
                int divisao = numero / i;
                Console.WriteLine("{0} / {1} = {2}", numero, i, divisao);
            }
            */


            /*
            // QUESTAO 3 Escrever um programa que, dado um conjunto de números inteiros
            // positivos, determine qual o menor valor do conjunto. O final do conjunto
            // de valores é conhecido através do valor 0, que não deve ser considerado.            
            int numero = 0;
            int maiornumero = 0;

            do
            {
                Console.WriteLine("Indique um número;");
                numero = int.Parse(Console.ReadLine());

                if (numero > maiornumero)
                {
                    maiornumero = numero;
                    Console.WriteLine("O maior número é {0}", maiornumero);
                } else
                {
                    Console.WriteLine("O maior número é {0}", maiornumero);
                }

            } while (numero != 0);
            */

            /*
            // QUESTAO 4 Escrever um programa que leia um número e, a seguir,
            // leia uma lista de números até achar um igual ao primeiro número
            // lido.
            Console.WriteLine("Insira um valor inicial para comparação:");
            int numero = int.Parse(Console.ReadLine());
            Console.Clear(); // limpar o console

            int comparacao = 0;

            while (comparacao != numero)
            {
                Console.WriteLine("Insira um número:");
                comparacao = int.Parse(Console.ReadLine());

                if (numero == comparacao)
                {
                    Console.WriteLine("O número era {0}", numero);                    
                }
            }
            */

            /*
            // QUESTAO 5 Fazer um programa que leia um conjunto de numeros e 
            // imprima a quantidade de números pares e a quantidade de números
            // ímpares. Assuma que o valor -1 representa o fim da entrada de dados.

            int numero = 0;
            int pares = 0;
            int impares = 0;

            do
            {
                Console.WriteLine("Insira um número:");
                numero = int.Parse(Console.ReadLine());

                if (numero % 2 == 0)
                {
                    pares++;
                } else
                {
                    impares++;
                }
            } while (numero != -1);

            Console.WriteLine("Foram {0} números pares e {1} números ímpares.", pares, impares);
            */

            /*
            // QUESTAO 6 Escrever um programa para calcular o fatorial de um número.
            Console.WriteLine("Escolha um número para calcular seu fatorial:");
            int numero = int.Parse(Console.ReadLine());
            int fatorial = 1;

            // ordem decrescente
            for (int i = numero;  i >= 1; i--)
            {
                fatorial = fatorial * i;
            }
            Console.WriteLine("O fatorial de {0} é {1}", numero, fatorial);
            */


            /*
            // QUESTAO 7 Escreva um programa que imprima os N primeiros números da
            // sequência de Fibonacci, onde cada termo é obtido pela soma dos dois
            // termos anteriores. ex.: 1, 1, 2, 3, 5, 8, 13
            Console.WriteLine("Quantos números da sequência Fibonacci você quer ver?");
            int numero = int.Parse(Console.ReadLine());

            int fibonacci = 0;
            int numeroAnterior = 0;
            int numeroAtual = 1;

            for (int i = 1; i <= numero; i++)
            {
                fibonacci = numeroAnterior + numeroAtual;
                Console.WriteLine(fibonacci);

                numeroAnterior = numeroAtual; // o numero anterior passa a ter valor do atual
                numeroAtual = fibonacci; // o numero atual fica com a soma feita (fibonacci)
            }
            */

            /*
            // QUESTÃO 8 Um grande Shopping Center da cidade deseja conhecer melhor os seus
            // consumidores. Assim, foi realizada uma pesquisa na entrada principal do Shopping.
            // Para cada indivíduo que chegava, era solicitado o seu nome, a sua idade, o sexo e 
            // o código equivalente aos objetivo da sua ida ao Shopping, segundo a tabela.
            //          CODIGO                     OBJETIVO
            //          010                         Compras
            //          020                         Serviços (banco, correio, etc.)
            //          030                         Lazer (cinema, jogos, etc.)
            //          040                         Alimentação (restaurantes e lanchonetes)
            // Faça um programa que leia os dados da pesquisa realizada e informe:
            // a) O percentual de indivíduos que buscavam Serviços;
            // b) Quem frequenta mais o shopping: homens ou mulheres?
            // Obs.: O fim da pesquisa é identificado com o nome igual a "fim"
            
            // Percentual de indivíduos que buscavam serviços
            string objetivo = "objetivo";
            double servicos = 0;
            double rodadas = 0;
            double percentual = 0;

            while (objetivo != "fim")
            {
                Console.WriteLine("Informe o código do objetivo ou escreva fim");
                objetivo = Console.ReadLine();
                rodadas++;                

                if (objetivo == "020")
                {
                    servicos++;                    
                    percentual = (servicos / rodadas) * 100;
                } 
            }

            Console.WriteLine(percentual);
            Console.WriteLine("O percentual dos Serviços foi de {0}%", percentual);
            

            // Quem frequenta mais o shopping: homens ou mulheres?
            string sexo = "sexo";
            int feminino = 0;
            int masculino = 0;

            while (sexo != "fim")
            {
                Console.WriteLine("Escreva o sexo (fem/mas) ou fim:");
                sexo = Console.ReadLine();

                if (sexo == "fem")
                {
                    feminino++;
                } else if (sexo == "mas")
                {
                    masculino++;
                }
            }

            if (feminino > masculino)
            {
                Console.WriteLine("Mais mulheres frequentam esse Shopping, com um total de {0}.", feminino);
            } else
            {
                Console.WriteLine("Mais homens frequentam esse Shopping, com um total de {0}.", masculino);
            }
            */

            /*
            // QUESTÃO 9 Uma livraria deseja efetuar uma pesquisa sobre os livros vendidos no mês.
            // Para cada livro vendido o funcionário deve preencher um questionário, informando o
            // tipo (1 - Ficção | 2 - Romance | 3 - Aventura), o sexo do comprador (M - Masculino |
            // F - Feminino). Sabendo que o fim dos dados é indicado pelo tipo do livro igual a zero,
            // elabore um programa que informe:
            // a) Tipo de livro mais vendido no mês
            // b) Percentual de homens que leem livros de romance
            
            // Tipo de livro mais vendido no mês
            int tipo = -1;
            int ficcao = 0;
            int romance = 0;
            int aventura = 0;

            while (tipo != 0)
            {
                Console.WriteLine("Que tipo de livro foi vendido? 1 - Ficção, 2 - Romance, 3 - Aventura");
                tipo = int.Parse(Console.ReadLine());

                if (tipo == 1)
                {
                    ficcao++;
                }
                else if (tipo == 2)
                {
                    romance++;
                }
                else if (tipo == 3)
                {
                    aventura++;
                }
            }

            if (ficcao > romance)
            {
                if (ficcao > aventura)
                {
                    Console.WriteLine("Ficção é o tipo mais vendido: {0}", ficcao);
                } else if (aventura > ficcao)
                {
                    Console.WriteLine("Aventura é o tipo mais vendido: {0}", aventura);
                }       
            } else if (romance > aventura)
            {
                Console.WriteLine("Romance é o tipo mais vendido: {0}", romance);
            }
            

            // Percentual de homens que leem livros de romance
            string sexo = "sexo";
            int tipo = -1;
            int contagem = 0;

            while (tipo !=0)
            {             
                Console.WriteLine("Indique o tipo de livro (1 - Ficção, 2 - Romance, 3 - Aventura)");
                tipo = int.Parse(Console.ReadLine());
                Console.WriteLine("Indique o gênero (fem/mas):");
                sexo = Console.ReadLine();
                
                if (sexo == "mas" && tipo == 2)
                {
                    contagem++;
                }
            }

            Console.WriteLine("{0} dos leitores de Romance são homens.", contagem);
            */

            /*
            // QUESTAO 10 Escreva um programa que simule o funcionamento de um relógio. O programa
            // deverá iniciar com a contagem dos segundos e como um relógio, para cada 60 segundos,
            // conta-se 1 minuto, e o mesmo acontece para as horas. Não é necessário que o ritmo do
            // relógio acompanhe o ritmo das horas.

            int seg = 0;
            int min = 0;
            int hora = 0;
            int contador = 0;

            Console.WriteLine("Selecione um valor de rodadas para o código:");
            int rodadas = int.Parse(Console.ReadLine());

            while (seg != -1)
            {
                contador++;
                seg++;
                if (seg == 60)
                {
                    seg = 0;
                    min = min++;
                }
                if (min == 60)
                {
                    min = 0;
                    hora++;
                }
                if (contador == rodadas)
                {
                    break;
                }
            }
            Console.WriteLine("{0}h{1}min{2}s.", hora, min, seg);
            */
        }
    }
}