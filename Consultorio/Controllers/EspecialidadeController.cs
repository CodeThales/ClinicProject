using Consultorio.Models;
using Consultorio.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;


namespace Consultorio.Controllers
{   
    public class EspecialidadeController : Controller
    {
        IEspecialidadeService service;
        
        public EspecialidadeController(IEspecialidadeService service)
        {
            this.service = service;
            
        }

        public IActionResult Index()
        {
                   

            return View(service.getAll());
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Especialidade especialidade)
        {            
            if (!ModelState.IsValid) return View(especialidade);

            if (service.create(especialidade))
            {
                return RedirectToAction(nameof(Index));
            }
            else
            {
                return View(especialidade);
            }
        }  
            

        public IActionResult Read(int? id)
        {
            Especialidade especialidade = service.get(id);
            return especialidade != null ?
                View(especialidade) :
                NotFound();
        }

        public IActionResult Update(int? id)
        {
            Especialidade especialidade = service.get(id);
            return especialidade != null ?
                View(especialidade) :
                NotFound();
        }

        [HttpPost] 
        [ValidateAntiForgeryToken]
        public IActionResult Update(Especialidade especialidade)
        {
            if(!ModelState.IsValid) return View(especialidade);

            if (service.update(especialidade))
            {
                return RedirectToAction(nameof(Index));
            }
            else
            {
                return View(especialidade);
            }
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
            Especialidade especialidade = service.get(id);
            if (especialidade != null)
            {
                return View(nameof(Confirm));
            }
            return NotFound();
        }
    }
}
