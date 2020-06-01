using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AvisFormationsCore.WebUi.Models;
using Microsoft.AspNetCore.Mvc;
using Data;

namespace AvisFormationsCore.WebUi.Controllers
{
    public class FormationController : Controller
    {
        public IActionResult Index()
        {

            //int a = 3;

            var vm = new ToutesLesFormationsViewModel();
            vm.Message = "Ceci est un message du controller";
            vm.Nombre = 93;

            return View(vm);
        }

        public IActionResult ToutesLesFormations()
        {
            FormationMemoryRepository repository = new FormationMemoryRepository();

            var listFormations = repository.GetAllFormations();

            return View(listFormations);
        }

        public IActionResult DetailsFormation(string idFormation)
        {
            int iIdFormation = -1;

            if(!Int32.TryParse(idFormation, out iIdFormation))
            {
                return RedirectToAction("ToutesLesFormations");
            }

            FormationMemoryRepository repository = new FormationMemoryRepository();

            var formation = repository.GetFormationById(iIdFormation);

            if(formation == null)
            {
                return RedirectToAction("ToutesLesFormations");
            }

            return View(formation);
        }

    }
}