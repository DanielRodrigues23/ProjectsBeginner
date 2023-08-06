using System;
using System.Globalization;

namespace Exercicio01
{
    class Program
    {
        static void Main(string[] args)
        {

            CultureInfo ci = CultureInfo.InvariantCulture;

                  //LENDO OS DADOS
            Console.WriteLine("Entre com seu nome completo: ");
            string nome = Console.ReadLine();
            Console.WriteLine("Quantos quartos tem na sua casa ? ");
            int quartos = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o preço de um produto: ");
            double PrecoProduto = double.Parse(Console.ReadLine(), ci);
            Console.WriteLine("Entre seu ultimo nome, idade, altura (mesma linha): ");
            string[] vet = Console.ReadLine().Split(' ');
            string SegundoNome = vet[0];
            int idade = int.Parse(vet[1]);
            double altura = double.Parse(vet[2], ci);

            
                 //IMPRIMINDO OS DADOS
            Console.WriteLine(nome);
            Console.WriteLine(quartos);
            Console.WriteLine(PrecoProduto.ToString("F2", ci));
            Console.WriteLine(SegundoNome);
            Console.WriteLine(idade);
            Console.WriteLine(altura.ToString("F2", ci));
        }
    }
}