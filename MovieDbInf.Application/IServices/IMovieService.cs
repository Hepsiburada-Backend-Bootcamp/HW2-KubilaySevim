using MovieDbInf.Application.Movie;
using MovieDbInf.Application.Movie.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MovieDbInf.Application.IServices
{
    public interface IMovieService
    {
        Task Add(MovieDto movie);

        Task Delete(int id);

        Task Update(int id, UpdateMovieDto movie);

        Task<List<MovieDto>> GetAll();

        Task<List<MovieDto>> Get(Expression<Func<MovieDto, bool>> filter);
    }
}
