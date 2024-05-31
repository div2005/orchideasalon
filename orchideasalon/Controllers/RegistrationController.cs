using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using orchideasalon.Constants;
using orchideasalon.Data;
using orchideasalon.Models;

namespace orchideasalon.Controllers;

[Authorize(Roles = $"{AuthorizationConstants.Roles.Admin},{AuthorizationConstants.Roles.Manager}")]
public class RegistrationController(ApplicationDbContext _context) : Controller
{
    public async Task<IActionResult> Index(string sortOrder, string searchString)
    {
        ViewData["DateSortParam"] = string.IsNullOrEmpty(sortOrder) ? "date_desc" : "";
        ViewData["CurrentFilter"] = searchString;
        
        var regs = _context.Registrations
            .Include(e => e.Service)
            .Where(e => e.Date >= DateTime.Today)
            .AsQueryable();

        if (!searchString.IsNullOrEmpty())
        {
            regs = regs.Where(s => s.Phone.Contains(searchString) || s.FirstName.Contains(searchString));
        }
        
        regs = string.IsNullOrEmpty(sortOrder)
            ? regs.OrderBy(e => e.Date)
            : regs.OrderByDescending(e => e.Date);
        
        return View(await regs.AsNoTracking().ToListAsync());
    }
    
    public async Task<IActionResult> Archive(string sortOrder, string searchString)
    {
        ViewData["DateSortParam"] = string.IsNullOrEmpty(sortOrder) ? "date_desc" : "";
        ViewData["CurrentFilter"] = searchString;
        
        var regs = _context.Registrations
            .Include(e => e.Service)
            .Where(e => e.Date < DateTime.Today)
            .AsQueryable();

        regs = string.IsNullOrEmpty(sortOrder)
            ? regs.OrderByDescending(e => e.Date)
            : regs.OrderBy(e => e.Date);
        
        if (!searchString.IsNullOrEmpty())
        {
            regs = regs.Where(s => s.Phone.Contains(searchString) || s.FirstName.Contains(searchString));
        }
        
        return View(await regs.AsNoTracking().ToListAsync());
    }
    
    public async Task<IActionResult> InProcessing(string searchString)
    {
        ViewData["CurrentFilter"] = searchString;
        
        var regs = _context.Registrations
            .Include(e => e.Service)
            .Where(e => !e.Approved)
            .AsQueryable();
        
        if (!searchString.IsNullOrEmpty())
        {
            regs = regs.Where(s => s.Phone.Contains(searchString) || s.FirstName.Contains(searchString));
        }
        
        return View(await regs.AsNoTracking().ToListAsync());
    }
    
    public async Task<IActionResult> All(string sortOrder, string searchString)
    {
        ViewData["DateSortParam"] = string.IsNullOrEmpty(sortOrder) ? "date_desc" : "";
        ViewData["CurrentFilter"] = searchString;
        
        var regs = _context.Registrations
            .Include(e => e.Service)
            .AsQueryable();

        if (!searchString.IsNullOrEmpty())
        {
            regs = regs.Where(s => s.Phone.Contains(searchString) || s.FirstName.Contains(searchString));
        }
        
        regs = string.IsNullOrEmpty(sortOrder)
            ? regs.OrderBy(e => e.Date)
            : regs.OrderByDescending(e => e.Date);
        
        return View(await regs.AsNoTracking().ToListAsync());
    }
    
    // GET: RegistrationController2/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var registrationModel = await _context.Registrations
                .Include(r => r.Service)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (registrationModel == null)
            {
                return NotFound();
            }

            return View(registrationModel);
        }

        // GET: RegistrationController2/Create
        public IActionResult Create()
        {
            ViewData["ServiceId"] = new SelectList(_context.Services, "Id", "Name");
            return View();
        }

        // POST: RegistrationController2/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,ServiceId,FirstName,Phone,Date,Notes,Approved")] RegistrationModel registrationModel)
        {
            if (ModelState.IsValid)
            {
                registrationModel.Id = Guid.NewGuid();
                _context.Add(registrationModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ServiceId"] = new SelectList(_context.Services, "Id", "Name", registrationModel.ServiceId);
            return View(registrationModel);
        }
        
        // GET: RegistrationController/UserCreate
        [AllowAnonymous]
        public IActionResult UserCreate()
        {
            ViewData["ServiceId"] = new SelectList(_context.Services, "Id", "Name");
            return View();
        }

        // POST: RegistrationController/UserCreate
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [AllowAnonymous]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> UserCreate([Bind("Id,ServiceId,FirstName,Phone,Date")] RegistrationModel registrationModel)
        {
            if (ModelState.IsValid)
            {
                registrationModel.Id = Guid.NewGuid();
                _context.Add(registrationModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(HomeController.Index), "Home");
            }
            ViewData["ServiceId"] = new SelectList(_context.Services, "Id", "Name", registrationModel.ServiceId);
            return View(registrationModel);
        }

        // GET: RegistrationController2/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var registrationModel = await _context.Registrations.FindAsync(id);
            if (registrationModel == null)
            {
                return NotFound();
            }
            ViewData["ServiceId"] = new SelectList(_context.Services, "Id", "Name", registrationModel.ServiceId);
            return View(registrationModel);
        }

        // POST: RegistrationController2/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Id,ServiceId,FirstName,Phone,Date,Notes,Approved")] RegistrationModel registrationModel)
        {
            if (id != registrationModel.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(registrationModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RegistrationModelExists(registrationModel.Id))
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
            ViewData["ServiceId"] = new SelectList(_context.Services, "Id", "Name", registrationModel.ServiceId);
            return View(registrationModel);
        }

        // GET: RegistrationController2/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var registrationModel = await _context.Registrations
                .Include(r => r.Service)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (registrationModel == null)
            {
                return NotFound();
            }

            return View(registrationModel);
        }

        // POST: RegistrationController2/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var registrationModel = await _context.Registrations.FindAsync(id);
            if (registrationModel != null)
            {
                _context.Registrations.Remove(registrationModel);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RegistrationModelExists(Guid id)
        {
            return _context.Registrations.Any(e => e.Id == id);
        }
}