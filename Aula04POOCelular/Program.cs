using System;

namespace Aula04POOCelular
{
    class Program
    {
        static void Main(string[] args)
        {
            Celular xiaomi = new Celular();

           xiaomi.modelo = "Xiaomi mi 9";
           xiaomi.cor = "preto";
           xiaomi.tamanho = 6.39f;


            Console.WriteLine("Deseja um celular ligado?");

            void LigadoDesligado()  = Console.ReadLine();
            xiaomi.desligado = Console.ReadLine();

            Console.Write("Seu celular está: " +xiaomi.ligado);

    
  
        }
    }
    }