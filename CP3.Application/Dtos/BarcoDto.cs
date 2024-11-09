using CP3.Domain.Interfaces.Dtos;
using FluentValidation;

namespace CP3.Application.Dtos
{
    public class BarcoDto : IBarcoDto
    {
        public int? Id { get; set; }
        public string? Nome { get; set; }
        public int Ano { get; set; }
        public string? Modelo { get; set; }
        public double  Tamanho { get; set; }
        public void Validate()
        {

            var validateResult = new BarcoDtoValidation().Validate(this);

            if (!validateResult.IsValid)
                throw new ArgumentException(string.Join(" e ", validateResult.Errors.Select(x => x.ErrorMessage)));

        }
    }

    internal class BarcoDtoValidation : AbstractValidator<BarcoDto>
    {
        public BarcoDtoValidation()
        {
            RuleFor(x => x.Nome)
                .MinimumLength(5).WithMessage(x => $"O campo {nameof(x.Nome)}, deve ter no minimo 5 caracteres")
                .NotEmpty().WithMessage(x => $"O campo {nameof(x.Nome)}, não pode ser vazio");
            
            RuleFor(x => x.Modelo)
                .MinimumLength(5).WithMessage(x => $"O campo {nameof(x.Modelo)}, deve ter no minimo 4 caracteres")
                .NotEmpty().WithMessage(x => $"O campo {nameof(x.Modelo)}, não pode ser vazio");

        }
    }

}
