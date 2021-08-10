using Consultorio.Data;
using Consultorio.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;


namespace Consultorio.Services
{    
    public class ConsultaSqlService : IConsultaService
    {
        ConsultorioContext context;
        public ConsultaSqlService(ConsultorioContext context)
        {
            this.context = context;
        }

        public List<Consulta> getAll()
        {
            return context.Consulta.Include(c => c.paciente).Include(c => c.especialidade).ToList();
        }
        public bool create(Consulta consulta)
        {
            try
            {
                context.Consulta.Add(consulta);
                context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public Consulta get(int? id)
        {
            return context.Consulta.Include(c => c.paciente).Include(c => c.especialidade).FirstOrDefault(p => p.id == id);
        }

        public bool update(Consulta consulta)
        {
            try
            {
                context.Consulta.Update(consulta);
                context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool delete(int? id)
        {
            try { 
                context.Consulta.Remove(get(id));
                context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
