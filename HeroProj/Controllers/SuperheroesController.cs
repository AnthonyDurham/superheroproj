using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HeroProj.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HeroProj.Controllers
{
    public class SuperheroesController : Controller
    {
        private ApplicationDbContext _context;

        public SuperheroesController(ApplicationDbContext context)
        {
            _context = context;
        }
        // GET: Superheroes
        public ActionResult Index()
        {
            var superheros = _context.Superheros;
            return View(superheros);
        }

        // GET: Superheroes/Details/5
        public ActionResult Details(int id)
        {
            var superheros = _contex.SuperherosFirstOrDefault(s => s.Id == id);
            return View(id);
        }

        // GET: Superheroes/Create
        public ActionResult Create()
        {
            var superheros = _context.Superheros.ToList();
            return View(superheros);
        }

        // POST: Superheroes/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                
                

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Superheroes/Edit/5
        public ActionResult Edit(int id)
        {
            var superheroINDB = _context.Superheros.Where(s => s.Id == id).FirstOrDefault();

            return View();
        }

        // POST: Superheroes/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name,AlterEgo,PrimaryAbility,Secondary,Ability,CatchPhrase")]);
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Superheroes/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Superheroes/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}