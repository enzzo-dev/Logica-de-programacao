using System;

namespace Logica_de_programação
{
    class Program
    {
        static void Main(string[] args)
        {
            //Aqui vai o código
         //Entrada
         Console.WriteLine("Digite um número:");
         int valor1 = int.Parse(Console.ReadLine());
         Console.WriteLine("Digite outro valor:");
          int valor2 = int.Parse(Console.ReadLine());

          //Processamento
           int soma = valor1 + valor2;
         
          //Exibir
          Console.WriteLine(" A soma dos valores é: " + soma);
        }
    }
}
