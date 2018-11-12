using Exam.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Exam.Web.Models;

namespace Exam.Web.Controllers
{
    public class EnseignantController : Controller
    {
        // GET: Enseignant
        public ActionResult Index()
        {
            EnseignantService ES = new EnseignantService();
            List<EnseignantViewModel> levm = new List<EnseignantViewModel>();
            foreach (var Es in ES.ListeNouveau())
            {
                EnseignantViewModel evm = new EnseignantViewModel()
                {
                    Id = Es.Id,
                    Mail = Es.Mail,
                    Nom = Es.Nom,
                    Prenom = Es.Prenom,
                    Telephone = Es.Telephone,
                    DateDePriseDeFonction =  Es.DateDePriseDeFonction,
                    Grade =  Es.Grade,
                    Salaire = Es.Salaire ,
                   
                };
                levm.Add(evm);
            }
            return View(levm);
        }

        // GET: Enseignant/Details/5
        //public ActionResult Details(int id)
        //{
        //    return View();
        //}

        //// GET: Enseignant/Create
        //public ActionResult Create()
        //{
        //    return View();
        //}

        //// POST: Enseignant/Create
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

        //// GET: Enseignant/Edit/5
        //public ActionResult Edit(int id)
        //{
        //    return View();
        //}

        //// POST: Enseignant/Edit/5
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

        //// GET: Enseignant/Delete/5
        //public ActionResult Delete(int id)
        //{
        //    return View();
        //}

        //// POST: Enseignant/Delete/5
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
