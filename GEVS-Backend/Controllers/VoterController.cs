﻿using AutoMapper;
using GEVS_Backend.Models;
using GEVS_Backend.Entities;
using GEVS_Backend.DbContexts;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace GEVS_Backend.Controllers
{
	[ApiController]
	[Route("api/[controller]")]
	public class VoterController : ControllerBase
	{

        private readonly ElectionContext _context;
        private readonly IMapper _mapper;

        public VoterController(ElectionContext context, IMapper mapper)
		{
			_context = context;
			_mapper = mapper;
		}

		[HttpGet] // GETs collection of studios
		public async Task<ActionResult<IEnumerable<VoterModel>>> GetVoters()
		{
			if (_context.Voters == null)
			{
				return NotFound();
			}
      
      List<VoterEntity> voters = await _context.Voters.ToListAsync();
      
      return Ok(_mapper.Map<List<VoterModel>>(voters));
    }
	}
}