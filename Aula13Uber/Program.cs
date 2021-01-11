using System;

namespace Aula13Uber
{
    class Program
    {
        static void Main(string[] args)
        {
           Passageiro paulo = new Passageiro();

           Console.WriteLine("Digite seu login:");
           string login = Console.ReadLine();

           Console.WriteLine("Digite sua senha:");
           string senha = Console.ReadLine();

           paulo.Login(login, senha);


        }
    }
}
