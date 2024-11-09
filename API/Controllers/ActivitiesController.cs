using System.Reflection.Metadata.Ecma335;
using Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace API.Controllers
{
    public class ActivitiesController : BaseApiController
    {
        private readonly DataContext _context;

        public ActivitiesController(DataContext context)
        {
            _context = context;
        }

        [HttpGet] //api/activities
        public async Task<ActionResult<List<Activity>>> GetActivities() {
            return await _context.Activities.ToListAsync();
        }

        [HttpGet("{id}")] //api/activities/b65dfd7a-faa2-4319-a75f-7059b5cad326
        public async Task<ActionResult<Activity>> GetActivity(Guid id) {
            return await _context.Activities.FindAsync(id);
        }

    }
}