using System;

namespace Aula01AtributosMetodos
{
    class Program
    {
        static void Main(string[] args)
        {
            // OBJETO
            Personagem tony = new Personagem();

            System.Console.WriteLine("Nome: " +tony.Nome);
            System.Console.WriteLine("Idade: " +tony.Idade);
            System.Console.WriteLine("Armadura: " +tony.Armadura);
            System.Console.WriteLine(tony.Atacar());
        }
    }
}
