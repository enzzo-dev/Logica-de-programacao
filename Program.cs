using System;


namespace Logica_de_programação
{
    class Program
    {
        static void Main(string[] args)
        {
            //Aqui vai o código

            //Aula do dia 11/11
            
            Console.WriteLine("Digite um número:");
            int valor1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite outro valor:");
            int valor2 = int.Parse(Console.ReadLine());
            //Processamento
            int soma = valor1 + valor2;
            //Exibir
            if ( valor1 == 0 && valor2 == 0){
                Console.WriteLine("Digite um valor válido!");
            }
            Console.WriteLine("O resultado da soma entre " + valor1 + " e " + valor2 + " é " + soma);
        
            //Data da aula 11/11

            //Data da aula 12/11

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
            
            //Aula do dia 12/11

           //Aula do 13/11

            Console.WriteLine("Qual a sua idade?");
            int idade = int.Parse(Console.ReadLine());
            if(idade >= 18){
            Console.WriteLine("Você gostaria de participar do time de CS G0? - Sim ou Não");
            string resposta = Console.ReadLine();
            if(resposta == "Sim"){
                Console.WriteLine("Compareça a seretaria - Faar com a Sara");
            } else {
                Console.WriteLine("Blz! Passar bem!");
            }
            } else{
                Console.WriteLine("Você gostaria de participar do time de LOL?");
                string resposta = Console.ReadLine();
                if( resposta == "Sim"){
                    Console.WriteLine("Compareça a secretaria - Falar com Juscelino!");
                } else {
                    Console.WriteLine("Muito obrigado!");
                }
            } 

            //Exercicio1
            Console.WriteLine("Qual a sua idade?");
            int ano = int.Parse(Console.ReadLine());

            int mes = 12;
            int dias = 31;
            int horas = 24;
            int minutos = 60;

            int idadeMes = mes * ano;
            int idadeDias = dias * idadeMes;
            int idadeHoras = horas * idadeDias;
            int idadeMinutos = minutos * idadeHoras;

            Console.WriteLine(" Sua idade é "+ano+ " anos, "+idadeMes+ " meses, " +idadeDias+ " Dias, " +idadeHoras+ " Horas, " +idadeMinutos+ " Minutos.");
 



            //Exercicio 2
            Console.WriteLine("Qual o ano de seu nascimento?");
            int ano2 = int.Parse(Console.ReadLine());
            int anoAtual = 2020;
            int semana = 52;

            int idadeNasc = anoAtual - ano2;
            int idadeSemana = idade * semana;

            Console.WriteLine("Você tem " +idadeNasc+ " Anos");

            Console.WriteLine("Sua idade em semanas é: " +idadeSemana+ " semanas"); 


            //Exercicio 3

             Console.WriteLine("Qual o seu salário?");
            float salario = float.Parse(Console.ReadLine());
            float aumento =  30;
            float reajuste = (salario * (aumento/100))+salario;
            if ( salario < 500){
                Console.WriteLine("Você tem direito a um aumento! E o reajuste do seu salário vai ficar igual a: "+reajuste+ " reais");
            } else {
                Console.WriteLine("Você não tem direito ao reajuste de acordo com seu salário!");
            }
            

            //Desafio 1

            Console.WriteLine("Digite sua idade");
            int idadeNatacao = int.Parse(Console.ReadLine());

            string categoria1 = "Infantil-A";
            string categoria2 = "Infantil-B";
            string categoria3 = "Juvenil-A";
            string categoria4 = "Juvenil-B";
            string categoria5 = "Senior";

            if(idadeNatacao >= 5 && idadeNatacao<=7){
                System.Console.WriteLine("Você está inserido dentro da categoria: "+categoria1);
            } else if( idadeNatacao >= 8 && idadeNatacao<=10 ){
                System.Console.WriteLine("Você está inserido dentro da categoria: " +categoria2);
            } else if(idadeNatacao >= 11 && idadeNatacao<=13){
                 System.Console.WriteLine("Você está inserido dentro da categoria: " +categoria3);
            } else if(idadeNatacao >= 14 && idadeNatacao<=17){
                 System.Console.WriteLine("Você está inserido dentro da categoria: " +categoria4);
            } else if(idadeNatacao >= 18){
                 System.Console.WriteLine("Você está inserido dentro da categoria: " +categoria5);
            }

        }
    }
}
