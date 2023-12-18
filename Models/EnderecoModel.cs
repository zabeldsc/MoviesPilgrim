using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MoviesPilgrim.Models
{
    [Table("tbendereco")]
    public class EnderecoModel
    {
        [Column("id_endereco")]
        public int Id { get; set; }
        public string CEP { get; set; }
        public string endereco { get; set; }
        public string numero { get; set; }
        public string bairro { get; set; }
        public string cidade { get; set; }
        public string estado { get; set; }
        public string pais { get; set; }
    }

}