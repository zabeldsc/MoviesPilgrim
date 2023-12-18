using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesPilgrim.Models
{
    public class LocacoesViewModel
    {
        public List<ViewLocacoes> LocacoesAtuais { get; set; }
        public List<ViewLocacoes> LocacoesAtrasadas { get; set; }
        public List<ViewLocacoes> LocacoesDevolvidas { get; set; }

        public int TotalFilmesCadastrados;
        public int TotalClientesLocacao;
        public int TotalLocacoes;
    }
}