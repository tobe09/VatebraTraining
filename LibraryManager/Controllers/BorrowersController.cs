using System.Linq;
using System.Threading.Tasks;
using LibraryManager.DbContext;
using LibraryManager.DbContext.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace LibraryManager.Controllers
{
    public class BorrowersController : Controller
    {
        private readonly LibraryContext _context;

        public BorrowersController(LibraryContext context)
        {
            _context = context;
        }

        // GET: Borrowers
        public async Task<IActionResult> Index()
        {
            return View(await _context.Borrowers.ToListAsync());
        }

        // GET: Borrowers/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var borrower = await _context.Borrowers.FirstOrDefaultAsync(m => m.BorrowerId == id);
            if (borrower == null)
            {
                return NotFound();
            }

            return View(borrower);
        }

        // GET: Borrowers/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Borrowers/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("BorrowerId,FirstName,LastName,PhoneNumber")] Borrower borrower)
        {
            if (ModelState.IsValid)
            {
                _context.Add(borrower);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(borrower);
        }

        // GET: Borrowers/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var borrower = await _context.Borrowers.FindAsync(id);
            if (borrower == null)
            {
                return NotFound();
            }

            return View(borrower);
        }

        // POST: Borrowers/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("BorrowerId,FirstName,LastName,PhoneNumber")] Borrower borrower)
        {
            if (id != borrower.BorrowerId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(borrower);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BorrowerExists(borrower.BorrowerId))
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
            return View(borrower);
        }

        // GET: Borrowers/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var borrower = await _context.Borrowers.FirstOrDefaultAsync(m => m.BorrowerId == id);
            if (borrower == null)
            {
                return NotFound();
            }

            return View(borrower);
        }

        // POST: Borrowers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var borrower = await _context.Borrowers.FindAsync(id);
            _context.Borrowers.Remove(borrower);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BorrowerExists(int id)
        {
            return _context.Borrowers.Any(e => e.BorrowerId == id);
        }
    }
}
