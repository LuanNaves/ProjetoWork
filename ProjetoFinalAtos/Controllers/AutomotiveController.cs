using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProjetoFinalAtos.Data;

namespace ProjetoFinalAtos.Controllers {
    public class AutomotiveController : Controller {
        private readonly ApplicationDbContext _context;

        public AutomotiveController(ApplicationDbContext context) {
            _context = context;
        }

        // GET: Automotive
        public async Task<IActionResult> Index() {
            var serviceProviders = await _context.ServiceProviders
                .Join(_context.Services,
                    sp => sp.ServiceId,
                    s => s.Id,
                    (sp, s) => new { ServiceProvider = sp, Service = s })
                .Where(x => x.Service.Category.Id == 2)
                .Select(x => x.ServiceProvider)
                .ToListAsync();

            return View("AutomotiveSharedView", serviceProviders);
        }
        // GET: Automotive/Mechanic
        public async Task<IActionResult> Mechanic() {
            var serviceProviders = await _context.ServiceProviders
                .Join(_context.Services,
                    sp => sp.ServiceId,
                    s => s.Id,
                    (sp, s) => new { ServiceProvider = sp, Service = s })
                .Where(x => x.Service.Id == 8)
                .Select(x => x.ServiceProvider)
                .ToListAsync();

            return View("AutomotiveSharedView", serviceProviders);
        }
        // GET: Automotive/AutomotiveElectrician
        public async Task<IActionResult> AutomotiveElectrician() {
            var serviceProviders = await _context.ServiceProviders
                .Join(_context.Services,
                    sp => sp.ServiceId,
                    s => s.Id,
                    (sp, s) => new { ServiceProvider = sp, Service = s })
                .Where(x => x.Service.Id == 9)
                .Select(x => x.ServiceProvider)
                .ToListAsync();

            return View("AutomotiveSharedView", serviceProviders);
        }
        // GET: Automotive/TireRepairer
        public async Task<IActionResult> TireRepairer() {
            var serviceProviders = await _context.ServiceProviders
                .Join(_context.Services,
                    sp => sp.ServiceId,
                    s => s.Id,
                    (sp, s) => new { ServiceProvider = sp, Service = s })
                .Where(x => x.Service.Id == 10)
                .Select(x => x.ServiceProvider)
                .ToListAsync();

            return View("AutomotiveSharedView", serviceProviders);
        }
        // GET: Automotive/AutomotivePainter
        public async Task<IActionResult> AutomotivePainter() {
            var serviceProviders = await _context.ServiceProviders
                .Join(_context.Services,
                    sp => sp.ServiceId,
                    s => s.Id,
                    (sp, s) => new { ServiceProvider = sp, Service = s })
                .Where(x => x.Service.Id == 11)
                .Select(x => x.ServiceProvider)
                .ToListAsync();

            return View("AutomotiveSharedView", serviceProviders);
        }
        // GET: Automotive/AutomotiveAesthetics
        public async Task<IActionResult> AutomotiveAesthetics() {
            var serviceProviders = await _context.ServiceProviders
                .Join(_context.Services,
                    sp => sp.ServiceId,
                    s => s.Id,
                    (sp, s) => new { ServiceProvider = sp, Service = s })
                .Where(x => x.Service.Id == 12)
                .Select(x => x.ServiceProvider)
                .ToListAsync();

            return View("AutomotiveSharedView", serviceProviders);
        }
        // GET: Automotive/Exhauts
        public async Task<IActionResult> Exhauts() {
            var serviceProviders = await _context.ServiceProviders
                .Join(_context.Services,
                    sp => sp.ServiceId,
                    s => s.Id,
                    (sp, s) => new { ServiceProvider = sp, Service = s })
                .Where(x => x.Service.Id == 13)
                .Select(x => x.ServiceProvider)
                .ToListAsync();

            return View("AutomotiveSharedView", serviceProviders);
        }
        // GET: Automotive/AutomotivePerformanceTuner
        public async Task<IActionResult> AutomotivePerformanceTuner() {
            var serviceProviders = await _context.ServiceProviders
                .Join(_context.Services,
                    sp => sp.ServiceId,
                    s => s.Id,
                    (sp, s) => new { ServiceProvider = sp, Service = s })
                .Where(x => x.Service.Id == 14)
                .Select(x => x.ServiceProvider)
                .ToListAsync();

            return View("AutomotiveSharedView", serviceProviders);
        }
    }
}
