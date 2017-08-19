using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace EFCodeFirst
{
    [Table("Produto")]
    public class Produto
    {
        public int ID { get; set; }
        [Required(ErrorMessage="Não pode ser em branco.")]
        public string Descricao { get; set; }
        public int GrupoID { get; set; }

        [ForeignKey("GrupoID")]
        public virtual Grupo Grupo { get; set; }
    }
}
