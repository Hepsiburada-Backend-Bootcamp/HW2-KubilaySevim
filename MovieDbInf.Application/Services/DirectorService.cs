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
    public class DirectorService : IDirectorService
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



        public async Task<List<DirectorDto>> GetAll()
        {
            //var dtoFilter =  _mapper.Map<Expression<Func<Domain.Entities.Director, bool>>>(filter);
            var result = await _directorRepository.GetAll();
            return  _mapper.Map<List<DirectorDto>>(result);;
        }

        public Task Update(Guid id, UpdateDirectorDto director)
        {
            throw new NotImplementedException();
        }
        
        public async Task<DirectorDto> Get(Guid id)
        {
            var dre = await _directorRepository.Get(id);

            return  _mapper.Map<DirectorDto>(dre);
        }

        public   Task Delete(Guid id)
        {
            var director =    _directorRepository.Get(id);

            return _directorRepository.Delete(_mapper.Map<Domain.Entities.Director>(director.Result));

        }

    }
}
