using Consultorio.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Consultorio.Data
{
    //Contextos gerenciam a conexão com o banco de dados
    //Utilizado para criar tabelas, buscar dados, inserir dados, etc
    public class ConsultorioContext : IdentityDbContext
    {
        public ConsultorioContext(DbContextOptions<ConsultorioContext> options) : base(options)
        { }


        public DbSet<Paciente> Paciente { get; set; }
        public DbSet<Consulta> Consulta { get; set; }
        public DbSet<Especialidade> Especialidade { get; set; }

    }
}
