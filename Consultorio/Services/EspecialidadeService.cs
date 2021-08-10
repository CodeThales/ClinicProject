using Consultorio.Data;
using Consultorio.Models;
using System.Collections.Generic;
using System.Linq;

namespace Consultorio.Services
{
    public class EspecialidadeService : IEspecialidadeService
    {
        ConsultorioContext context;
        public EspecialidadeService(ConsultorioContext context)
        {
            this.context = context;
        }

        public List<Especialidade> getAll()
        {
            
            return context.Especialidade.ToList();          
           
        }
        public bool create(Especialidade especialidade)
        {
            try
            {
                context.Especialidade.Add(especialidade);
                context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public Especialidade get(int? id)
        {
            return context.Especialidade.FirstOrDefault(e => e.Id == id);
        }

        public bool update(Especialidade e)
        {
            try
            {
                context.Especialidade.Update(e);
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
            try
            {
                context.Especialidade.Remove(get(id));
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
