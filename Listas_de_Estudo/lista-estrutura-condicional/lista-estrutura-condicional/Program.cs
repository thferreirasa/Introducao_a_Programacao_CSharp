using System;
using static System.Net.Mime.MediaTypeNames;
using System.Drawing;
using System.Numerics;
using System.Diagnostics.Metrics;
using System.Net;

namespace condicional
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            // O número 3025 tem uma propriedade interessante: 30 + 25 = 55 e (55)^2 = 3025.
            // Escreva um programa que lê um número inteiro e determinar se ele possui ou não
            // essa propriedade.
            
            // entrada
            Console.WriteLine("Informe um número");
            string primeiroValor = Console.ReadLine();
            Console.WriteLine("Informe outro número");
            string segundoValor = Console.ReadLine();

            // concatenar strings
            string numerosJuntos = primeiroValor + segundoValor;

            // transformar em numero
            double primeiroNumero = double.Parse(primeiroValor);
            double segundoNumero = double.Parse(segundoValor);

            // somar e elevar ao quadrado
            double soma = primeiroNumero + segundoNumero;
            double elevadoQuadrado = Math.Pow(soma, 2);

            // transformar a string em double
            double numerosJuntosInt = double.Parse(numerosJuntos);

            // condicional
            if (elevadoQuadrado == numerosJuntosInt)
            {
                Console.WriteLine("Esses números possuem essa propriedade: " + elevadoQuadrado);
            } else
            {
                Console.WriteLine("Esses números não possuem essa propriedade: " + elevadoQuadrado);
            }
            */

            /*
            // Escrever um programa para ler 2 números e imprimi-los em ordem ascendente.
            // entrada
            Console.WriteLine("Informe o primeiro valor");
            int primeiroValor = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o segundo valor");
            int segundoValor = int.Parse(Console.ReadLine());

            // condicional
            if (primeiroValor < segundoValor)
            {
                Console.WriteLine(primeiroValor + ", " + segundoValor);
            } else
            {
                Console.WriteLine(segundoValor + ", " + primeiroValor);
            }
            */

            /*
            // Escrever um programa para ler um número inteiro e identificar
            // se ele é par ou impar, escrevendo a mensagem correspondente.
            // entrada
            Console.WriteLine("Digite um número");
            int numero = int.Parse(Console.ReadLine());
            int resto = numero % 2;

            // condicional
            if (resto == 0)
            {
                Console.WriteLine("O número é par");
            } else
            {
                Console.WriteLine("O número é ímpar");
            }
            */

            /*
            // Escrever um programa para ler 3 números inteiros e imprimir o maior deles.
            // entrada
            Console.WriteLine("Digite um valor");
            int primeiroNumero = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite outro");
            int segundoNumero = int.Parse(Console.ReadLine());
            Console.WriteLine("Mais um");
            int terceiroNumero = int.Parse(Console.ReadLine());

            // condicional
            if (primeiroNumero > segundoNumero && primeiroNumero > terceiroNumero)
            {
                Console.WriteLine("O maior número é " + primeiroNumero);
            } else if (segundoNumero > terceiroNumero)
            {
                Console.WriteLine("O maior número é " + segundoNumero);
            } else
            {
                Console.WriteLine("O maior número é " + terceiroNumero);
            }
            */

            /*
            // Escreva um programa que lê um valor em reais e um tipo de
            // moeda(1-dólar, 2-libra ou 3-euro) e faz a conversão do valor para a moeda solicitada, sabendo que
            // 1 dólar = R$ 4,00 1 libra = R$ 6,15 1 euro = R$ 4,72.

            // entrada
            Console.WriteLine("Informe um valor");
            double valor = double.Parse(Console.ReadLine());
            Console.WriteLine("Selecione uma moeda (dólar, libra ou euro)");
            string moeda = Console.ReadLine();

             // condicional
             if (moeda == "dólar" || moeda == "dolar")
            {
                double conversao = valor * 4;
                Console.WriteLine("O valor em dólares é " + conversao);
            } else if (moeda == "libra")
            {
                double conversao = valor * 6.15;
                Console.WriteLine("O valor em libras é " + conversao);
            } else
            {
                double conversao = valor * 4.72;
                Console.WriteLine("O valor em euros é " + conversao);
            }
            */

            /*
            // Escreva um algoritmo que, dada a idade de um nadador,
            // classifique-o em uma das seguintes categorias:
            // infantil B = 8 – 10 anos
            // juvenil A = 11- 13 anos
            // juvenil B = 14 – 17 anos
            // sênior = maiores de 18 anos.

            // entrada
            Console.WriteLine("Qual sua idade?");
            int idade = int.Parse(Console.ReadLine());

            // condicional
            if (idade >= 8 && idade <= 10)
            {
                Console.WriteLine("Você está na categoria Infantil B.");
            } else if (idade >= 11 && idade <= 13)
            {
                Console.WriteLine("Você está na categoria Juvenil A.");
            } else if (idade >= 14 && idade <= 17)
            {
                Console.WriteLine("Você está na categoria Juvenil B.");
            } else if (idade >= 18)
            {
                Console.WriteLine("Você está na categoria Sênior.");
            }
            */

            /*
            // Escreva um programa que pergunte 4 números inteiros,
            // referente a: Opção, Num1, Num2, Num3 respectivamente; e mostre:
            // a) O valor de Num1 se a Opção for igual a 1.
            // b) O valor de Num2 se a Opção for igual a 2.
            // c) O valor de Num3 se a Opção for igual a 3.
            // Os únicos valores para Opção são 1, 2 e 3.

            // entrada
            Console.WriteLine("Escolha o valor da Opção");
            int opcao = int.Parse(Console.ReadLine());
            Console.WriteLine("Escolha o valor de Num1");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Escolha o valor de Num2");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Escolha o valor de Num3");
            int num3 = int.Parse(Console.ReadLine());

            // condicao
            if (opcao == 1)
            {
                Console.WriteLine(num1);
            } else if (opcao == 2)
            {
                Console.WriteLine(num2);
            } else if (opcao == 3)
            {
                Console.WriteLine(num3);
            }
            */

            /*
            // Escreva um programa para contar dinheiro, que
            // pergunte dentro de um monte de dinheiro qual a quantidade de
            // notas de 1 real, 5 reais, 10 reais, 50 reais e 100 reais.Em seguida
            // imprima o valor total em dinheiro.

            // entrada
            Console.WriteLine("Qual a quantidade de notas de 1 real?");
            int um = int.Parse(Console.ReadLine());
            Console.WriteLine("Qual a quantidade de notas de 5 reais?");
            int cinco = int.Parse(Console.ReadLine());
            Console.WriteLine("Qual a quantidade de notas de 10 reais?");
            int dez = int.Parse(Console.ReadLine());
            Console.WriteLine("Qual a quantidade de notas de 50 reais?");
            int cinquenta = int.Parse(Console.ReadLine());
            Console.WriteLine("Qual a quantidade de notas de 100 reais?");
            int cem = int.Parse(Console.ReadLine());

            // processamento
            int cincoReais = 5 * cinco;
            int dezReais = 10 * dez;
            int cinquentaReais = 50 * cinquenta;
            int cemReais = 100 * cem;

            int total = um + cincoReais + dezReais + cinquentaReais + cemReais;

            Console.WriteLine("Você tem " + total + " reais.");
            */

            /* RESPONDER DEPOIS
            // Escreva um programa que faça o inverso da questão
            // anterior, ou seja, solicite ao usuário um valor(total) em dinheiro, e
            // informe quantas notas de 1 real, 5 reais, 10 reais, 50 reais e 100
            // reais são necessárias para compor este valor, de forma que sejam
            // utilizadas o menor número de notas possível.

            // entrada
            Console.WriteLine("Informe o valor que você possui");
            int valor = int.Parse(Console.ReadLine());

            // processamento

            */


            // Um autódromo necessita de um programa para
            // verificar qual o carro mais rápido em uma competição.
            // Considerando que dois carros participam da corrida, o programa
            // pergunta qual o comprimento da pista(em metros) e quanto tempo
            // (em segundos) cada um dos carros levou pra percorrer a pista, e
            // informa a velocidade do carro mais rápido. (Considere que em uma
            // corrida não existem dois carros com tempos de percurso
            // exatamente iguais).

            // entrada
            Console.WriteLine("Qual o comprimento da pista em metros?");
            int comprimento = int.Parse(Console.ReadLine());
            Console.WriteLine("Em quantos segundos o primeiro carro percorreu a pista?");
            int carroUm = int.Parse(Console.ReadLine());
            Console.WriteLine("Em quantos segundo o segundo carro percorreu a pista?");
            int carroDois = int.Parse(Console.ReadLine());

            // condicional
            if (carroUm < carroDois)
            {
                int velocidade = comprimento / carroUm;
                Console.WriteLine("A velocidade do carro 1 foi de " + velocidade  + "m/s");
            } else
            {
                int velocidade = comprimento / carroDois;
                Console.WriteLine("A velocidade do carro 2 foi de " + velocidade + "m/s");
            }

        }
    }
}