using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MovieDbInf.Application.IServices;
using MovieDbInf.Application.Movie;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieDbInf.API.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class MovieController : ControllerBase
    {
        private readonly IMovieService _movieService;
        private readonly ILogger<MovieController> _logger;

        public MovieController(IMovieService movieService, ILogger<MovieController> logger)
        {
            _movieService = movieService;
            _logger = logger;
        }

        [HttpPost]
        public async Task<IActionResult> Add([FromBody] MovieDto movieDto)
        {
            if (!ModelState.IsValid)
            {
                _logger.LogError("In MovieController Add Method model not valid");
                return BadRequest();
            }

            _logger.LogInformation("In MovieController Add Method");

            await _movieService.Add(movieDto);
            return Ok(new { status = true, errors = "" });
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var result =  await _movieService.GetAll();
            return Ok(new { status = true, data = result, errors = "" });
        }
    }
}
