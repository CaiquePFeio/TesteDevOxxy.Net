using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using TesteDevOxxy.Net.Models;

namespace TesteDevOxxy.Net.Controllers
{
    public class veiculosController : Controller
    {
        private contexto db = new contexto();

        // GET: veiculos
        public ActionResult Index()
        {
            return View(db.Veiculos.ToList());
        }

        // GET: veiculos/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            veiculos veiculos = db.Veiculos.Find(id);
            if (veiculos == null)
            {
                return HttpNotFound();
            }
            return View(veiculos);
        }

        // GET: veiculos/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: veiculos/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Veiculo,Placa,Renavam,Nome,CPF,Bloqueado")] veiculos veiculos)
        {
            if (ModelState.IsValid)
            {
                db.Veiculos.Add(veiculos);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(veiculos);
        }

        // GET: veiculos/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            veiculos veiculos = db.Veiculos.Find(id);
            if (veiculos == null)
            {
                return HttpNotFound();
            }
            return View(veiculos);
        }

        // POST: veiculos/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Veiculo,Placa,Renavam,Nome,CPF,Bloqueado")] veiculos veiculos)
        {
            if (ModelState.IsValid)
            {
                db.Entry(veiculos).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(veiculos);
        }

        // GET: veiculos/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            veiculos veiculos = db.Veiculos.Find(id);
            if (veiculos == null)
            {
                return HttpNotFound();
            }
            return View(veiculos);
        }

        // POST: veiculos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            veiculos veiculos = db.Veiculos.Find(id);
            db.Veiculos.Remove(veiculos);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
