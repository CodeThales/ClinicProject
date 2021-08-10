using Consultorio.Models;
using Consultorio.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;


namespace Consultorio.Controllers
{    
    public class ConsultaController : Controller
    {
        IConsultaService service;
        IPacienteService pacienteService;
        IEspecialidadeService especialidadeService;

        public ConsultaController(IConsultaService service, IPacienteService pacienteService, IEspecialidadeService especialidadeService)
        {
            this.service = service;
            this.pacienteService = pacienteService;
            this.especialidadeService = especialidadeService;
        }

        public IActionResult Index()
        {          

            return View(service.getAll());
        }

        [HttpGet]
        public IActionResult Create()
        {
            var pacientes = pacienteService.getAll();
            var especialidades = especialidadeService.getAll();
            ViewBag.listaDePacientes = new SelectList(pacientes, "Id", "Nome");
            ViewBag.listaDeEspecialidades = new SelectList(especialidades, "Id", "Nome");
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Consulta consulta)
        {
            var pacientes = pacienteService.getAll();
            ViewBag.listaDePacientes = new SelectList(pacientes, "Id", "Nome");

            var especialidades = especialidadeService.getAll();
            ViewBag.listaDeEspecialidades = new SelectList(especialidades, "Id", "Nome");

            if (!ModelState.IsValid) return View(consulta);

            if (service.create(consulta))
            {
                return RedirectToAction(nameof(Index));
            }
            else
            {
                return View(consulta);
            }

        }


        public IActionResult Read(int? id)
        {
            Consulta consulta = service.get(id);
            return consulta != null ? View(consulta) : NotFound();
        }

        public IActionResult Update(int? id)
        {
            var pacientes = pacienteService.getAll();
            ViewBag.listaDePacientes = new SelectList(pacientes, "Id", "Nome");

            var especialidades = especialidadeService.getAll();
            ViewBag.listaDeEspecialidades = new SelectList(especialidades, "Id", "Nome");

            var consulta = service.get(id);
            return consulta != null ? View(consulta) : NotFound();
        }

        [HttpPost] 
        [ValidateAntiForgeryToken]
        public IActionResult Update(Consulta consulta)
        {            

            if (!ModelState.IsValid)
            {
                var pacientes = pacienteService.getAll();
                ViewBag.listaDePacientes = new SelectList(pacientes, "Id", "Nome");

                var especialidades = especialidadeService.getAll();
                ViewBag.listaDeEspecialidades = new SelectList(especialidades, "Id", "Nome");

                return View(consulta);
            }
            service.update(consulta);
            return RedirectToAction(nameof(Index));            
        }

        public IActionResult Delete(int? id)
        {
            if (service.delete(id))
            {
                return RedirectToAction(nameof(Index));
            }
            else
            {
                return NotFound();
            }
        }

        public IActionResult Confirm(int? id)
        {
            Consulta consulta = service.get(id);
            if (consulta != null)
            {
                return View(nameof(Confirm));
            }
            return NotFound();
        }
    }
}
