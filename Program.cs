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
            if ( valor1 == 0 && valor2 == 0){
                Console.WriteLine("Digite outro valor");
            } else{
                Console.WriteLine("Numero certo");
            }
          Console.WriteLine("O resultado da some entre " + valor1 + " e " + valor2 + " é " + soma);
        
           //Concatenação entre texto e váriaveis
          
        }
    }
}
