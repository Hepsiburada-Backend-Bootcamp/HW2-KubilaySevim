using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MovieDbInf.Application.Dto.Genre;
using MovieDbInf.Application.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieDbInf.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GenreController : ControllerBase
    {

        private readonly IGenreService _genreService;
        public GenreController(IGenreService genreService)
        {
            _genreService = genreService;
        }

        [HttpPost]
        public async Task<IActionResult> Add([FromBody] GenreDto genreDto)
        {
            await _genreService.Add(genreDto);
            return Ok(new { status = true, errors = "" });
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var result = await _genreService.Get(_ => true);
            return Ok(new { status = true, data = result, errors = "" });
        }


    }
}
