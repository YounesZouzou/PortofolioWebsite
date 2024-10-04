using Microsoft.AspNetCore.Mvc;
using PortofolioWebsite.Data;
using PortofolioWebsite.Models;
using System.Threading.Tasks;

namespace PortofolioWebsite.Controllers
{
    public class ServerController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ServerController(ApplicationDbContext context)
        {
            _context = context;
        }

        // Test method to fetch a server by Id
        public async Task<IActionResult> GetServer(long id)
        {
            var server = await _context.Servers.FindAsync(id);

            if (server == null)
            {
                return NotFound();
            }
            return Json(server);
        }
    }
}
