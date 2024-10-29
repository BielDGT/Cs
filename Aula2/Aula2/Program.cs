using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Aula2
{
    public class Program
    {
        static void Main(string[] args){
            Cabeçalho();
            OpMenu();
        }
        public static void Cabeçalho(){
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(@"
██████╗░░█████╗░██╗░░░██╗██╗██████╗░
██╔══██╗██╔══██╗██║░░░██║██║██╔══██╗
██║░░██║███████║╚██╗░██╔╝██║██║░░██║
██║░░██║██╔══██║░╚████╔╝░██║██║░░██║
██████╔╝██║░░██║░░╚██╔╝░░██║██████╔╝
╚═════╝░╚═╝░░╚═╝░░░╚═╝░░░╚═╝╚═════╝░");
            Console.WriteLine("═════════════════════════════════════════");
            Console.WriteLine("Aluno Senac Americana");
            Console.WriteLine("═════════════════════════════════════════");
            Console.WriteLine(@"
▀█▀ █ ▀█ █░█
░█░ █ █▄ ▀▀█");
            Console.WriteLine("═════════════════════════════════════════");
            Console.ResetColor();
        }

        public static void OpMenu(){
            Console.WriteLine("\nDigite 1 para registrar info");
            Console.WriteLine("\nDigite 2 para listar info");
            Console.WriteLine("\nDigite 3 para apagar info");
            Console.WriteLine("\nDigite 0 para sair");
            Console.WriteLine("\nDigite a opção escolhida: ");
            string escolha = Console.ReadLine();
            /*if (escolha == "1")
            {
                Console.WriteLine("\n opção 1");
            }*/

            switch (escolha)
            {   case "1":
                    CadInfo();
                    break;
                case "2":
                    Console.WriteLine("\nOpção 2");
                    Thread.Sleep(3000);
                    Console.Clear();
                    Cabeçalho();
                    OpMenu();
                    break;
                case "3": 
                    Console.WriteLine("\nOpção 3");
                    Thread.Sleep(3000);
                    Console.Clear();
                    Cabeçalho();
                    OpMenu();
                    break;
                case "0": 
                    Console.Clear();
                    Console.WriteLine(@"
░██████╗░█████╗░██╗███╗░░██╗██████╗░░█████╗░░░░░░░░░░
██╔════╝██╔══██╗██║████╗░██║██╔══██╗██╔══██╗░░░░░░░░░
╚█████╗░███████║██║██╔██╗██║██║░░██║██║░░██║░░░░░░░░░
░╚═══██╗██╔══██║██║██║╚████║██║░░██║██║░░██║░░░░░░░░░
██████╔╝██║░░██║██║██║░╚███║██████╔╝╚█████╔╝██╗██╗██╗
╚═════╝░╚═╝░░╚═╝╚═╝╚═╝░░╚══╝╚═════╝░░╚════╝░╚═╝╚═╝╚═╝");
                    Thread.Sleep(3000);
                    break;
                default: 
                    Console.WriteLine("\nOpção invalida");
                    Thread.Sleep(3000);
                    Console.Clear();
                    Cabeçalho();
                    OpMenu();
                    break;

            }
        }

        private static void CadInfo(){
            Console.Clear();
            Console.WriteLine("Cadastro de Cliente");
            Console.WriteLine("Digite seu Nome: ");
            string Nome = Console.ReadLine();
            Console.WriteLine($"\n Nome Cadastrado com Sucesso!!! {Nome}");
            Thread.Sleep(3000);
            Console.Clear();
            Cabeçalho();
            OpMenu();

        }
    }
}
