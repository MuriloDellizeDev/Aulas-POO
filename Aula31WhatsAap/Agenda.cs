using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Aula31WhatsAap
{
    public class Agenda : IAgenda
    {
        List<Contato> contatos = new List<Contato>();
        private const string PATH ="Database/contato.csv";

         public Agenda()
        {

            
            if(!File.Exists(PATH))
            {

                Directory.CreateDirectory("Database");
                File.Create(PATH).Close();
            }
        }

      
        public void Cadastrar(Contato cont)
        {

            
            var linha = new string[] { PrepararLinhaCSV(cont) };
            File.AppendAllLines(PATH, linha);
        }

                public void Excluir(Contato cont)
        {

            //Lista Backup
            List<string> linhas = new  List<string>();

            //Refatoração 
            LerCSV(linhas);

            //Removemos as linhas que tiverem o termo
            linhas.RemoveAll(l => l.Contains(cont.Nome));

            //Refatoração Aplicada
            ReescreverCSV(linhas);
        }

        public List<Contato> Listar()
        {
            //Lista retorno
            
            
            string[] linhas = File.ReadAllLines(PATH);

            foreach(string linha in linhas)
            {

                //Separamos os dados de cada linha com o split (string[] vetores = linha.Split(";"))
                string[] dado = linha.Split(";");
                
                //Criam-se instâncias de produtos para serem colocados na lista
                Contato c = new Contato(dado[0], dado[1]);
                
                //Adicionamos o Contato para a lista
                contatos.Add(c);
            }

            //Usa-se o OrderBy para mandar o Nome em ordem para a lista criada
            contatos = contatos.OrderBy(x => x.Nome).ToList();
            return contatos;
        }

        private void ReescreverCSV(List<string> lines){
            
            //Reescreve-se o CSV do zero
            using(StreamWriter output = new StreamWriter(PATH)){

                //Cria-se o ln aqui
                foreach(string ln in lines){

                    output.Write(ln + "\n");
                }
            }
        }

        private void LerCSV(List<string> lines){

            using(StreamReader arquivo = new StreamReader(PATH)){

                //StreamReader vai ler o nosso CSV
                //Using serve para não sobrecarregar o sistema, ele abre e fehca o arquivo
                string line;
                while((line = arquivo.ReadLine()) !=null){
                    
                    lines.Add(line);
                } 
            }
        }
        
        private string Separar(string _coluna){

            //Separa as colunas para obter os valores necesários
            return _coluna.Split("=")[1];
        }
        private string PrepararLinhaCSV(Contato c){

            //Prepara as linhas do csv para que elas fiquem do jeito desejado
             return $"{c.Nome};{c.Telefone}";
        }

    }
}