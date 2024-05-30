using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using orchideasalon.Data;

namespace orchideasalon.Controllers;

public class RegistrationController(AuthDbContext context) : Controller
{
    
    public async Task<IActionResult> Index(string sortOrder, bool showAll = false) // fix checkbox && make this 2 works together
    {
        ViewData["DateSortParam"] = string.IsNullOrEmpty(sortOrder) ? "date_desc" : "";
        ViewData["ShowAllParam"] = showAll ? "show_all" : "";

        var regs =  context.Registrations
            .Include(e => e.Service)
            .Include(e => e.Day).AsQueryable();

        regs = !showAll
            ? regs.Where(e => e.Day.Date >= DateOnly.FromDateTime(DateTime.Now))
            : regs;
        
        regs = string.IsNullOrEmpty(sortOrder)
            ? regs.OrderBy(e => e.Day.Date).ThenBy(e => e.Day)
            : regs.OrderByDescending(e => e.Day.Date).ThenBy(e => e.Day);
        
        return View(await regs.AsNoTracking().ToListAsync());
    }
}