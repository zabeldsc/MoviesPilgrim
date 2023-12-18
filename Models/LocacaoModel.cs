// using System;
// using System.Collections.Generic;
// using System.ComponentModel;
// using System.Linq;
// using System.Threading.Tasks;
// using System.ComponentModel.DataAnnotations;
// using System.ComponentModel.DataAnnotations.Schema;

// namespace MoviesPilgrim.Models
// {
//     public class LocacaoModel
//     {
//     [Key]
//     [Column("id_locacao")]
//     public int IdLocacao { get; set; }

//     [ForeignKey("Cliente")]
//     [Column("fk_id_cliente")]
//     public int FkIdCliente { get; set; }
//     public Cliente Cliente { get; set; }

//     [ForeignKey("Filme")]
//     [Column("fk_id_filme")]
//     public int FkIdFilme { get; set; }
//     public Filme Filme { get; set; }

//     [DataType(DataType.DateTime)]
//     public DateTime data_locacao { get; set; }

//     [DataType(DataType.DateTime)]
//     public DateTime data_limite { get; set; }

//     [DataType(DataType.DateTime)]
//     public DateTime data_atualizacao { get; set; }

//     public EnumStatus status_locacao { get; set; }

//     [Column(TypeName = "DECIMAL(10,2)")]
//     public decimal total_locacao { get; set; }

//     public List<ItemLocacao> ItensLocacao { get; set; }
//     }
// }