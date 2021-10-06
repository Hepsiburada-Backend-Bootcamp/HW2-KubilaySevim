using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MovieDbInf.Application.Movie;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieDbInf.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieController : ControllerBase
    {
        private readonly IMovieService _movieService;
        public MovieController(IMovieService movieService)
        {
            _movieService = movieService;
        }

        [HttpPost]
        public async Task<IActionResult> Add([FromBody] MovieDto movieDto)
        {
            await _movieService.Add(movieDto);
            return Ok(new { status = true, errors = "" });
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var result = await _movieService.Get(_ => true);
            return Ok(new { status = true, data = result, errors = "" });
        }
    }
}
