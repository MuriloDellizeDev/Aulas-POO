using System;

namespace Aula07Encapsulamento
{
    public class Cartao
    {
        public string numero { get; set; }

        public string titular { get; set; }

        public string  bandeira { get; set; }

        private string token = "12131gt42h5h456j345j35";

        protected string cvv { get; set; }

        public void AprovarCompra(){

            System.Console.WriteLine("Conta Aprovada");
        }

        private bool ValidarToken(){
            if(token != null){
                
            return true;
            }
            return false;
        }

        protected bool ValidarCompra(){
            return true;
        }

    }
}