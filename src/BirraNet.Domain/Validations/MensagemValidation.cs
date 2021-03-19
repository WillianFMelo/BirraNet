using BirraNet.Domain.Models;
using FluentValidation;

namespace BirraNet.Domain.Validations
{
    public class MensagemValidation : AbstractValidator<Mensagem>
    {
        public MensagemValidation()
        {
            RuleFor(m => m.Texto)
                .NotEmpty().WithMessage("Por favor, digite uma mensagem")
                .Length(1, 500).WithMessage("Mensagem deve ter entre 2 e 500 caracteres");
        }
    }
}
