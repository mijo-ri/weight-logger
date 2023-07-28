using Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace API.Controllers
{
    public class LogsController : BaseApiController
    {
        private readonly DataContext _context;

        public LogsController(DataContext context)
        {
            _context = context;
        }

        [HttpGet] // api/logs
        public async Task<ActionResult<List<Log>>> GetLogs()
        {
            return await _context.Logs.ToListAsync();
        }

        [HttpGet("{id}")] // api/logs/{id}
        public async Task<ActionResult<Log>> GetLog(Guid id)
        {
            return await _context.Logs.FindAsync(id);
        }
    }
}
