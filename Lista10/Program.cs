using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Lista10
{
    internal class Program
    {

        public static void Exercicio1()
        {

            Console.Write("Digite o tamanho do vetor: ");
            int n = int.Parse(Console.ReadLine());

            float[] numeros = new float[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Digite o número {i + 1}: ");
                numeros[i] = float.Parse(Console.ReadLine());
            }

            float menor = numeros[0];
            float maior = numeros[0];
            float soma = numeros[0];

            for (int i = 1; i < n; i++)
            {
                if (numeros[i] < menor)
                    menor = numeros[i];

                if (numeros[i] > maior)
                    maior = numeros[i];

                soma += numeros[i];
            }

            float media = soma / n;

            Console.WriteLine("Menor número: {menor}");
            Console.WriteLine("Maior número: {maior}");
            Console.WriteLine("Média aritmética: {media}");


        }
        public static void Exercicio2()
        {
            Console.Write("Informe o tamanho do vetor: ");
            int n = int.Parse(Console.ReadLine());
            int[] vetor = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Informe o número {i + 1}: ");
                vetor[i] = Convert.ToInt32(Console.ReadLine());
            }


            double soma = 0;
            for (int i = 0; i < n; i++)
            {
                soma += vetor[i];
            }
            double media = soma / n;

            Console.WriteLine("Números maiores ou iguais à média:");
            for (int i = 0; i < n; i++)
            {
                if (vetor[i] >= media)
                {
                    Console.WriteLine(vetor[i]);
                }
            }
        }
        public static void Exercicio3()
        {
            Console.Write("Informe o tamanho do vetor: ");
            int n = int.Parse(Console.ReadLine());

            int[] vetor = new int[n];

            Random random = new Random();

           
            for (int i = 0; i < n; i++)
            {
                vetor[i] = random.Next(100); 
            }

            double soma = 0;
            for (int i = 0; i < n; i++)
            {
                soma += vetor[i];
            }
            double media = soma / n;

            Console.WriteLine("Números maiores ou iguais à média:");
     
            for (int i = 0; i < n; i++)
            {
                if (vetor[i] >= media)
                {
                    Console.WriteLine(vetor[i]);
                }
            }
        }

        public static void Exercicio4()
        {

            Console.Write("Informe a quantidade de assinaturas: ");
            int n = int.Parse(Console.ReadLine());
            List<string> assinaturas = new List<string>();


           
            for (int i = 0; i < n; i++)
            {
                Console.Write("Informe o nome da assinatura {i + 1}: ");
                string nome = Console.ReadLine();
                assinaturas.Add(nome);
            }

            Console.WriteLine("Nomes das assinaturas (ordem inversa):");
          
            for (int i = assinaturas.Count - 1; i >= 0; i--)
            {
                Console.WriteLine(assinaturas[i]);
            }
        }
     
        public static void Exercicio5()
        {
            Console.Write("Informe o tamanho do vetor: ");
            int n = int.Parse(Console.ReadLine());

            int[] vetor = new int[n];

            Random random = new Random();

           
            for (int i = 0; i < n; i++)
            {
                vetor[i] = random.Next(100);
            }

            int pares = 0;
            int impares = 0;

            
            for (int i = 0; i < n; i++)
            {
                if (vetor[i] % 2 == 0)
                {
                    pares++;
                }
                else
                {
                    impares++;
                }
            }

            Console.WriteLine($"Quantidade de números pares: {pares}");
            Console.WriteLine($"Quantidade de números ímpares: {impares}");
        }
    



        static void Main(string[] args)
        {
            int opcao;

            Console.Write("Digite um número correspondente a um exercicio (1 a 5:) ");
            opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    Exercicio1();
                    break;
                case 2:
                    Exercicio2();
                    break;
                case 3:
                    Exercicio3();
                    break;
                case 4:
                    Exercicio4();
                    break;
                    case 5:
                      Exercicio5();
                       break;
                    default:
                    Console.WriteLine("numero invalido");
                    break;
            }
        }
    }
}
