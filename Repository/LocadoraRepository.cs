using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MoviesPilgrim.Data;
using MoviesPilgrim.Models;

namespace MoviesPilgrim.Repository
{
    public class LocadoraRepository : ILocadoraRepository
    {
        private readonly ApplicationDbContext application_DbContext;
        public LocadoraRepository(ApplicationDbContext applicationDbContext){
            application_DbContext = applicationDbContext;
        }
        public Filme adicionar(Filme filme)
        {
            application_DbContext.Filmes.Add(filme);
            application_DbContext.SaveChanges();
            return filme;
        }

        public List<Filme> listarFilmes(){
            return application_DbContext.Filmes.ToList();
        }
        public Filme buscarId(int id){
            return application_DbContext.Filmes.FirstOrDefault(x => x.Id == id);
        }
        public Filme atualizar(Filme filme){
            Filme filmeDB = buscarId(filme.Id);

            if(filmeDB == null) throw new Exception("Filme não foi encontrado");

            filmeDB.titulo = filme.titulo;
            filmeDB.sinopse = filme.sinopse;
            filmeDB.quantidade = filme.quantidade;
            filmeDB.valor_filme = filme.valor_filme;
            filmeDB.taxa_dia = filme.taxa_dia;
            filmeDB.classificacao = filme.classificacao;
            filmeDB.genero = filme.genero;

            application_DbContext.Filmes.Update(filmeDB);
            application_DbContext.SaveChanges();
            return filmeDB;
        }

        public bool deletar(int id){
            Filme filmeDB = buscarId(id);

            if(filmeDB == null) throw new Exception("Filme não foi encontrado");

            application_DbContext.Filmes.Remove(filmeDB);
            application_DbContext.SaveChanges();
            return true;
        }
    
    public List<ViewLocacoes> ListarLocacoes(){
            return application_DbContext.ViewLocacoes.ToList();
    }
    
    }
}