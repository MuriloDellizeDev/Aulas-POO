namespace Aula02SistemaSimples
{
    public class Alunos
    {
       public string nome;
        public string curso;
        public int idade;
        public string rg;
        public bool bolsista;
        
        public int desconto;
        public int porcentagemDesconto;
        public float mediaFinal;
        public int valorMensalidade;

        public double VerMediaFinal(){
            return mediaFinal;
        }

        public int VerMensalidade(){

             return (2000 * (10 / 100));
            
        }


   

        
    }
}