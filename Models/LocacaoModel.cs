using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MoviesPilgrim.Models
{
   [Table("tblocacoes")]
    public class LocacaoModel
    {
        [Key]
        [Column("id_locacao")]
        public int IdLocacao { get; set; }

        [ForeignKey("Cliente")]
        [Column("fk_id_cliente")]
        public int FkIdCliente { get; set; }

        [ForeignKey("Filme")]
        [Column("fk_id_filme")]
        public int FkIdFilme { get; set; }

        [DataType(DataType.DateTime)]
        [Column("data_locacao")]
        public DateTime DataLocacao { get; set; }

        [DataType(DataType.DateTime)]
        [Column("data_limite")]
        public DateTime DataLimite { get; set; }

        [Column("status_locacao")]
        public Statuslocacao StatusLocacao { get; set; }

        [Column("total_locacao")]
        public decimal TotalLocacao { get; set; }
    }

    public enum Statuslocacao
    {
        Locando,
        Atrasado,
        Devolvido
    }
}