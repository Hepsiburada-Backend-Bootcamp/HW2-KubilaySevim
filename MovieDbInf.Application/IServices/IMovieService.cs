using MovieDbInf.Application.Movie;
using MovieDbInf.Application.Movie.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using MovieDbInf.Application.Dto.Movie;

namespace MovieDbInf.Application.IServices
{
    public interface IMovieService
    {
        Task Add(MovieDto movie);

        Task Delete(Guid id);

        Task Update(Guid id, UpdateMovieDto movie);

        Task<List<MovieDto>> GetAll();

        Task<MovieDto> Get(Guid id);
    }
}
