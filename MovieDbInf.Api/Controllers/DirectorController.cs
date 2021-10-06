using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MovieDbInf.Application.Dto.Director;
using MovieDbInf.Application.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieDbInf.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DirectorController : ControllerBase
    {
        private readonly IDirectorService _directorService;
        public DirectorController(IDirectorService directorService)
        {
            _directorService = directorService;
        }

        [HttpPost]
        public async Task<IActionResult> Add([FromBody] DirectorDto directorDto)
        {
            await _directorService.Add(directorDto);
            return Ok(new { status = true, errors = "" });
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var result = await _directorService.Get(_ => true);
            return Ok(new { status = true, data = result, errors = "" });
        }

    }
}
