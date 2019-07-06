using System.Linq;
using System.Threading.Tasks;
using LibraryManager.DbContext;
using LibraryManager.DbContext.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace LibraryManager.Controllers
{
    public class CataloguesController : Controller
    {
        private readonly LibraryContext _context;

        public CataloguesController(LibraryContext context)
        {
            _context = context;
        }

        // GET: Catalogues
        public async Task<IActionResult> Index()
        {
            return View(await _context.Catalogues.ToListAsync());
        }

        // GET: Catalogues/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var catalogue = await _context.Catalogues.FirstOrDefaultAsync(m => m.CatalogueId == id);
            if (catalogue == null)
            {
                return NotFound();
            }

            return View(catalogue);
        }

        // GET: Catalogues/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Catalogues/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CatalogueId,BookName,NumberOfBooks")] Catalogue catalogue)
        {
            if (ModelState.IsValid)
            {
                _context.Add(catalogue);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(catalogue);
        }

        // GET: Catalogues/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var catalogue = await _context.Catalogues.FindAsync(id);
            if (catalogue == null)
            {
                return NotFound();
            }
            return View(catalogue);
        }

        // POST: Catalogues/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("CatalogueId,BookName,NumberOfBooks")] Catalogue catalogue)
        {
            if (id != catalogue.CatalogueId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(catalogue);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CatalogueExists(catalogue.CatalogueId))
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
            return View(catalogue);
        }

        // GET: Catalogues/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var catalogue = await _context.Catalogues
                .FirstOrDefaultAsync(m => m.CatalogueId == id);
            if (catalogue == null)
            {
                return NotFound();
            }

            return View(catalogue);
        }

        // POST: Catalogues/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var catalogue = await _context.Catalogues.FindAsync(id);
            _context.Catalogues.Remove(catalogue);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CatalogueExists(int id)
        {
            return _context.Catalogues.Any(e => e.CatalogueId == id);
        }
    }
}
