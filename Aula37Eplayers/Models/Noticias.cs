using System;
using System.Collections.Generic;
using System.IO;
using Aula37Eplayers.Interfaces;

namespace Aula37Eplayers.Models
{
    public class Noticias : EPlayersBase, INoticias
    {


        public int IdNoticia { get; set; }
        public string Titulo { get; set; }
        public string Texto { get; set; }
        public string Imagem { get; set; }
        private const string PATH = "Database/noticia.csv";  






        /// <summary>
        /// CRIA UM DIRETORIO SE NÃO HOUVER UM
        /// </summary>
        public Noticias(){

            CreateFolderAndFile(PATH);

        }




        
        /// <summary>
        /// CREATE / CRIA OU CADASTRA UMA NOTICIA
        /// </summary>
        /// <param name="n">Noticia</param>
        public void Create(Noticias n)
        {
            string[] linha = {PrepararLinha(n)};
            File.AppendAllLines(PATH, linha);  
        }









         /// <summary>
        ///     Formata cada linha do csv.
        /// </summary>
        /// <param name="n"> dados separados por ";".</param>
        /// <returns>Retorna uma string .</returns>
        private string PrepararLinha(Noticias n){
            return $"{n.IdNoticia};{n.Titulo};{n.Texto};{n.Imagem}  ";
        }













        /// <summary>
        /// DELETE / EXCLUIR ALGUMA NOTICIA
        /// </summary>
        /// <param name="IdNoticia">ID DA NOTICIA QUE SERÁ EXCLUIDA</param>
        public void Delete(int IdNoticia)
        {
            List<string> linhas = ReadAllLinesCSV(PATH);
            linhas.RemoveAll(x => x.Split(";")[0] == IdNoticia.ToString());
            RewriteCSV(PATH, linhas);
        }











        /// <summary>
        /// LÊ O CSV
        /// </summary>
        /// <returns> RETORNA AS LINHAS DO CSV SEPARADAS</returns>
        public List<Noticias> ReadAll()
        {
            List<Noticias> noticias = new List<Noticias>();
            string[] linhas = File.ReadAllLines(PATH);
            foreach (var item in linhas)
            {
                string[] linha = item.Split(";");
                Noticias noticia = new Noticias();
                noticia.IdNoticia = Int32.Parse(linha[0]);
                noticia.Titulo = linha[1];
                noticia.Texto = linha[2];
                noticia.Imagem = linha[3];

                noticias.Add(noticia);
            }
            return noticias;
        }












        /// <summary>
        /// UPDATE / ALTERA OU ATUALIZA UMA NOTICIA
        /// </summary>
        /// <param name="n">Noticia</param>
        public void Update(Noticias n)
        {
            List<string> linhas = ReadAllLinesCSV(PATH);
            linhas.RemoveAll( x => x.Split(";")[0] == n.IdNoticia.ToString());
            linhas.Add(PrepararLinha(n) );
            RewriteCSV(PATH, linhas);
        }
    }
}