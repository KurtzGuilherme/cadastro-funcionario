using FluentValidation;
using Gerenciamento.Funcionarios.Aplicacao.Models.Requests;

namespace Gerenciamento.Funcionarios.Aplicacao.Validacoes;
public class AddUsuarioValidacao : AbstractValidator<UsuarioRequest>
{
    public AddUsuarioValidacao()
    {
        RuleFor(x => x.Email)
           .NotNull()
           .NotEmpty()
           .WithMessage("O Email não pode ser vazio ou nulo.")
           .EmailAddress().WithMessage("Email inválido."); 

        RuleFor(x => x.Password)
            .NotNull()
            .NotEmpty()
            .WithMessage("O Password não pode ser vazio ou nulo.")
            .MinimumLength(8).WithMessage("A senha deve ter no mínimo 8 caracteres.")
            .MaximumLength(15).WithMessage("A senha deve ter no máximo 15 caracteres.")
            .Matches("[A-Z]").WithMessage("A senha deve conter pelo menos uma letra maiúscula.")
            .Matches("[a-z]").WithMessage("A senha deve conter pelo menos uma letra minúscula.")
            .Matches("[0-9]").WithMessage("A senha deve conter pelo menos um número.")
            .Matches("[^a-zA-Z0-9]").WithMessage("A senha deve conter pelo menos um caractere especial.");
    }
}
