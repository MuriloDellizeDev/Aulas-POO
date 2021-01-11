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
    public class EquipeController : Controller
    {

        Equipe equipeModel = new Equipe();


        /// <summary>
        /// Aponta para index da minhs view
        /// </summary>
        /// <returns>retorna a própria view</returns>
        public IActionResult Index()
        {

            ViewBag.Equipes = equipeModel.ReadAll();
            return View();

        }

        /// <summary>
        /// Cadstra dados do formulario
        /// </summary>
        /// <param name="form">Dados do formulario</param>
        /// <returns>Redireciona para a mesma página</returns>
        public IActionResult Cadastrar(IFormCollection form)
        {

            Equipe novaEquipe   = new Equipe();
            novaEquipe.IdEquipe = Int32.Parse(form["IdEquipe"]);
            novaEquipe.Nome     = form["Nome"];


            //Upload da imagem
            var file    = form.Files[0];
            var folder  = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/img/Equipes");

            if(file != null)
            {
                if(!Directory.Exists(folder)){
                    Directory.CreateDirectory(folder);
                }
                // caminho  - www/root/img/Eqquipe/arquivo.pdf
                var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/img/", folder, file.FileName);
                using (var stream = new FileStream(path, FileMode.Create))  
                {  
                    file.CopyTo(stream);  
                }
                novaEquipe.Imagem   = file.FileName;
            }
            else
            {
                novaEquipe.Imagem   = "padrao.png";
            } 
            //Fim do upload da imagem

            

            equipeModel.Create(novaEquipe); 

            ViewBag.Equipes = equipeModel.ReadAll();
            return LocalRedirect("~/Equipe");
            
        }


        [Route("Equipe/{id}")]
        public IActionResult Excluir(int id){

            equipeModel.Delete(id);
            return LocalRedirect("~/Equipe");

        }

    }
}