using AlumnosWeb.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AlumnosWeb.Controllers
{
    public class AlumnosController : Controller
    {
        private readonly AlumnosContext _context;
        public AlumnosController(AlumnosContext context) { _context = context; }

        public async Task<IActionResult> Index()
        {
            return View(await _context.Alumnos.ToListAsync());
        }
    }
}
