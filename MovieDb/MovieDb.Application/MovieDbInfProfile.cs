using AutoMapper;
using MovieDbInf.Application.Dto.Genre;
using MovieDbInf.Application.Movie.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieDbInf.Application.Movie
{
    public class MovieDbInfProfile : Profile
    {
        public MovieDbInfProfile()
        {
            CreateMap<MovieDto, Domain.Entities.Movie>().ReverseMap();
            CreateMap<Domain.Entities.Movie, UpdateMovieDto>();

            CreateMap<GenreDto, Domain.Entities.Genre>().ReverseMap();
            CreateMap<Domain.Entities.Genre, UpdateGenreDto>();

        }
    }
}
