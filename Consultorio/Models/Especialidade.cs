using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Consultorio.Models
{
    public class Especialidade
    {
        [Display(Name = "#")]
        public int Id { get; set; }

        [Required(ErrorMessage = "Informe o tipo de especialidade!")]
        [Display(Name = "Especialidade")]
        public string Nome { get; set; }

        [Display(Name = "Informações adicionais")]
        public string Descricao { get; set; }

    }
}
