using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MoviesPilgrim.Models;
using MoviesPilgrim.Data;
using MoviesPilgrim.Repository;

namespace MoviesPilgrim.Controllers;

public class FilmeController : Controller
{
    
    private readonly ILocadoraRepository _locadoraRepository;
    public FilmeController(ILocadoraRepository locadoraRepository){
            _locadoraRepository = locadoraRepository;
    }


    public IActionResult Index(){
        List<FilmeModel> filme = _locadoraRepository.listarFilmes();
        return View(filme);
    }
    public IActionResult Criar(){
        return View();
    }

    [HttpPost]
    public IActionResult CriarFilme(FilmeModel filme){
        _locadoraRepository.adicionar(filme);
        return RedirectToAction("Index");
    }
    
    public IActionResult Editar(int id){
        var filme = _locadoraRepository.buscarId(id);
        return View(filme);
    }

    [HttpPost]
    public IActionResult Atualizar(FilmeModel filme){
        _locadoraRepository.atualizar(filme);
        return RedirectToAction("Index");
    }

    public IActionResult VerificarDeletar(int id){
        var filme = _locadoraRepository.buscarId(id);
        return View(filme);
    }
    public IActionResult Deletar(int id){
        _locadoraRepository.deletar(id);
        return RedirectToAction("Index");
    }
}