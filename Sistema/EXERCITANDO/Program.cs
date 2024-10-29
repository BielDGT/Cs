using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EXERCITANDO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            cabeçalho();
            Opcao();

        }

        public static void cabeçalho()
        {
            Console.WriteLine("Criado por David Gabriel Tarley\nTodos os direitos reservados para DGT");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(@"
███████╗██╗░░██╗███████╗██████╗░░█████╗░██╗████████╗░█████╗░███╗░░██╗██████╗░░█████╗░
██╔════╝╚██╗██╔╝██╔════╝██╔══██╗██╔══██╗██║╚══██╔══╝██╔══██╗████╗░██║██╔══██╗██╔══██╗
█████╗░░░╚███╔╝░█████╗░░██████╔╝██║░░╚═╝██║░░░██║░░░███████║██╔██╗██║██║░░██║██║░░██║
██╔══╝░░░██╔██╗░██╔══╝░░██╔══██╗██║░░██╗██║░░░██║░░░██╔══██║██║╚████║██║░░██║██║░░██║
███████╗██╔╝╚██╗███████╗██║░░██║╚█████╔╝██║░░░██║░░░██║░░██║██║░╚███║██████╔╝╚█████╔╝
╚══════╝╚═╝░░╚═╝╚══════╝╚═╝░░╚═╝░╚════╝░╚═╝░░░╚═╝░░░╚═╝░░╚═╝╚═╝░░╚══╝╚═════╝░░╚════╝░");
            Console.ResetColor();
        }

        public static void Opcao()
        {
            Console.WriteLine("Digite 00 para sair");
            Console.WriteLine("Digite 01 para Exercicio 1");
            Console.WriteLine("Digite 02 para Exercicio 2");
            Console.WriteLine("Digite 03 para Exercicio 3");
            Console.WriteLine("Digite 04 para Exercicio 4");
            Console.WriteLine("Digite 05 para Exercicio 5");
            Console.WriteLine("Digite 06 para Ecercicio 6");
            string escolha = Console.ReadLine();
            switch (escolha)
            {
                case "00":
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine(@"
░██████╗░█████╗░██╗███╗░░██╗██████╗░░█████╗░░░░░░░░░░
██╔════╝██╔══██╗██║████╗░██║██╔══██╗██╔══██╗░░░░░░░░░
╚█████╗░███████║██║██╔██╗██║██║░░██║██║░░██║░░░░░░░░░
░╚═══██╗██╔══██║██║██║╚████║██║░░██║██║░░██║░░░░░░░░░
██████╔╝██║░░██║██║██║░╚███║██████╔╝╚█████╔╝██╗██╗██╗
╚═════╝░╚═╝░░╚═╝╚═╝╚═╝░░╚══╝╚═════╝░░╚════╝░╚═╝╚═╝╚═╝");
                    Thread.Sleep(1000);
                    Console.ResetColor();
                    break;


                case "01":
                    Exercicio1();
                    cabeçalho();
                    Opcao();
                    break;

                case "02":
                    Exercicio2();
                    cabeçalho();
                    Opcao();
                    break;

                case "03":
                    Exercicio3();
                    cabeçalho();
                    Opcao();
                    break;

                case "04":
                    Exercicio4();
                    cabeçalho();
                    Opcao();
                    break;

                case "05":
                    Exercicio5();
                    cabeçalho();
                    Opcao();
                    break;

                case "06":
                    Exercicio6();
                    cabeçalho();
                    Opcao();
                    break;


            }
        }

        private static void Exercicio1()
        {
            Console.Clear();
            Console.WriteLine("Exercicio 1 \nEscreva um programa que verifique se um número fornecido pelo usuário é positivo, negativo ou zero. \nDigite um numero:");
            int escolha1=int.Parse(Console.ReadLine());
            if(escolha1>0)
            {
                Console.WriteLine($"O numero {escolha1} é positivo");
            }
            else if (escolha1<0)
            {
                Console.WriteLine($"O numero {escolha1} é negativo");
            }
            else
            {
                Console.WriteLine($"O numero {escolha1} é zero");
            }
            Thread.Sleep(3000);
            Console.Clear();
        }

        private static void Exercicio2()
        {
            Console.Clear();
            Console.WriteLine("Exercicio 2 \nCrie um programa que leia a idade de uma pessoa e informe se ela é maior de idade (18 anos ou mais) ou menor de idade. \nInforme sua Idade:");
            int escolha2 = int.Parse(Console.ReadLine());
            if(escolha2 >= 18)
            {
                Console.WriteLine($"Você com {escolha2} é maior de idade");
            }
            else if(escolha2 < 18 && escolha2>=0)
            {
                Console.WriteLine($"Você com {escolha2} é menor de idade");
            }
            else
            {
                Console.WriteLine("Numero invalido!!");
            }
            Thread.Sleep(3000);
            Console.Clear();
        }

        private static void Exercicio3()
        {
            Console.Clear();
            Console.WriteLine("Exercicio 3 \nEscreva um programa que verifique se um número fornecido pelo usuário é par ou ímpar. \nDigite um numero");
            int escolha3 = int.Parse(Console.ReadLine());
            if(escolha3%2==0)
            {
                Console.WriteLine($"O numero {escolha3} é par");
            }
            else
            {
                Console.WriteLine($"O numero {escolha3} é impar");
            }
            Thread.Sleep(3000);
            Console.Clear();
        }

        private static void Exercicio4()
        {
            Console.Clear();
            Console.WriteLine("Exercicio 4 \nCrie um programa que leia três números e determine qual é o maior. \n Digite um numero:");
            int x=int.Parse(Console.ReadLine());
            Console.WriteLine("Digite outro numero:");
            int y=int.Parse(Console.ReadLine());
            Console.WriteLine("Digite outro numero:");
            int z=int.Parse(Console.ReadLine());
            if(x>y && x>z)
            {
                Console.WriteLine($"{x} é o maior numero");
            }else if (y > x && y > z)
            {
                Console.WriteLine($"{y} é o maior numero");
            }else
            {
                Console.WriteLine($"{z} é o maior numero");
            }
            Thread.Sleep(3000);
            Console.Clear();

        }

        private static void Exercicio5()
        {
            Console.Clear();
            Console.WriteLine("Exercicio 5 \nEscreva um programa que verifique se uma letra fornecida pelo usuário é uma vogal ou uma consoante. \nDigite uma letra:");
            string letra=Console.ReadLine();
            if(letra=="a"||letra=="e" || letra == "i" || letra == "o" || letra == "u" || letra == "A" || letra == "E" || letra == "I" || letra == "O" || letra == "U")
            {
                Console.WriteLine($"A letra {letra} é uma vogal");
            }else
            {
                Console.WriteLine($"A letra {letra} é uma consoante");
            }
            Thread.Sleep(3000);
            Console.Clear();
        }

        private static void Exercicio6()
        {
            Console.Clear();
            Console.WriteLine("Exercicio 6 \nFaça um programa que leia a nota de um aluno e informe se ele está aprovado (nota maior ou igual a 7), em recuperação (nota entre 5 e 7) ou reprovado (nota menor que 5). \nInforme a nota:");
            int nota = int.Parse(Console.ReadLine());
            if(nota >= 7)
            {
                Console.WriteLine("Aprovado");
            }else if(nota < 7 && nota >= 5)
            {
                Console.WriteLine("Recuperação");
            }else if(nota < 5 && nota >=0)
            {
                Console.WriteLine("Reprovado");
            }else
            {
                Console.WriteLine("Nota informada invalida");
            }
            Thread.Sleep(3000);
            Console.Clear();

        }

    }
}
