using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MoviesPilgrim.Models
{
    public class ViewLocacoes
    {
        public int IdLocacao { get; set; }
        public string NomeCliente { get; set; }
        public string NomeFilme { get; set; }
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime DataLocacao { get; set; }
        public DateTime DataLimite { get; set; }
        [Column(TypeName = "ENUM")]
        [EnumDataType(typeof(EnumStatus))]
        public EnumStatus EnumStatus { get; set; }
        [Column(TypeName = "DECIMAL(10,2)")]
        public float Total { get; set; }

    }
}

public enum EnumStatus
{
    Atrasado,
    Devolvido,
    Locando
}