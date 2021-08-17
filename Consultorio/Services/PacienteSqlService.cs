using Consultorio.Data;
using Consultorio.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;


namespace Consultorio.Services
{    
    public class PacienteSqlService : IPacienteService
    {
        ConsultorioContext context;
        public PacienteSqlService(ConsultorioContext context)
        {
            this.context = context;
        }

        public List<Paciente> getAll(string busca = null, bool ord = false)
        {
            List<Paciente> lista = context.Paciente.Include(p => p.Consultas).ToList();
            if (busca != null)
            {
                return lista.FindAll(a =>
                    a.Nome.ToLower().Contains(busca.ToLower())
                );
            }

            if (ord)
            {                
                lista = lista.OrderBy(p => p.Nome).ToList();
                return lista;
            }
            return lista;
        }
        public bool create(Paciente paciente)
        {
            try
            {
                context.Paciente.Add(paciente);
                context.SaveChanges();                
                return true;
            }
            catch
            {
                return false;
            }
        }
        public Paciente get(int? id)
        {
            return context.Paciente.Include($"{nameof(Paciente.Consultas)}.{nameof(Consulta.especialidade)}").FirstOrDefault(p => p.Id == id);
        }

        public bool update(Paciente p)
        {
            try
            {
                context.Paciente.Update(p);
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
                context.Paciente.Remove(get(id));
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
