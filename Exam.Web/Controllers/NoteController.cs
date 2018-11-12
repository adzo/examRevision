using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Exam.Domain.Entities;
using Exam.Service;
using Exam.Web.Models;

namespace Exam.Web.Controllers
{
    public class NoteController : Controller
    {
        // GET: Note
        public ActionResult Index()
        {
            return View();
        }

        //// GET: Note/Details/5
        //public ActionResult Details(int id)
        //{
        //    return View();
        //}

        // GET: Note/Create
        public ActionResult Create()
        {
            EtudiantService LS = new EtudiantService();
            List<EtudiantViewModel> llvm = new List<EtudiantViewModel>();

            MatiereService BS = new MatiereService();
            List<MatiereViewModel> lbvm = new List<MatiereViewModel>();
            foreach (var item in LS.GetAll())
            {
                EtudiantViewModel loc = new EtudiantViewModel()
                {
                    Id = item.Id,
                    Nom = $"{item.Nom}"

                };
                llvm.Add(loc);
            }

            foreach (var item in BS.GetAll())
            {
                MatiereViewModel b = new MatiereViewModel()
                {
                    Code = item.Code,
                    Libelle = item.Libelle
                };
                lbvm.Add(b);
            }
            ViewData["Etudiants"] = new SelectList(llvm, "Id", "Nom");
            ViewData["Matieres"] = new SelectList(lbvm, "code", "Libelle");
            return View();
        }

        // POST: Note/Create
        [HttpPost]
        public ActionResult Create(NoteViewModel nvm)
        {
            try
            {
                // TODO: Add insert logic here
                Note note = new Note()
                {
                    Code = nvm.Code,
                    Id = nvm.Id,
                    NoteMatiere = nvm.NoteMatiere,
                    Observation = nvm.Observation
                    
                };
                NoteService NS = new NoteService();
                NS.Add(note);
                NS.Commit();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //// GET: Note/Edit/5
        //public ActionResult Edit(int id)
        //{
        //    return View();
        //}

        //// POST: Note/Edit/5
        //[HttpPost]
        //public ActionResult Edit(int id, FormCollection collection)
        //{
        //    try
        //    {
        //        // TODO: Add update logic here

        //        return RedirectToAction("Index");
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        //// GET: Note/Delete/5
        //public ActionResult Delete(int id)
        //{
        //    return View();
        //}

        //// POST: Note/Delete/5
        //[HttpPost]
        //public ActionResult Delete(int id, FormCollection collection)
        //{
        //    try
        //    {
        //        // TODO: Add delete logic here

        //        return RedirectToAction("Index");
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}
    }
}
