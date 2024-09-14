#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using info.Models;
using info.Repository.IRepository;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
namespace info.Controllers
{
    public class infomedsController : Controller
    {
        private readonly IUnitofWork _unitofWork;

        public infomedsController(IUnitofWork unitofWork)
        {
            _unitofWork = unitofWork;
        }

        // GET: infomeds
        public IActionResult Index()
        {
            IEnumerable<infomed> objinfomedsList = _unitofWork.Infomed.GetAll();
            return View(objinfomedsList);
        }

        // GET: infomeds/Details/5
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var infomed = _unitofWork.Infomed
                .GetFirstOrDefault(m=>m.Id==id);
            if (infomed == null)
            {
                return NotFound();
            }

            return View(infomed);
        }

        // GET: infomeds/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: infomeds/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind("Id,Name,BrandName,illness,sales,stock,Expiry,medicinetype")] infomed infomed)
        {

            if (ModelState.IsValid)
            {
                _unitofWork.Infomed.Add(infomed);
                _unitofWork.Save();

                // TempData for alerts
                TempData["success"] = "Added Successfuly";

                return RedirectToAction(nameof(Index));
            }
            return View(infomed);
        }

        // GET: infomeds/Edit/5
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            //var infomed = _unitofWork.Infomed.GetFirstOrDefault(m => m.Name == "id");
            var infomed = _unitofWork.Infomed.GetFirstOrDefault(m => m.Id == id); // This is correct
            if (infomed == null)
            {
                return NotFound();
            }
            return View(infomed);
        }

        // POST: infomeds/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, [Bind("Id,Name,BrandName,illness,sales,stock,Expiry,medicinetype")] infomed infomed)
        {
            if (id != infomed.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {

                _unitofWork.Infomed.Update(infomed);
                _unitofWork.Save();



                // TempData for alerts
                TempData["success"] = "Updated Successfuly";
                return RedirectToAction(nameof(Index));
            }
            return View(infomed);
        }

        // GET: infomeds/Delete/5
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var infomed = _unitofWork.Infomed
                .GetFirstOrDefault(m=>m.Id==id);
            if (infomed == null)
            {
                return NotFound();
            }

            return View(infomed);
        }

        // POST: infomeds/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeletePost(int id)
        {
            var infomed = _unitofWork.Infomed.GetFirstOrDefault(m => m.Id == id);
            if (infomed == null)
            {
                return NotFound();
            }

            _unitofWork.Infomed.Remove(infomed);
            _unitofWork.Save();


            // TempData for alerts
            TempData["success"] = "Deleted Successfuly";

            return RedirectToAction(nameof(Index));
        }

    }
}
