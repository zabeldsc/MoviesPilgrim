using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MoviesPilgrim.Models
{
    [Table("tbfilme")]
    public class FilmeModel
    {
        [Column("id_filme")]
        public int Id { get; set; }
        public string titulo { get; set; }
        [MaxLength(250, ErrorMessage="A sinopse deve ter 250 caracteres ou menos")]
        public string sinopse { get; set; }
        public int quantidade { get; set; }
        [Column(TypeName = "DECIMAL(10,2)")]
        public decimal valor_filme { get; set; }
        [Column(TypeName = "DECIMAL(10,2)")]
        public decimal taxa_dia { get; set; }
        public string classificacao { get; set; }
        public string genero { get; set; }
    }

}