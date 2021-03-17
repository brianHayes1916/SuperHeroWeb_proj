using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SuperWeb.Data;
using SuperWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SuperWeb.Controllers
{
    public class HeroFunctionality : Controller
    {
        public ApplicationDbContext _context;
        public HeroFunctionality(ApplicationDbContext context)
        {
            _context = context;
        }
        // GET: HeroFunctionality
        public ActionResult Index()
        {
            var superheros = _context.Heros;
            return View(superheros);
        }

        // GET: HeroFunctionality/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: HeroFunctionality/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: HeroFunctionality/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Superhero superHero)
        {
            try
            {
                _context.Heros.Add(superHero);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: HeroFunctionality/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: HeroFunctionality/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Superhero hero)
        {
            try
            {
                //_context.Heros.Where(h => h.Id == id).
                //_context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: HeroFunctionality/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: HeroFunctionality/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Superhero hero)
        {
            try
            {
                _context.Heros.Remove(hero);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
