using AutoMapper;
using MovieDbInf.Application.Dto.Genre;
using MovieDbInf.Application.IServices;
using MovieDbInf.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MovieDbInf.Application.Services
{
    public class GenreService : IGenreService
    {
        private readonly IGenreRepository _genreRepository;
        private readonly IMapper _mapper;

        public GenreService(IGenreRepository genreRepository, IMapper mapper)
        {
            _genreRepository = genreRepository;
            _mapper = mapper;
        }

        public Task Add(GenreDto genreDto)
        {
            return _genreRepository.Add(_mapper.Map<Domain.Entities.Genre>(genreDto));
        }


        public Task Delete(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<GenreDto>> Get(Expression<Func<GenreDto, bool>> filter)
        {
            var dtoFilter = _mapper.Map<Expression<Func<Domain.Entities.Genre, bool>>>(filter);
            var result = await _genreRepository.Get(dtoFilter);
            return _mapper.Map<List<GenreDto>>(result);
            //return await Task.FromResult(_mapper.Map<List<DirectorDto>>(result));
        }

        public async Task<List<GenreDto>> GetAll()
        {
            var result = await _genreRepository.GetAll();
            return _mapper.Map<List<GenreDto>>(result);
        }

        public Task Update(int id, UpdateGenreDto genre)
        {
            throw new NotImplementedException();
        }
    }
}
