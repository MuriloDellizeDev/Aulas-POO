namespace Aula04POOCelular
{
    public class Celular
    {
        public string cor;

        public string modelo;

        public float tamanho;

        public string ligado;

        public string desligado;

        public void LigadoDesligado( string ligado, string desligado){

            if(ligado == "sim"){

               System.Console.WriteLine("Celular Ligado");
            }
            else if (desligado == "nao"){
                 System.Console.WriteLine("Celular Desligado");
            }
            
           
        }

    }

}

    

       
