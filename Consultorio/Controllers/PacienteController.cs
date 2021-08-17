using Consultorio.Models;
using Consultorio.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;


namespace Consultorio.Controllers
{   
    [Authorize]
    public class PacienteController : Controller
    {
        IPacienteService _serviceStatic, _serviceSql, _service;

        public PacienteController (PacienteSqlService serviceSql, PacienteStaticService serviceStatic)
        {
            _serviceStatic = serviceStatic;
            _serviceSql = serviceSql;
            _service = serviceSql;
        }

        private void SelectService(string service = "sql")
        {
            switch (service)
            {
                case "sql":
                    this._service = this._serviceSql;
                    break;
                case "static":
                    this._service = this._serviceStatic;
                    break;
                default:
                    this._service = this._serviceSql;
                    break;
            }
        }

        private void SetViewBag(string source = null)
        {
            ViewBag.source = source;
        }

        public IActionResult Index(string busca, bool ordenar = false, string service="sql")
        {
            SelectService(service);
            if (service == "sql") SetViewBag(source: "sql");
            if (service == "static") SetViewBag(source: "static");
            ViewBag.selectedService = service;

            ViewBag.ordenar = ordenar;        

            return View(_service.getAll(busca,ordenar));
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Paciente paciente)
        {
            if (!ModelState.IsValid) return View(paciente);

            TempData["Adicionado"] = "Paciente adicionado com sucesso!";

            return _service.create(paciente) ? RedirectToAction(nameof(Index)) : View(paciente);            
            
        }  
            

        public IActionResult Read(int? id)
        {
            Paciente paciente = _service.get(id);
            return paciente != null ? View(paciente) : NotFound();
        }

        public IActionResult Update(int? id)
        {
            Paciente paciente = _service.get(id);
            return paciente != null ? View(paciente) : NotFound();
        }

        [HttpPost] 
        [ValidateAntiForgeryToken]
        public IActionResult Update(Paciente paciente)
        {
            if(!ModelState.IsValid) return View(paciente);

            if (_service.update(paciente))
            {

                TempData["Atualizado"] = "Paciente atualizado com sucesso!";
                return RedirectToAction(nameof(Index));
            }
            else
            {
                return View(paciente);
            }
        }

        public IActionResult Delete(int? id)
        {
            if (_service.delete(id))
            {

                TempData["Excluido"] = "Paciente Excluido com sucesso!";
                return RedirectToAction(nameof(Index));
            }
            else
            {
                return NotFound();
            }
        }

        public IActionResult Confirm(int? id)
        {
            Paciente paciente = _service.get(id);
            if (paciente != null)
            {
                return View(nameof(Confirm));
            }
            return NotFound();
        }
    }
}
