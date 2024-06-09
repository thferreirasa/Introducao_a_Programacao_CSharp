using exercicioProduto;
using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace exercicioProduto
{
    public class Produto
    {
        // atributos
        public string nome;
        public double preco;
        public int quantidade;

        // construtor
        public Produto(string nome, double preco, int quantidade)
        {
            this.nome = nome;
            this.preco = preco;
            this.quantidade = quantidade;
        }

        // destrutor
        ~Produto()
        {
            Console.WriteLine("Destrutor Inicializado.");
        }

        // metodos get e set
        public string getNome() { return this.nome; }
        public double getPreco() { return this.preco; }
        public int getQuantidade() { return this.quantidade; }

        public void setNome(string nome) { this.nome = nome; }
        public void setPreco(double preco) { this.preco = preco; }
        public void setQuantidade(int quantidade) { this.quantidade = quantidade; }

        // metodos da classe
            // nomes dos produtos e calcular valor total a ser pago
            // valor dos produtos
            // quantidade de unidades
            // calculo do valor a ser pago
        
        public double CalcularPreco(string nome, double preco, int quantidade)
        {
            this.nome = nome;
            this.preco = preco;
            this.quantidade = quantidade;
            double valorTotal = preco * quantidade;

            if (quantidade > 10 && quantidade < 21)
            {
                valorTotal = valorTotal * 0.9;
                Console.WriteLine("O valor da compra de {0} {1} é de {2}", quantidade, nome, valorTotal);
            } else if (quantidade > 20 && quantidade < 51)
            {
                valorTotal = valorTotal * 0.8;
                Console.WriteLine("O valor da compra de {0} {1} é de {2}", quantidade, nome, valorTotal);
            } else if (quantidade > 50)
            {
                valorTotal = valorTotal * 0.75;
                Console.WriteLine("O valor da compra de {0} {1} é de {2}", quantidade, nome, valorTotal);
            } else
            {
                Console.WriteLine("O valor da compra de {0} {1} é de {2}", quantidade, nome, valorTotal);
            }

            return valorTotal;
        }
       
        }
    }

   
    public class Program
    {
        static void Main(string[]args)
        {
            // rodar a compra
            Console.WriteLine("Informe a quantidade de açúcar comprado:");
            int quantAcucar = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe a quantidade de feijão comprado:");
            int quantFeijao = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe a quantidade de tapioca comprada:");
            int quantTapioca = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe a quantidade de arroz comprado:");
            int quantArroz = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe a quantidade de café comprado:");
            int quantCafe = int.Parse(Console.ReadLine());

            // criar objetos produtos e valores
            
            Produto acucar = new Produto("acucar", 6, quantAcucar);
            Produto feijao = new Produto("feijao", 8, quantFeijao);
            Produto tapioca = new Produto("tapioca", 5, quantTapioca);
            Produto arroz = new Produto("arroz", 8, quantArroz);
            Produto cafe = new Produto("cafe", 6, quantCafe);

            // rodar a compra
            acucar.CalcularPreco(acucar.nome, acucar.preco, acucar.quantidade);
            feijao.CalcularPreco(feijao.nome, feijao.preco, feijao.quantidade);
            tapioca.CalcularPreco(tapioca.nome, tapioca.preco, tapioca.quantidade);
            arroz.CalcularPreco(arroz.nome, arroz.preco, arroz.quantidade);
            cafe.CalcularPreco(cafe.nome, cafe.preco, cafe.quantidade);
        }
    }