using System;

namespace Aula25Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            Fibonacci fibo = new Fibonacci();
            fibo.GerarSequenciaFibonacci(0,1,52);
            Console.WriteLine(fibo.GerarFatorial(5));
        }
    }
}
