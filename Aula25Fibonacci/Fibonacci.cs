namespace Aula25Fibonacci
{
    public class Fibonacci
    {   
        // Exemplo para gerar uma sequência Fibonacci começando de um valor , intervalo especifico e quantidade de repetições
        public void GerarSequenciaFibonacci(int numero1, int numero2, int vezes){
            
            //Condição obrigatória para quebrar a recursividade do método
            if(vezes > 0){

                System.Console.WriteLine(numero1);
                GerarSequenciaFibonacci(numero2, numero1 + numero2, vezes - 1);
            }
        }


        //Exemplo usando fatorial
        //5! = 5 * 4 * 3 * 2 * 1
        public int GerarFatorial(int numero){


            //Condição para quebrar a recursividade do método
            if(numero == 1){

                return 1;

            }else{

                return numero * GerarFatorial(numero - 1);

            }
        }
    }
}