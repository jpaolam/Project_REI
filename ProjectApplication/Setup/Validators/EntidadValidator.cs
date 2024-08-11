using FluentValidation;
using ProjectApplication.Setup.Dto;
using ProjectDomain.Setup.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectApplication.Setup.Validators
{
    public class EntidadValidator : AbstractValidator<EntidadDto>
    {
        private readonly IEntidadRepository _entidadRepository;
        public EntidadValidator(IEntidadRepository entidadRepository)
        {
            _entidadRepository = entidadRepository;

            RuleFor(x => x.RazonSocial).NotEmpty().WithMessage("La razón social no puede estar vacía.")
                .MaximumLength(100).WithMessage("La razon social debe tener como máximo {MaxLength} caracteres.");

            RuleFor(x => x.Documento).NotEmpty().WithMessage("El documento no puede estar vacío.");


			RuleFor(x => x.TipoEntidad).NotEmpty().WithMessage("El tipo de entidad no puede estar vacío.");

        }
    }
}
