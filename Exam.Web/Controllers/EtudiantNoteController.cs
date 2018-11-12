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
    public class EtudiantNoteController : Controller
    {
        // GET: EtudiantNote
        public ActionResult Index()
        {
            NoteService NS = new NoteService();
            List<EtudiantMatiereNoteViewModel> model = new List<EtudiantMatiereNoteViewModel>();
            foreach (var note in NS.GetAll())
            {
                EtudiantMatiereNoteViewModel emvm = new EtudiantMatiereNoteViewModel()
                {
                    Id = note.Id,
                    Nom = note.Personne.Nom,
                    Libelle = note.Matiere.Libelle,
                    NoteMatiere = note.NoteMatiere
                };
                model.Add(emvm);
            }
            return View(model);
        }

        //// GET: EtudiantNote/Details/5
        //public ActionResult Details(int id)
        //{
        //    return View();
        //}

        //// GET: EtudiantNote/Create
        //public ActionResult Create()
        //{
        //    return View();
        //}

        //// POST: EtudiantNote/Create
        //[HttpPost]
        //public ActionResult Create(FormCollection collection)
        //{
        //    try
        //    {
        //        // TODO: Add insert logic here

        //        return RedirectToAction("Index");
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        //// GET: EtudiantNote/Edit/5
        //public ActionResult Edit(int id)
        //{
        //    return View();
        //}

        //// POST: EtudiantNote/Edit/5
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

        //// GET: EtudiantNote/Delete/5
        //public ActionResult Delete(int id)
        //{
        //    return View();
        //}

        //// POST: EtudiantNote/Delete/5
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
