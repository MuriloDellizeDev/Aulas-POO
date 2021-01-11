using System;

namespace Aula19Dojo2
{
    class Program
    {
        static void Main(string[] args)
        {
           double valorNormal=0;
            Ler("Insira o valor do ingresso normal: ", ref valorNormal);
            double valorAdicional=0;
            Ler("Insira o valor adicional do ingresso VIP: ", ref valorAdicional);

            Ingresso ingressoNormal = new Ingresso(valorNormal);
            IngressoVIP ingressoDeBoy = new IngressoVIP(valorNormal, valorAdicional);

            Console.Clear();

            Console.WriteLine($"O valor do ingresso normal é: {ingressoNormal.ImprimirValor()}\nO valor do ingresso VIP é: {ingressoDeBoy.ImprimirValor()}\nA diferença de preço entre os ingressos é de R${ingressoDeBoy.ImprimirValor()-ingressoNormal.ImprimirValor()}.");
        }

        static void Ler(string mensagem, ref double variavel) {
            Console.Write(mensagem);
            variavel = Convert.ToDouble(Console.ReadLine());
        }
    }
        }
