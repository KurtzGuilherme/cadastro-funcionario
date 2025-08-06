using FluentValidation;
using Gerenciamento.Funcionarios.Aplicacao.Models.Requests;

namespace Gerenciamento.Funcionarios.Aplicacao.Validacoes;
public class AddEmpresaValidacao : AbstractValidator<EmpresaRequest>
{
    public AddEmpresaValidacao()
    {
        RuleFor(x => x.Nome)
            .NotNull()
            .NotEmpty()
            .WithMessage("O nome não pode ser vazio ou nulo!!!");

        RuleFor(x => x.CNPJ)
            .NotNull()
            .NotEmpty()
            .WithMessage("O CNPJ não pode ser vazio ou nulo!!!");
    }
}
