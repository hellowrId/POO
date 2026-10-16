using AlumnosWeb.Data;
using AlumnosWeb.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AlumnosWeb.Controllers
{
    public class MateriasController : Controller
    {
        private readonly AlumnosContext _context;
        public MateriasController(AlumnosContext context) { _context = context; }

        public async Task<IActionResult> Index()
        {
            return View(await _context.Materias.ToListAsync());
        }

        public async Task<IActionResult> Edit(int id)
        {
            var materia = await _context.Materias.FindAsync(id);
            if (materia == null) return NotFound();
            return View(materia);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(Materia materia)
        {
            _context.Update(materia);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}
