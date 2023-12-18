using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MoviesPilgrim.Models;

namespace MoviesPilgrim.Repository
{
    public interface ILocadoraRepository
    {
        Filme adicionar(Filme filme);
        Filme buscarId(int id);
        Filme atualizar(Filme filme);
        List<Filme> listarFilmes();
        bool deletar(int id);

        List<ViewLocacoes> ListarLocacoes();
    }
}