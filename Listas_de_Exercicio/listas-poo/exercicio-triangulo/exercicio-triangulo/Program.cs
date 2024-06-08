using System;

namespace triangulo
{
    public class Triangulo
    {
        // atributos da classe
        public double cateto1;
        public double cateto2;
        public double hipotenusa;

        // construtor
        public Triangulo(double cateto1, double cateto2, double hipotenusa)
        {
            this.cateto1 = cateto1;
            this.cateto2 = cateto2;
            this.hipotenusa = hipotenusa;
        }

        // destrutor
        ~Triangulo()
        {
            Console.WriteLine("Destrutor Inicializado");
        }

        // métodos get
        public double getCateto1() {
            return this.cateto1;
        }
        public double getCateto2() {
            return this.cateto2;
        }
        public double getHipotenusa() {
            return this.hipotenusa;
        }

        // métodos set
        public void setCateto1(double cateto1) {
            this.cateto1 = cateto1;
        }
        public void setCateto2(double cateto2) {
            this.cateto2 = cateto2;
        }
        public void setHipotenusa(double hipotenusa) {
            this.hipotenusa = hipotenusa;
        }

        // metodo da classe - calcular a area do triangulo
        public double CalcularArea(double cateto1, double cateto2)
        {
            return (this.cateto1 * this.cateto2) / 2;
        }
    }

    class Program
    {
        static void Main(string[]args)
        {
            // pegar dados dos triangulos
            Console.WriteLine("Insira o comprimento do lado A do triângulo X:");
            double cateto1X = double.Parse(Console.ReadLine());
            Console.WriteLine("Insira o comprimento do lado B do triângulo X:");
            double cateto2X = double.Parse(Console.ReadLine());
            Console.WriteLine("Insira o comprimento da hipotenusa do triângulo X:");
            double HipotenusaX = double.Parse(Console.ReadLine());

            Console.WriteLine("Insira o comprimento do lado A do triângulo Y:");
            double cateto1Y = double.Parse(Console.ReadLine());
            Console.WriteLine("Insira o comprimento do lado B do triângulo Y:");
            double cateto2Y = double.Parse(Console.ReadLine());
            Console.WriteLine("Insira o comprimento da hipotenusa do triângulo Y:");
            double HipotenusaY = double.Parse(Console.ReadLine());

            // criar objeto Triangulo do triangulo X
            Triangulo trianguloX = new Triangulo(cateto1X, cateto2X, HipotenusaX);

            // criar objeto Triangulo do triangulo Y
            Triangulo trianguloY = new Triangulo(cateto1Y, cateto2Y, HipotenusaY);

            // calcular area dos triangulos
            double areaTrianguloX = trianguloX.CalcularArea(cateto1X, cateto2X);
            Console.WriteLine("A área do triângulo X é: {0}", areaTrianguloX);

            double areaTrianguloY = trianguloY.CalcularArea(cateto1Y, cateto2Y);
            Console.WriteLine("A área do triângulo Y é: {0}", areaTrianguloY);
                  
            // comparar áreas
            if (areaTrianguloX > areaTrianguloY)
            {
                Console.WriteLine("O triângulo X possui a maior área.");
            } else if (areaTrianguloY > areaTrianguloX)
            {
                Console.WriteLine("O triângulo Y possui a maior área.");
            } else
            {
                Console.WriteLine("Os triângulos possuem áreas iguais.");
            }
        }
    }
}
