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
        public LocadoraRepository(ApplicationDbContext applicationDbContext)
        {
            application_DbContext = applicationDbContext;
        }
        public FilmeModel adicionar(FilmeModel filme)
        {
            application_DbContext.Filmes.Add(filme);
            application_DbContext.SaveChanges();
            return filme;
        }

        public List<FilmeModel> listarFilmes()
        {
            return application_DbContext.Filmes.ToList();
        }
        public FilmeModel buscarId(int id)
        {
            return application_DbContext.Filmes.FirstOrDefault(x => x.Id == id);
        }
        public FilmeModel atualizar(FilmeModel filme)
        {
            FilmeModel filmeDB = buscarId(filme.Id);

            if (filmeDB == null) throw new Exception("Filme não foi encontrado");

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

        public bool deletar(int id)
        {
            FilmeModel filmeDB = buscarId(id);

            if (filmeDB == null) throw new Exception("Filme não foi encontrado");

            application_DbContext.Filmes.Remove(filmeDB);
            application_DbContext.SaveChanges();
            return true;
        }

        public List<ViewLocacoes> ListarLocacoes()
        {
            return application_DbContext.ViewLocacoes.ToList();
        }

        public LocacaoModel CriarLocacao(LocacaoModel locacao)
        {
            application_DbContext.Locacoes.Add(locacao);
            application_DbContext.SaveChanges();
            return locacao;
        }

        // Read
        public LocacaoModel ObterLocacaoPorId(int id)
        {
            return application_DbContext.Locacoes.Find(id);
        }

        public LocacaoModel AtualizarLocacao(LocacaoModel locacao)
        {
            LocacaoModel locacaoDB = ObterLocacaoPorId(locacao.IdLocacao);

            if (locacaoDB == null)
            {
                // Considere utilizar uma exceção específica, por exemplo: NotFoundException
                throw new Exception("Locação não foi encontrada");
            }

            locacaoDB.FkIdCliente = locacao.FkIdCliente;
            locacaoDB.FkIdFilme = locacao.FkIdFilme;
            locacaoDB.DataLocacao = locacao.DataLocacao;
            locacaoDB.DataLimite = locacao.DataLimite;
            locacaoDB.StatusLocacao = locacao.StatusLocacao;
            locacaoDB.TotalLocacao = locacao.TotalLocacao;

            application_DbContext.Locacoes.Update(locacaoDB);
            application_DbContext.SaveChanges();

            return locacaoDB;
        }


        // Delete
        public void ExcluirLocacao(int id)
        {
            var locacao = application_DbContext.Locacoes.Find(id);
            if (locacao != null)
            {
                application_DbContext.Locacoes.Remove(locacao);
                application_DbContext.SaveChanges();
            }
        }


        public int TotalFilmesCadastrados()
        {
            return application_DbContext.Filmes.Count();
        }


        public int TotalLocacoes()
        {
            return application_DbContext.Locacoes.Count();
        }
/*
        public int TotalMultasAcumuladas()
        {
            return application_DbContext.Multas.Select(m => m.valor_multa).Count();
        }

        public int TotalClientesLocacao()
        {
            return application_DbContext.Locacoes.Select(l => l.fk_id_cliente).Distinct().Count();
        }*/

        public List<LocacaoModel> LocacoesAtuais()
        {
            return application_DbContext.Locacoes
                .Where(l => l.StatusLocacao == Statuslocacao.Locando)
                .ToList();
        }

        public List<LocacaoModel> LocacoesAtrasadas()
        {
            return application_DbContext.Locacoes
                .Where(l => l.StatusLocacao == Statuslocacao.Atrasado)
                .ToList();
        }

        public List<LocacaoModel> LocacoesDevolvidas()
        {
            return application_DbContext.Locacoes
                .Where(l => l.StatusLocacao == Statuslocacao.Devolvido)
                .ToList();
        }



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

        public int CalcTotalFilmes()
        {

            return application_DbContext.Filmes.Count();
        }

        public int TotalClientesLocacao()
        {
            return application_DbContext.ViewLocacoes.Select(l => l.NomeCliente).Distinct().Count();
        }

        public decimal TotalMultasAcumuladas()
        {
            throw new NotImplementedException();
        }
    }
}