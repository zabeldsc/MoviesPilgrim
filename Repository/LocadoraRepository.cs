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
        public FilmeModel adicionar(FilmeModel filme)
        {
            application_DbContext.Filmes.Add(filme);
            application_DbContext.SaveChanges();
            return filme;
        }

        public List<FilmeModel> listarFilmes(){
            return application_DbContext.Filmes.ToList();
        }
        public FilmeModel buscarId(int id){
            return application_DbContext.Filmes.FirstOrDefault(x => x.Id == id);
        }
        public FilmeModel atualizar(FilmeModel filme){
            FilmeModel filmeDB = buscarId(filme.Id);

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
            FilmeModel filmeDB = buscarId(id);

            if(filmeDB == null) throw new Exception("Filme não foi encontrado");

            application_DbContext.Filmes.Remove(filmeDB);
            application_DbContext.SaveChanges();
            return true;
        }
    
    public List<ViewLocacoes> ListarLocacoes(){
            return application_DbContext.ViewLocacoes.ToList();
    }
    

    // public int TotalFilmesCadastrados()
    // {
    //     return application_DbContext.Filmes.Count();
    // }

    // public int TotalLocacoes()
    // {
    //     return application_DbContext.Locacoes.Count();
    // }

    // public int TotalMultasAcumuladas()
    // {
    //     return application_DbContext.Multas.Select(m => m.valor_multa).Count();
    // }

    // public int TotalClientesLocacao()
    // {
    //     return application_DbContext.Locacoes.Select(l => l.fk_id_cliente).Distinct().Count();
    // }

    // public List<LocacaoModel> LocacoesAtuais()
    //     {
    //         return application_DbContext.Locacoes
    //             .Where(l => l.status_locacao == status_locacao.Locando)
    //             .ToList();
    //     }

    // public List<LocacaoModel> LocacoesAtrasadas()
    //     {
    //         return application_DbContext.Locacoes
    //             .Where(l => l.status_locacao == status_locacao.Atrasado)
    //             .ToList();
    //     }

    // public List<LocacaoModel> LocacoesDevolvidas()
    //     {
    //         return application_DbContext.Locacoes
    //             .Where(l => l.status_locacao == status_locacao.Devolvido)
    //             .ToList();
    //     }
        
    
    
    public List<ViewLocacoes> GetLocacoesAtuais()
        {
            return application_DbContext.ViewLocacoes
                .Where(l => l.Statuslocacao == Statuslocacao.Locando)
                .ToList();
        }

    public List<ViewLocacoes> GetLocacoesAtrasadas()
        {
            return application_DbContext.ViewLocacoes
                .Where(l => l.Statuslocacao == Statuslocacao.Atrasado)
                .ToList();
        }

    public List<ViewLocacoes> GetLocacoesDevolvidas()
        {
            return application_DbContext.ViewLocacoes
                .Where(l => l.Statuslocacao == Statuslocacao.Devolvido)
                .ToList();
        }


    


}
}