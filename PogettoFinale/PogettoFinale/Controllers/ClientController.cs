using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PogettoFinale.Data;
using PogettoFinale.Models;

namespace PogettoFinale.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientController : ControllerBase
    {
        private readonly BookingDbContext _context;

        public ClientController(BookingDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Client>>> GetClients()
        {
            return await _context.Clients.ToListAsync();
        }

        [HttpPost]
        public async Task<ActionResult<Client>> CreateClient(Client client)
        {
            _context.Clients.Add(client);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetClients), new { id = client.ClientId }, client);
        }
    }
}

