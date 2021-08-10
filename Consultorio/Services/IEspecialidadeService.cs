using Consultorio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Consultorio.Services
{
    public interface IEspecialidadeService
    {
        bool create(Especialidade especialidade);
        bool delete(int? id);
        Especialidade get(int? id);
        List<Especialidade> getAll();
        bool update(Especialidade especialidade);
    }
}
