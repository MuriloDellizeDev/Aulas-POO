using System;

namespace Aula08Abstracao
{
    public class Boleto
    {
        public DateTime dataVenciemnto { get; set; }

        public string bancoEmissor { get; set; }

        public string codDeBarras { get; set; }

        public string Registrar(){
            return "Boleto registrado com sucesso";
        }
    }
}