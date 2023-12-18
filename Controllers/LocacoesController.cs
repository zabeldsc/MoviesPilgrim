using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MoviesPilgrim.Models;
using MoviesPilgrim.Repository;

namespace MoviesPilgrim.Controllers
{
    
    public class LocacoesController : Controller
    {
        private readonly ILocadoraRepository _locadoraRepository;
        public LocacoesController(ILocadoraRepository locadoraRepository){
            _locadoraRepository = locadoraRepository;
        }

        public IActionResult Index()
        {
            List<ViewLocacoes> Locacoes = _locadoraRepository.ListarLocacoes();
            return View(Locacoes);
        }

        public IActionResult Criar(){
            return View();
        }

        public IActionResult Editar(){
            return View();
        }

        public IActionResult VerificarDeletar(){
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}