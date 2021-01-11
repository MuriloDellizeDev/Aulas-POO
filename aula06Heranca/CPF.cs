namespace aula06Heranca
{
    public class CPF : Pessoa  //HERANÇA DA SUPER CLASSE PESSOA//
    {
        public string cpf;
        public string rg;

        public bool ValidarCpf(){
            if(cpf != null){
                return true;
            }

            return false;
        }
    }
}