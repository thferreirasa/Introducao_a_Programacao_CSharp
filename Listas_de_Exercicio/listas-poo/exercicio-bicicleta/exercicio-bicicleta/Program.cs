using System;

namespace exercicioBicicleta
{
    public class Bicicleta
    {
        // atributos
        public double velocidade;
        public string cor;

        // construtor
        public Bicicleta(double velocidade, string cor)
        {
            this.velocidade = velocidade;
            this.cor = cor;
        }

        // destrutor
        ~Bicicleta()
        {
            Console.WriteLine("Destrutor Inicializado.");
        }

        // métodos get e set
        public double getVelocidade()
        {
            return this.velocidade;
        }

        public void setVelocidade(double velocidade)
        {
            this.velocidade = velocidade;
        }

        public string getCor()
        {
            return this.cor;
        }

        public void setCor()
        {
            this.cor = cor;
        }

        // método Acelerar
        public void Acelerar(double aceleracao)
        {
            this.velocidade = this.velocidade + aceleracao;
        }

        // método CalculaDistancia
        public double CalculaDistancia(double posicaoInicial, double posicaoFinal)
        {
            return posicaoFinal - posicaoInicial;
        }
    }

    class Program
    {
        static void Main(string[]args)
        {           
            // criar objeto bicicleta
            Bicicleta bicicletaAzul = new Bicicleta(0, "azul");

            // acelerar a bicicleta
            Console.WriteLine("A velocidade da bicicleta é 0. Quanto você quer acelerar a bicicleta?");
            double acelerarBicicleta = double.Parse(Console.ReadLine());
            bicicletaAzul.Acelerar(acelerarBicicleta);

            Console.WriteLine("A bicicleta foi acelerada e está com velocidade de {0}", bicicletaAzul.velocidade);

            // calcular distancia da bicicleta
            Console.WriteLine("Informe a posição inicial em km da bicicleta:");
            double posicaoInicial = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe a posição final em km da bicicleta:");
            double posicaoFinal = double.Parse(Console.ReadLine());

            double distanciaBicicleta = bicicletaAzul.CalculaDistancia(posicaoInicial, posicaoFinal);

            Console.WriteLine("O deslocamento da bicicleta foi de {0}km.", distanciaBicicleta);
        }
    }
}
