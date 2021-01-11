namespace Aula08Abstracao
{
    public class Cartao : Pagamento
    {
        protected string token = "g42424u49g49g4ugu8hbgsygfye8947t4nt90tj4jmwmls";


        public string numero { get; set; }

        public string cvv { get; set; }

        public string bandeira { get; set; }

        public bool ValidarToken(){
            if (token != null){
            return true;
            }
            return false;
        }




    }
}