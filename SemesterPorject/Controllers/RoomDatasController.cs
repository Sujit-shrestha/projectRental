using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SemesterPorject.Data;
using SemesterPorject.Models;

namespace SemesterPorject.Controllers
{
    public class RoomDatasController : Controller
    {
        private readonly AppDbContext _context;

        public RoomDatasController(AppDbContext context)
        {
            _context = context;
        }

        // GET: RoomDatas
        public async Task<IActionResult> Index()
        {
              return _context.RoomData != null ? 
                          View(await _context.RoomData.ToListAsync()) :
                          Problem("Entity set 'AppDbContext.RoomData'  is null.");
        }

        // GET: RoomDatas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.RoomData == null)
            {
                return NotFound();
            }

            var roomData = await _context.RoomData
                .FirstOrDefaultAsync(m => m.RoomId == id);
            if (roomData == null)
            {
                return NotFound();
            }

            return View(roomData);
        }

        // GET: RoomDatas/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: RoomDatas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("RoomId,Location,Length,breadth,height,color,waterFacility")] RoomData roomData)
        {
            if (ModelState.IsValid)
            {
                _context.Add(roomData);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(roomData);
        }

        // GET: RoomDatas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.RoomData == null)
            {
                return NotFound();
            }

            var roomData = await _context.RoomData.FindAsync(id);
            if (roomData == null)
            {
                return NotFound();
            }
            return View(roomData);
        }

        // POST: RoomDatas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("RoomId,Location,Length,breadth,height,color,waterFacility")] RoomData roomData)
        {
            if (id != roomData.RoomId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(roomData);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RoomDataExists(roomData.RoomId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(roomData);
        }

        // GET: RoomDatas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.RoomData == null)
            {
                return NotFound();
            }

            var roomData = await _context.RoomData
                .FirstOrDefaultAsync(m => m.RoomId == id);
            if (roomData == null)
            {
                return NotFound();
            }

            return View(roomData);
        }

        // POST: RoomDatas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.RoomData == null)
            {
                return Problem("Entity set 'AppDbContext.RoomData'  is null.");
            }
            var roomData = await _context.RoomData.FindAsync(id);
            if (roomData != null)
            {
                _context.RoomData.Remove(roomData);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RoomDataExists(int id)
        {
          return (_context.RoomData?.Any(e => e.RoomId == id)).GetValueOrDefault();
        }
    }
}
