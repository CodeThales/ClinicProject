using System;
using System.ComponentModel.DataAnnotations;


namespace Consultorio.Models
{
    public class Consulta
    {
        [Display(Name = "#")]
        public int id { get; set; }

        [Display(Name = "Data/Hora")]
        [Required(ErrorMessage = "Informe data e hora para a consulta!")]
        public DateTime? data { get; set; }

        [Display(Name = "Observação")]        
        public string descricao { get; set; }


        [Display(Name = "Nome do paciente")]
        [Required(ErrorMessage = "Escolha o paciente!")]
        public int pacienteId { get; set; }

        [Display(Name = "Nome do paciente")]
        public Paciente paciente { get; set; }


        [Display(Name = "Especialidade")]
        public int especialidadeId { get; set; }

        [Display(Name = "Especialidade")]
        public Especialidade especialidade { get; set; }
    }
}
