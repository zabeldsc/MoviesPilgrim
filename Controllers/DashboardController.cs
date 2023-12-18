using System;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;
using MoviesPilgrim.Repository;
using MoviesPilgrim.Models;

namespace MoviesPilgrim.Controllers
{
    [Authorize]
    public class DashboardController : Controller
    {
        private readonly ILocadoraRepository _locadoraRepository;
        public DashboardController(ILocadoraRepository locadoraRepository){
                _locadoraRepository = locadoraRepository;
        }


        public IActionResult Index()
        {
            var viewModel = new LocacoesViewModel
        {
            LocacoesAtuais = _locadoraRepository.GetLocacoesAtuais(),
            LocacoesAtrasadas = _locadoraRepository.GetLocacoesAtrasadas(),
            LocacoesDevolvidas = _locadoraRepository.GetLocacoesDevolvidas(),
            TotalFilmesCadastrados = _locadoraRepository.CalcTotalFilmes(),
            TotalClientesLocacao = _locadoraRepository.TotalClientesLocacao(),
            TotalLocacoes = _locadoraRepository.TotalLocacoes()
        };
            return View(viewModel);
        }
        
        public IActionResult Error()
        {
            return View("Error!");
        }

    }
}