/*using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace MoviesPilgrim.Models
{
    public class ItemLocacaoModel
    {
    [ForeignKey("Locacao")]
    [Column("fk_id_locacao")]
    public int FkIdLocacao { get; set; }
    public Locacao Locacao { get; set; }

    [ForeignKey("Filme")]
    [Column("fk_id_filme")]
    public int FkIdFilme { get; set; }
    public Filme Filme { get; set; }

    public int QuantidadeFilme { get; set; }

    [Column(TypeName = "DECIMAL(10,2)")]
    public decimal Subtotal { get; set; }
    }
}*/