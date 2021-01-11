using System;

namespace Aula31WhatsAap
{
    class Program
    {
        static void Main(string[] args)
        {
           Agenda agenda = new Agenda();
            Contato c1 = new Contato("Murilo  ", "(11) 98475-8425");
            Contato c2 = new Contato("Carlos  ", "(15) 98475-4758");
            Contato c3 = new Contato("Paulo", "(51) 98471-8796");

            agenda.Cadastrar(c1);
            agenda.Cadastrar(c2);
            agenda.Cadastrar(c3);

            agenda.Excluir(c2);

            foreach(Contato c in agenda.Listar())
            {
                Console.WriteLine($"Nome: {c.Nome} - Tel: {c.Telefone}");
            }
            Mensagem msg = new Mensagem();
            msg.Destinatario = c3;
            msg.Texto  = "OII " + msg.Destinatario.Nome + "!";
            System.Console.WriteLine( msg.Enviar());
        }
    }
}
