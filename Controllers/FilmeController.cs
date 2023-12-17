using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MoviesPilgrim.Models;
using MoviesPilgrim.Data;
using MoviesPilgrim.Repository;

namespace MoviesPilgrim.Controllers;

public class FilmeController : Controller
{
    private readonly IFilmeRepository filme_Repository;
    public FilmeController(IFilmeRepository filmeRepository){
        filme_Repository = filmeRepository;
    }
    public IActionResult Index(){
        List<Filme> filme = filme_Repository.listarFilmes();
        return View(filme);
    }
    public IActionResult Criar(){
        return View();
    }

    [HttpPost]
    public IActionResult CriarFilme(Filme filme){
        filme_Repository.adicionar(filme);
        return RedirectToAction("Index");
    }
    
    public IActionResult Editar(int id){
        var filme = filme_Repository.buscarId(id);
        return View(filme);
    }

    [HttpPost]
    public IActionResult Atualizar(Filme filme){
        filme_Repository.atualizar(filme);
        return RedirectToAction("Index");
    }

    public IActionResult VerificarDeletar(int id){
        var filme = filme_Repository.buscarId(id);
        return View(filme);
    }
    public IActionResult Deletar(int id){
        filme_Repository.deletar(id);
        return RedirectToAction("Index");
    }
}