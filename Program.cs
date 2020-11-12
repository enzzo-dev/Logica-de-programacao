using System;


namespace Logica_de_programação
{
    class Program
    {
        static void Main(string[] args)
        {
            //Aqui vai o código
            //Entrada
            /*Console.WriteLine("Digite um número:");
            int valor1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite outro valor:");
            int valor2 = int.Parse(Console.ReadLine());
            //Processamento
            int soma = valor1 + valor2;
            //Exibir
                if ( valor1 == 0 && valor2 == 0){
                    Console.WriteLine("Digite um valor válido!");
                }
            Console.WriteLine("O resultado da some entre " + valor1 + " e " + valor2 + " é " + soma);
            //Concatenação entre texto e váriaveis*/

            //Entrada de dados
            Console.WriteLine("Qual o nome do aluno?");
            string nome = Console.ReadLine();  

            Console.WriteLine("Digite a Primeira nota:");
            float nota1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite a Segunda nota:");
            float nota2 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite a Terceira nota:");
            float nota3 = float.Parse(Console.ReadLine());


            //Processamento
            float media = (nota1 + nota2 + nota3) / 3;

            //Exibir
            if (media >= 5){
                 Console.WriteLine("A média do(a) Aluno(a) "+nome+ " é igual a: "+media);
                Console.WriteLine("Parabens, você está na média ou acima dela!");
            } else {
                Console.WriteLine("O(a) Aluno(a) "+nome+ " está de recuperação e sua média foi: "+media);
            }
           
        
        }
    }
}
