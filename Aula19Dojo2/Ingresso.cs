namespace Aula19Dojo2
{
    public class Ingresso
    {
        public double ValorIngresso { get; private set; }

        /// <summary>
        ///   Construtor
        /// </summary>
        /// <param  valor do ingresso ></param>
        public Ingresso ( double valor){
            ValorIngresso = valor;
        }


        /// <summary>
        ///  Imprime o ingresso
        /// </summary>
        /// <returns> retorna o valor </returns>
        public virtual double ImprimirValor(){
            return ValorIngresso;
        }
    }
}
    
