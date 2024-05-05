using System;

namespace entradassaidas
{
    class Program
    {
        static void Main(string[] args)
        {
            // Calcular idade em dias
            /*
            Console.WriteLine("Qual sua idade?");
            int idade = int.Parse(Console.ReadLine());

            int idadeDias = idade * 365;

            Console.WriteLine("Sua idade em dias é " + idadeDias);
            */

            /*
            // Faça um programa que calcule a quantidade necessária de latas
            // de tinta para pintar uma parede. O programa pergunta a medida de largura
            // e altura da parede em metros e imprima o resultado(em latas de tintas).
            // Considere que o consumo de tinta é de 300 ml por metro quadrado e a
            // quantidade de tinta por lata e de 2 litros.

            // entrada
            Console.WriteLine("Qual a altura da parede?");
            double altura = double.Parse(Console.ReadLine());
            Console.WriteLine("Qual a largura da parede?");
            double largura = double.Parse(Console.ReadLine());

            // processamento
            double area = altura * largura;
            double tinta = area * 0.3;
            double latas = tinta / 2;

            // saida
            Console.WriteLine(latas + " latas de tinta.");
            */

            /*
            // Escreva um programa que pergunte qual o tempo transcorrido
            // em um cronômetro em horas, minutos e segundos, e transforme(e
            // imprima) todo este tempos em segundos.

            // entrada
            Console.WriteLine("Informe as horas");
            int horas = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe os minutos");
            int minutos = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe os segundos");
            int segundos = int.Parse(Console.ReadLine());

            // processamento
            int horasEmSegundos = horas * 3600;
            int minutosEmSegundos = minutos * 60;
            int segundosTotais = horasEmSegundos + minutosEmSegundos + segundos;

            // saida
            Console.WriteLine(segundosTotais + " segundos.");
            */

            /*
            // Escreva um programa que calcule a quantidade aproximada de
            // tijolos que vão ser usados para a construção de uma sala.Solicite a altura e
            // a largura do tijolo, solicite a altura, largura da sala, solicite as dimensões
            // da janela e da porta.Considere que a sala é retangular, que possui apenas
            // uma porta e uma janela.

            // entrada
            Console.WriteLine("Informe a altura do tijolo");
            float alturaTijolo = float.Parse(Console.ReadLine());
            Console.WriteLine("Informe a largura do tijolo");
            float larguraTijolo = float.Parse(Console.ReadLine());
            Console.WriteLine("Informe a altura da sala");
            float alturaSala = float.Parse(Console.ReadLine());
            Console.WriteLine("Informe a largura da sala");
            float larguraSala = float.Parse(Console.ReadLine());
            Console.WriteLine("Informe a altura da janela");
            float alturaJanela = float.Parse(Console.ReadLine());
            Console.WriteLine("Informe a largura da janela");
            float larguraJanela = float.Parse(Console.ReadLine());
            Console.WriteLine("Informe a altura da porta");
            float alturaPorta = float.Parse(Console.ReadLine());
            Console.WriteLine("Informe a largura da porta");
            float larguraPorta = float.Parse(Console.ReadLine());

            // processamento
            float areaTijolo = larguraTijolo * alturaTijolo;
            float areaParede = larguraSala * alturaSala;
            float areaParedes = areaParede * 4;
            float areaPorta = larguraPorta * alturaPorta;
            float areaJanela = larguraJanela * alturaJanela;
            float areaSala = areaParedes - areaJanela - areaPorta;
            float quantidadeTijolos = areaSala / areaTijolo;

            // saida
            Console.WriteLine("Você precisa de " + quantidadeTijolos + " tijolos.");
            */





        }
    }
}