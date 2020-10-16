using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ADETQ2_Eclair.Models;
using Microsoft.EntityFrameworkCore;

namespace ADETQ2_Eclair.Controllers
{
    public class GrpMemberController : Controller
    {
        private readonly AppDBContext _db;

        public GrpMemberController(AppDBContext db)
        {
            _db = db;
        }

        public IActionResult Index() 
        {
            var displaydata = _db.tblGrpMember.ToList();

            return View(displaydata);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(NewGrpMember addNGP) // ngp object
        { // add
            if (ModelState.IsValid)
            {
                _db.Add(addNGP);
                await _db.SaveChangesAsync();

                return RedirectToAction("Index");
            }
            return View(addNGP);
        }

        public async Task<IActionResult> Edit(int ? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index");
            }

            var getMemberDetails = await _db.tblGrpMember.FindAsync(id);

            return View(getMemberDetails);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(NewGrpMember editNGP)
        { // edit
            if (ModelState.IsValid)
            {
                _db.Update(editNGP);
                await _db.SaveChangesAsync();

                return RedirectToAction("Index");
            }
            return View(editNGP);
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index");
            }

            var getMemberDetails = await _db.tblGrpMember.FindAsync(id);

            return View(getMemberDetails);
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index");
            }

            var getMemberDetails = await _db.tblGrpMember.FindAsync(id);

            return View(getMemberDetails);
        }

        [HttpPost]
        public async Task<IActionResult> Delete(int id)
        {
            var getMemberDetails = await _db.tblGrpMember.FindAsync(id);
            _db.tblGrpMember.Remove(getMemberDetails);
            await _db.SaveChangesAsync();

            return RedirectToAction("Index");
        }
    }
}
