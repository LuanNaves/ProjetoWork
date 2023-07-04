using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProjetoFinalAtos.Data;

namespace ProjetoFinalAtos.Controllers {
    public class PartyController : Controller {
        private readonly ApplicationDbContext _context;

        public PartyController(ApplicationDbContext context) {
            _context = context;
        }

        // GET: Party
        public async Task<IActionResult> Index() {
            var serviceProviders = await _context.ServiceProviders
                .Join(_context.Services,
                    sp => sp.ServiceId,
                    s => s.Id,
                    (sp, s) => new { ServiceProvider = sp, Service = s })
                .Where(x => x.Service.Category.Id == 5)
                .Select(x => x.ServiceProvider)
                .ToListAsync();

            return View("PartySharedView", serviceProviders);
        }
        // GET: Party/Chef
        public async Task<IActionResult> Chef() {
            var serviceProviders = await _context.ServiceProviders
                .Join(_context.Services,
                    sp => sp.ServiceId,
                    s => s.Id,
                    (sp, s) => new { ServiceProvider = sp, Service = s })
                .Where(x => x.Service.Id == 25)
                .Select(x => x.ServiceProvider)
                .ToListAsync();

            return View("PartySharedView", serviceProviders);
        }
        // GET: Party/Confectioner
        public async Task<IActionResult> Confectioner() {
            var serviceProviders = await _context.ServiceProviders
                .Join(_context.Services,
                    sp => sp.ServiceId,
                    s => s.Id,
                    (sp, s) => new { ServiceProvider = sp, Service = s })
                .Where(x => x.Service.Id == 26)
                .Select(x => x.ServiceProvider)
                .ToListAsync();

            return View("PartySharedView", serviceProviders);
        }
        // GET: Party/Waiter
        public async Task<IActionResult> Waiter() {
            var serviceProviders = await _context.ServiceProviders
                .Join(_context.Services,
                    sp => sp.ServiceId,
                    s => s.Id,
                    (sp, s) => new { ServiceProvider = sp, Service = s })
                .Where(x => x.Service.Id == 27)
                .Select(x => x.ServiceProvider)
                .ToListAsync();

            return View("PartySharedView", serviceProviders);
        }
        // GET: Party/Barman
        public async Task<IActionResult> Barman() {
            var serviceProviders = await _context.ServiceProviders
                .Join(_context.Services,
                    sp => sp.ServiceId,
                    s => s.Id,
                    (sp, s) => new { ServiceProvider = sp, Service = s })
                .Where(x => x.Service.Id == 28)
                .Select(x => x.ServiceProvider)
                .ToListAsync();

            return View("PartySharedView", serviceProviders);
        }
        // GET: Party/Receptionist
        public async Task<IActionResult> Receptionist() {
            var serviceProviders = await _context.ServiceProviders
                .Join(_context.Services,
                    sp => sp.ServiceId,
                    s => s.Id,
                    (sp, s) => new { ServiceProvider = sp, Service = s })
                .Where(x => x.Service.Id == 29)
                .Select(x => x.ServiceProvider)
                .ToListAsync();

            return View("PartySharedView", serviceProviders);
        }
    }
}
