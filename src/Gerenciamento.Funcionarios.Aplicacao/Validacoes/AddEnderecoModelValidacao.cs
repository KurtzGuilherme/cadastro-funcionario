using FluentValidation;
using Gerenciamento.Funcionarios.Aplicacao.Models;

namespace Gerenciamento.Funcionarios.Aplicacao.Validacoes;
public class AddEnderecoModelValidacao : AbstractValidator<EnderecoModel>
{
    public AddEnderecoModelValidacao()
    {
        RuleFor(x => x.Estado)
            .NotNull()
            .NotEmpty()
            .WithMessage("O Estado não pode ser vazio ou nulo.");

        RuleFor(x => x.CEP)
            .NotNull()
            .NotEmpty()
            .WithMessage("O CEP não pode ser vazio ou nulo.");

        RuleFor(x => x.Rua)
            .NotNull()
            .NotEmpty()
            .WithMessage("O Rua não pode ser vazio ou nulo.");

        RuleFor(x => x.Cidade)
           .NotNull()
           .NotEmpty()
           .WithMessage("O Cidade não pode ser vazio ou nulo.");
    }
}
