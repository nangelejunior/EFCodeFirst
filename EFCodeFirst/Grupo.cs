using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace EFCodeFirst
{
    [Table("Grupo")]
    public class Grupo
    {
        public int ID { get; set; }
        [Required(ErrorMessage="Não pode ser em branco.")]
        public string Nome { get; set; }

        public virtual IQueryable<Produto> Produtos { get; set; }
    }
}
