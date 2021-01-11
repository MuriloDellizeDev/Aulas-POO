namespace Aula13Uber
{
    public class Usuario
    {
        public string  Nome { get; set; }

        private int idade;

        public int Idade
        {
            get { return idade; }
            set {
                if (idade > 0){
                    idade = value;
                } 
            }
    }

        public string Foto { get; set; }

        private string login = "paulo@gmail.com";

        private string senha = "123456789";

        public string LocalizacaoAtual { get; set; }

        public string TokenLogin { get; set; }

        public bool Login (string login, string senha){

            if( this.login == login && this.senha == senha){
                TokenLogin = "alsmf04u848gh7wg7t98qh9gh8nw";
                return true;
            }

            return false;
        }

        public void logout(){
            TokenLogin = "";
        }
   } 
}