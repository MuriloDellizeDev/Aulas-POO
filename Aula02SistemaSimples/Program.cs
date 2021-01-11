using System;

namespace Aula02SistemaSimples
{
    class Program
    {
        static void Main(string[] args)
        {
            Alunos alun = new Alunos();

            

            System.Console.Write("Digite seu nome: ");
            alun.nome = Console.ReadLine();

            System.Console.Write("Digite sua idade: ");
            alun.idade = int.Parse(Console.ReadLine());

            System.Console.Write("Digite suas notas: ");
            alun.mediaFinal = float.Parse(Console.ReadLine());

            // System.Console.Write("Digite sua porcentagem de bolsa: " );
            // alun.porcentagemDesconto = int.Parse(Console.ReadLine());


            Console.WriteLine( "Média final: " +alun.mediaFinal );
            Console.WriteLine( "Mensalidade: " +alun.VerMensalidade() );
            

           

           

        }
    }
}
