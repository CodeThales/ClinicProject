//using Consultorio.Models;
//using Microsoft.EntityFrameworkCore;
//using Microsoft.Extensions.DependencyInjection;
//using Microsoft.Extensions.Hosting;
//using System;
//using System.Linq;

//namespace Consultorio.Data
//{
//    public static class SeedDatabase
//    {
//        public static void Initialize(IHost app)
//        {
//            using (var scope = app.Services.CreateScope())
//            {
//                var serviceProvider = scope.ServiceProvider;
//                var context = serviceProvider.GetRequiredService<ConsultorioContext>();
//                context.Database.Migrate();

//                if (!context.Paciente.Any())
//                {
//                    context.Paciente.Add(new Paciente { Nome = "Italo", Nascimento = new DateTime(1980, 10, 08), Tel = "1111-1111" });
//                    context.Paciente.Add(new Paciente { Nome = "Eduardo", Nascimento = new DateTime(1995, 01, 25), Tel = "2222-2222" });
//                    context.Paciente.Add(new Paciente { Nome = "Janio", Nascimento = new DateTime(2000, 7, 5), Tel = "3333-3333" });
//                    context.Paciente.Add(new Paciente { Nome = "Filipe", Nascimento = new DateTime(2000, 7, 5), Tel = "4444-4444" });
//                    context.Paciente.Add(new Paciente { Nome = "Gabriel", Nascimento = new DateTime(2000, 7, 5), Tel = "5555-5555" });
//                }

//                context.SaveChanges();
//            }
//        }
//    }
//}
