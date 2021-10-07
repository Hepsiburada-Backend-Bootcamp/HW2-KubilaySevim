﻿using AutoMapper;
using MovieDbInf.Application.IServices;
using MovieDbInf.Application.Movie;
using MovieDbInf.Application.Movie.Dto;
using MovieDbInf.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

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

        public Task Delete(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<MovieDto>> Get(Expression<Func<MovieDto, bool>> filter)
        {
            var dtoFilter = _mapper.Map<Expression<Func<Domain.Entities.Movie, bool>>>(filter);
            var result = await _movieRepository.Get(dtoFilter);

            return _mapper.Map<List<MovieDto>>(result);


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
