using AutoMapper;
using GEVS_Backend.DbContexts;
using GEVS_Backend.Entities;
using GEVS_Backend.Models;
using Microsoft.AspNetCore.Mvc;

namespace GEVS_Backend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OfficerController : ControllerBase
    {

        private readonly OfficerContext _context;
        private readonly IMapper _mapper;

        public OfficerController(OfficerContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpGet("{id}")] // GETs a specific studio
        public async Task<ActionResult<OfficerModel>> GetOfficer(long id)
        {

            if (_context.Officers == null)
            { // if collection is not available.
                return NotFound();
            }

            OfficerEntity? studioEntity = await _context.Officers.FindAsync(id);

            if (studioEntity == null)
            { // if specific studio is not available.
                return NotFound();
            }

            return Ok(_mapper.Map<OfficerModel>(studioEntity));
        }

    }
}

