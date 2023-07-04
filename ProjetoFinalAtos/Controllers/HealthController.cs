using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProjetoFinalAtos.Data;

namespace ProjetoFinalAtos.Controllers {
    public class HealthController : Controller {
        private readonly ApplicationDbContext _context;

        public HealthController(ApplicationDbContext context) {
            _context = context;
        }

        // GET: Health
        public async Task<IActionResult> Index() {
            var serviceProviders = await _context.ServiceProviders
                .Join(_context.Services,
                    sp => sp.ServiceId,
                    s => s.Id,
                    (sp, s) => new { ServiceProvider = sp, Service = s })
                .Where(x => x.Service.Category.Id == 3)
                .Select(x => x.ServiceProvider)
                .ToListAsync();

            return View("HealthSharedView", serviceProviders);
        }
        // GET: Health/Doctor
        public async Task<IActionResult> Doctor() {
            var serviceProviders = await _context.ServiceProviders
                .Join(_context.Services,
                    sp => sp.ServiceId,
                    s => s.Id,
                    (sp, s) => new { ServiceProvider = sp, Service = s })
                .Where(x => x.Service.Id == 15)
                .Select(x => x.ServiceProvider)
                .ToListAsync();

            return View("HealthSharedView", serviceProviders);
        }
        // GET: Health/Nurse
        public async Task<IActionResult> Nurse() {
            var serviceProviders = await _context.ServiceProviders
                .Join(_context.Services,
                    sp => sp.ServiceId,
                    s => s.Id,
                    (sp, s) => new { ServiceProvider = sp, Service = s })
                .Where(x => x.Service.Id == 16)
                .Select(x => x.ServiceProvider)
                .ToListAsync();

            return View("HealthSharedView", serviceProviders);
        }
        // GET: Health/ElderlyCaregiver
        public async Task<IActionResult> ElderlyCaregiver() {
            var serviceProviders = await _context.ServiceProviders
                .Join(_context.Services,
                    sp => sp.ServiceId,
                    s => s.Id,
                    (sp, s) => new { ServiceProvider = sp, Service = s })
                .Where(x => x.Service.Id == 17)
                .Select(x => x.ServiceProvider)
                .ToListAsync();

            return View("HealthSharedView", serviceProviders);
        }
        // GET: Health/PersonalTrainer
        public async Task<IActionResult> PersonalTrainer() {
            var serviceProviders = await _context.ServiceProviders
                .Join(_context.Services,
                    sp => sp.ServiceId,
                    s => s.Id,
                    (sp, s) => new { ServiceProvider = sp, Service = s })
                .Where(x => x.Service.Id == 18)
                .Select(x => x.ServiceProvider)
                .ToListAsync();

            return View("HealthSharedView", serviceProviders);
        }
        // GET: Health/BabeSitter
        public async Task<IActionResult> BabeSitter() {
            var serviceProviders = await _context.ServiceProviders
                .Join(_context.Services,
                    sp => sp.ServiceId,
                    s => s.Id,
                    (sp, s) => new { ServiceProvider = sp, Service = s })
                .Where(x => x.Service.Id == 19)
                .Select(x => x.ServiceProvider)
                .ToListAsync();

            return View("HealthSharedView", serviceProviders);
        }
    }
}
