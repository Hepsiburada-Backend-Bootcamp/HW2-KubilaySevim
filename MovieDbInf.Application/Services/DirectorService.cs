using AutoMapper;
using MovieDbInf.Application.Dto.Director;
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
    class DirectorService : IDirectorService
    {
        private readonly IDirectorRepository _directorRepository;
        private readonly IMapper _mapper;

        public DirectorService(IDirectorRepository directorRepository, IMapper mapper)
        {
            _directorRepository = directorRepository;
            _mapper = mapper;
        }


        public Task Add(DirectorDto director)
        {
            return _directorRepository.Add(_mapper.Map<Domain.Entities.Director>(director));
        }

        public Task Delete(int id)
        {
            throw new NotImplementedException();
        }

        public async  Task<List<DirectorDto>> Get(Expression<Func<DirectorDto, bool>> filter)
        {
            var dtoFilter =  _mapper.Map<Expression<Func<Domain.Entities.Director, bool>>>(filter);
            var result = await _directorRepository.Get(dtoFilter);
            return  _mapper.Map<List<DirectorDto>>(result);
            //return await Task.FromResult(_mapper.Map<List<DirectorDto>>(result));

        }

        public Task<List<DirectorDto>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task Update(int id, UpdateDirectorDto director)
        {
            throw new NotImplementedException();
        }
    }
}
