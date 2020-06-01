using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AvisFormationsCore.WebUi.Models;
using Data;
using Microsoft.AspNetCore.Mvc;

namespace AvisFormationsCore.WebUi.Controllers
{
    public class AvisController : Controller
    {
        public IActionResult LaisserUnAvis(string idFormation)
        {
            int iIdFormation = -1;

            if (!Int32.TryParse(idFormation, out iIdFormation))
            {
                return RedirectToAction("ToutesLesFormations", "Formation");
            }

            FormationMemoryRepository repository = new FormationMemoryRepository();

            var formation =  repository.GetFormationById(iIdFormation);
            Console.WriteLine(formation);

            if (formation == null)
            {
                return RedirectToAction("ToutesLesFormations");
            }


            var vm = new LaisserUnAvisViewModel();
 
            vm.NomFormation = formation.Nom;
            vm.IdFormation = formation.Id.ToString();

            return View(vm);
        }

        public IActionResult SaveComment(LaisserUnAvisViewModel viewModel)
        {
            if (!ModelState.IsValid)
            {
                //return RedirectToAction("LaisserUnAvis", new { idFormation = viewModel.idFormation });

                return View("LaisserUnAvis", viewModel);

            }

            if (String.IsNullOrEmpty(viewModel.Nom) || String.IsNullOrEmpty(viewModel.Note))
            {
                return RedirectToAction("LaisserUnAvis", new { idFormation = viewModel.IdFormation});
            }

            AvisRepository repository = new AvisRepository();
            repository.SaveAvis(viewModel.Commentaire, viewModel.Nom, viewModel.IdFormation);

            return RedirectToAction("DetailsFormation", "Formation", new { idFormation= viewModel.IdFormation });
        }
    }
}