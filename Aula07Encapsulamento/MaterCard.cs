using System;

namespace Aula07Encapsulamento
{
    public class MasterCard : Cartao //HERANÇA
    {
        
        public int parcelas { get; set; }

        public void ComprarComDescontoMastercard(float desconto){

            // ULTILIZANDO ENCAPSULAMENTO COM ASSINATURA "PROTECTED"
            cvv = "456";
            
            Console.WriteLine($"Compra realizada com {parcelas} parcelas e R$ {desconto} de desconto");
        }

    }
}