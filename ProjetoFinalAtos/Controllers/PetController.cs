using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProjetoFinalAtos.Data;

namespace ProjetoFinalAtos.Controllers {
    public class PetController : Controller {
        private readonly ApplicationDbContext _context;

        public PetController(ApplicationDbContext context) {
            _context = context;
        }

        // GET: Pet
        public async Task<IActionResult> Index() {
            var serviceProviders = await _context.ServiceProviders
                .Join(_context.Services,
                    sp => sp.ServiceId,
                    s => s.Id,
                    (sp, s) => new { ServiceProvider = sp, Service = s })
                .Where(x => x.Service.Category.Id == 6)
                .Select(x => x.ServiceProvider)
                .ToListAsync();

            return View("PetSharedView", serviceProviders);
        }
        // GET: Pet/Veterinarian
        public async Task<IActionResult> Veterinarian() {
            var serviceProviders = await _context.ServiceProviders
                .Join(_context.Services,
                    sp => sp.ServiceId,
                    s => s.Id,
                    (sp, s) => new { ServiceProvider = sp, Service = s })
                .Where(x => x.Service.Id == 30)
                .Select(x => x.ServiceProvider)
                .ToListAsync();

            return View("PetSharedView", serviceProviders);
        }
        // GET: Pet/PetGroomer
        public async Task<IActionResult> PetGroomer() {
            var serviceProviders = await _context.ServiceProviders
                .Join(_context.Services,
                    sp => sp.ServiceId,
                    s => s.Id,
                    (sp, s) => new { ServiceProvider = sp, Service = s })
                .Where(x => x.Service.Id == 31)
                .Select(x => x.ServiceProvider)
                .ToListAsync();

            return View("PetSharedView", serviceProviders);
        }
        // GET: Pet/PetSitter
        public async Task<IActionResult> PetSitter() {
            var serviceProviders = await _context.ServiceProviders
                .Join(_context.Services,
                    sp => sp.ServiceId,
                    s => s.Id,
                    (sp, s) => new { ServiceProvider = sp, Service = s })
                .Where(x => x.Service.Id == 32)
                .Select(x => x.ServiceProvider)
                .ToListAsync();

            return View("PetSharedView", serviceProviders);
        }
        // GET: Pet/PetWalker
        public async Task<IActionResult> PetWalker() {
            var serviceProviders = await _context.ServiceProviders
                .Join(_context.Services,
                    sp => sp.ServiceId,
                    s => s.Id,
                    (sp, s) => new { ServiceProvider = sp, Service = s })
                .Where(x => x.Service.Id == 33)
                .Select(x => x.ServiceProvider)
                .ToListAsync();

            return View("PetSharedView", serviceProviders);
        }
    }
}
