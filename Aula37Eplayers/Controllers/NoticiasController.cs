using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Aula37Eplayers.Models;
using Microsoft.AspNetCore.Http;
using System.IO;

namespace Aula37Eplayers.Controllers
{
    public class NoticiasController : Controller
    {
        Noticias noticiasModel = new Noticias();



        /// <summary>
        /// SE DIRECIONA PARA A INDEX DA MINHA VIEW
        /// </summary>
        /// <returns>VIEW</returns>
        public IActionResult Index()
        {
            ViewBag.Noticias = noticiasModel.ReadAll();
            return View();
        }






        /// <summary>
        ///CADASTRA UM FORMULÁRIO
        /// </summary>
        /// <param name="form">FORMULÁRIO</param>
        /// <returns>O FORMULÁRIO NO IDEX EQUIPE</returns>
        public IActionResult Cadastrar(IFormCollection form){
            
            Noticias noticia    = new Noticias();
            noticia.IdNoticia   = Int32.Parse(form["IdNoticia"]); 
            noticia.Texto       = form["Texto"];
            noticia.Titulo      = form["Titulo"];



             // Upload da Imagem
            var file    = form.Files[0];

            
            var folder  = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/img/Noticias");

            if(file != null)
            {
                if(!Directory.Exists(folder)){
                    Directory.CreateDirectory(folder);
                }

                var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/img/", folder, file.FileName);
                using (var stream = new FileStream(path, FileMode.Create))  
                {  
                    file.CopyTo(stream);  
                }
                noticia.Imagem   = file.FileName;
            }
            else
            {
                noticia.Imagem   = "padrao.png";
            }
            // Fim - Upload da Imagem


            

            noticiasModel.Create(noticia);

            return LocalRedirect("~/Noticias"); 
        }

        [Route("[controller]/{id}")]

        public IActionResult Excluir(int id){
            noticiasModel.Delete(id);
            return LocalRedirect("~/Noticias");
        }
    }
}