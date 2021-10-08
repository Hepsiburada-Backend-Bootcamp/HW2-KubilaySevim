using AutoMapper;
using MovieDbInf.Application.IServices;
using MovieDbInf.Application.Movie;
using MovieDbInf.Application.Movie.Dto;
using MovieDbInf.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using MovieDbInf.Application.Dto.Movie;

namespace MovieDbInf.Application.Services
{
    public class MovieService : IMovieService
    {
        private readonly IMovieRepository _movieRepository;
        private readonly IMapper _mapper;

        public MovieService(IMovieRepository movieRepository, IMapper mapper)
        {
            _movieRepository = movieRepository;
            _mapper = mapper;
        }

        public Task Add(MovieDto movieDto)
        {
            return _movieRepository.Add(_mapper.Map<MovieDbInf.Domain.Entities.Movie>(movieDto));
        }

        public Task Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task Update(Guid id, UpdateMovieDto movie)
        {
            throw new NotImplementedException();
        }

        public async Task<MovieDto> Get(Guid id)
        {
            
            var result = await _movieRepository.Get(id);

            return _mapper.Map<MovieDto>(result);
        }

        public async Task<List<MovieDto>> GetAll()
        {
            var result = await _movieRepository.GetAll();
            return  _mapper.Map<List<MovieDto>>(result);
        }

        public Task Update(int id, UpdateMovieDto movie)
        {
            throw new NotImplementedException();
        }
    }
}
