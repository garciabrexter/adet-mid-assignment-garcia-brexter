using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using adet_mid_assignment_garcia_brexter.Models;


namespace adet_mid_assignment_garcia_brexter.Controllers
{
    public class TaskController : Controller
    {
        private readonly ApplicationDbContext _db;

        public TaskController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            var displaydata = _db.TB_Task.ToList();
            return View(displaydata);
        }
        public  IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create (TaskClass nec)
        {
            if (ModelState.IsValid)
            {
                _db.Add(nec);
                await _db.SaveChangesAsync();
                return RedirectToAction("Index");

            }
            return View(nec);
        }

        public async Task<IActionResult> Edit (string? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index");
            }
            var gettaskName = await _db.TB_Task.FindAsync(id);
          

            return View(gettaskName);
        }
        [HttpPost]
        public async Task<IActionResult> Edit (TaskClass nc)
        {
            if (ModelState.IsValid)
            {
                _db.Update(nc);
                await _db.SaveChangesAsync();
                return RedirectToAction("Index");

            }
            return View(nc);
        }
        public async Task<IActionResult> Details(string? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index");
            }
            var gettaskName = await _db.TB_Task.FindAsync(id);


            return View(gettaskName);
        }
   
        public async Task<IActionResult> Delete(string? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index");
            }
            var gettaskName = await _db.TB_Task.FindAsync(id);


            return View(gettaskName);
        }

        [HttpPost]
        public async Task<IActionResult> DELETE(string id)
        {
          
            var gettaskName = await _db.TB_Task.FindAsync(id);
            _db.TB_Task.Remove(gettaskName);
            await _db.SaveChangesAsync();


            return RedirectToAction("Index");
        }
    }
}
