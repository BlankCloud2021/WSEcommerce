using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WSEcommerce.Data;
using WSEcommerce.Models;

namespace WSEcommerce.Controllers
{
    public class ProjectRequestsController : Controller
    {
        private readonly WSEcommerceDbContext _context;

        public ProjectRequestsController(WSEcommerceDbContext context)
        {
            _context = context;
        }

        // GET: ProjectRequests
        public async Task<IActionResult> Index()
        {
            return View(await _context.ProjectRequests.ToListAsync());
        }

        // GET: ProjectRequests/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var projectRequest = await _context.ProjectRequests
                .FirstOrDefaultAsync(m => m.ProjectRequestId == id);
            if (projectRequest == null)
            {
                return NotFound();
            }

            return View(projectRequest);
        }

        // GET: ProjectRequests/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ProjectRequests/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ProjectRequestId,Name,Email,Discription,ImageURl")] ProjectRequest projectRequest)
        {
            if (ModelState.IsValid)
            {
                _context.Add(projectRequest);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(projectRequest);
        }

        // GET: ProjectRequests/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var projectRequest = await _context.ProjectRequests.FindAsync(id);
            if (projectRequest == null)
            {
                return NotFound();
            }
            return View(projectRequest);
        }

        // POST: ProjectRequests/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ProjectRequestId,Name,Email,Discription,ImageURl")] ProjectRequest projectRequest)
        {
            if (id != projectRequest.ProjectRequestId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(projectRequest);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProjectRequestExists(projectRequest.ProjectRequestId))
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
            return View(projectRequest);
        }

        // GET: ProjectRequests/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var projectRequest = await _context.ProjectRequests
                .FirstOrDefaultAsync(m => m.ProjectRequestId == id);
            if (projectRequest == null)
            {
                return NotFound();
            }

            return View(projectRequest);
        }

        // POST: ProjectRequests/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var projectRequest = await _context.ProjectRequests.FindAsync(id);
            _context.ProjectRequests.Remove(projectRequest);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProjectRequestExists(int id)
        {
            return _context.ProjectRequests.Any(e => e.ProjectRequestId == id);
        }
    }
}
