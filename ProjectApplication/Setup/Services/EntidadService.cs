using FluentValidation;
using ProjectApplication.Setup.Dto;
using ProjectApplication.Setup.Interfaces;
using ProjectDomain.Setup.Entities;
using ProjectDomain.Setup.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectApplication.Setup.Services
{
    public class EntidadService : IEntidadService
    {
        public readonly IEntidadRepository _entidadRepository;
        public readonly IValidator<EntidadDto> _validator;
        //FALTA MAPPER Y VALIDATORS.

        //public EntidadService(IEntidadRepository entidadRepository, IMapper mapper, IValidator<EntidadDto> validator)
        //{
        //    _entidadRepository = entidadRepository;
        //    _mapper = mapper;
        //    _validator = validator;
        //}ASI DEBE DE QUEDAR

        public EntidadService(IEntidadRepository entidadRepository, IValidator<EntidadDto> validator)
        {
            _entidadRepository = entidadRepository;
            _validator = validator;

        }

        public async Task<IEnumerable<Entidad?>> GetAllAsync()
        {
            return await _entidadRepository.GetAllAsync();
        }

        public async Task<EntidadDto?> GetByIdAsync(int id)
        {
            var entidad = await _entidadRepository.GetByIdAsync(id);
            //return _mapper.Map<EntidadDto>(entidad); FALTA MAPPER
            return null;
        }

        public async Task<Result> AddAsync(EntidadDto entidadDto)
        {
            Console.WriteLine("Entro a AddAsync");
            var validationResult = _validator.Validate(entidadDto);
            if (!validationResult.IsValid)
            {
                return Result.Failure(validationResult.Errors.Select(x => x.ErrorMessage).ToArray());
            }
            var entidad = new Entidad
            {
                RazonSocial = entidadDto.RazonSocial,
                Documento = entidadDto.Documento,
                TipoEntidadId = entidadDto.TipoEntidad
            };
            await _entidadRepository.AddAsync(entidad);
            return Result.Success();
        }

        public async Task <Result> UpdateAsync(EntidadDto entidadDto, int id)
        {
            var validationResult = _validator.Validate(entidadDto); 
            if (!validationResult.IsValid)
            {
                return Result.Failure(validationResult.Errors.Select(x => x.ErrorMessage).ToArray());
            }
            var entidad = new Entidad
            {
                Id = id,
                RazonSocial = entidadDto.RazonSocial,
                TipoEntidadId = Convert.ToInt32(entidadDto.TipoEntidad)
            };
            await _entidadRepository.UpdateAsync(entidad, id);
            return Result.Success();
        }

        public async Task DeleteAsync(int id)
        {
            await _entidadRepository.DeleteAsync(id);
        }
       
    }
}
