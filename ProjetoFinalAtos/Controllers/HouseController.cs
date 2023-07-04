using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ProjetoFinalAtos.Data;
using ProjetoFinalAtos.Models;

namespace ProjetoFinalAtos.Controllers
{
    public class HouseController : Controller
    {
        private readonly ApplicationDbContext _context;

        public HouseController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: House
        public async Task<IActionResult> Index()
        {
              return _context.ServiceProviders != null ? 
                          View(await _context.ServiceProviders.ToListAsync()) :
                          Problem("Entity set 'ApplicationDbContext.ServiceProviders'  is null.");
        }

        // GET: House/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.ServiceProviders == null)
            {
                return NotFound();
            }

            var serviceProviders = await _context.ServiceProviders
                .FirstOrDefaultAsync(m => m.Id == id);
            if (serviceProviders == null)
            {
                return NotFound();
            }

            return View(serviceProviders);
        }

        private bool ServiceProvidersExists(int id)
        {
          return (_context.ServiceProviders?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
