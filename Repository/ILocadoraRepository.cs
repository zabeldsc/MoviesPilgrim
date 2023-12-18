using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MoviesPilgrim.Models;

namespace MoviesPilgrim.Repository
{
    public interface ILocadoraRepository
    {
        FilmeModel adicionar(FilmeModel filme);
        FilmeModel buscarId(int id);
        FilmeModel atualizar(FilmeModel filme);
        List<FilmeModel> listarFilmes();
        bool deletar(int id);

        List<ViewLocacoes> ListarLocacoes();

        // int TotalFilmesCadastrados();
        // int TotalClientesLocacao();
        // int TotalLocacoes();
        // decimal TotalMultasAcumuladas();
        // List<LocacaoModel> LocacoesAtuais();
        // List<LocacaoModel> LocacoesAtrasadas();
        // List<LocacaoModel> LocacoesDevolvidas();

        List<ViewLocacoes> GetLocacoesAtuais();
        List<ViewLocacoes> GetLocacoesAtrasadas();
        List<ViewLocacoes> GetLocacoesDevolvidas();

        int CalcTotalFilmes();
        int TotalClientesLocacao();
        int TotalLocacoes();
    }
}