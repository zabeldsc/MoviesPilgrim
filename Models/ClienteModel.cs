using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MoviesPilgrim.Models
{
    [Table("tbclientes")]
    public class ClienteModel
    {
        [Column("id_cliente")]
        public int Id { get; set; }
        public string nome { get; set; }
        public string email { get; set; }
        public string telefone { get; set; }

        [ForeignKey("FkIdEndereco")]
        [Column("fk_id_endereco")]
        public int FkIdEndereco { get; set; }
        public EnderecoModel Endereco { get; set; }
    }

}