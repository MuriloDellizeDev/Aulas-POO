using System;


namespace aula06Heranca
{
    class Program
    {
        static void Main(string[] args)
        {
            CPF cpf = new CPF();
            cpf.Nome = "Paulo";

            System.Console.WriteLine(cpf.saldar());

            cpf.cpf = "000.000.000-00";
            System.Console.WriteLine( cpf.ValidarCpf());

        }
    }
}
