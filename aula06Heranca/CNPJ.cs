namespace aula06Heranca
{
    public class CNPJ
    {
        public string cnpj;

        public bool ValidarCnpj(){
            if(cnpj != null){
                return true;
            }

            return false;
        }
    }
}