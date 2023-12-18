using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesPilgrim.Models
{
    public class Filme
    {
        [DisplayName("Id_Filme")]
        public int Id { get; set; }
        public string titulo { get; set; }
        public string sinopse { get; set; }
        public int quantidade { get; set; }
        public decimal valor_filme { get; set; }
        public decimal taxa_dia { get; set; }
        public string classificacao { get; set; }
        public string genero { get; set; }
    }

}