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
    }
}