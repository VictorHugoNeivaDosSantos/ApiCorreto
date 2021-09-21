using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication3.Model
{
    [Table("produto")]
    public class ProdutoModel
    {    
        [Column("id")]
        public long Id { get; set; }
        [Column("descricao")]
        public string Descricao { get; set; }
        [Column("preco_custo")]
        public double PrecoCusto { get; set; }
    }
}
