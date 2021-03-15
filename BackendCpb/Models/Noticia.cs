using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BackendCpb.Models
{
    [Table("noticias")]
    public class Noticia
    {
        [Key]
        public int noticiaid { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatorio")]
        public string titulo { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatorio")]
        public string conteudo { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatorio")]
        public DateTime noticiadata { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatorio")]
        public string imagem { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatorio")]
        public string categoria { get; set; }
    }
}
