using Microsoft.Extensions.DependencyInjection;
using FluentValidation;
using Gerenciamento.Funcionarios.Aplicacao.Models.Requests;
using Gerenciamento.Funcionarios.Aplicacao.Validacoes;
using Gerenciamento.Funcionarios.Aplicacao.Models;
using FluentValidation.AspNetCore;

namespace Gerenciamento.Funcionarios.CrossCutting.Validacoes;
public static class ValidacaoExtensions
{
    public static IServiceCollection AddValidacao(this IServiceCollection services)
    {
        services.AddFluentValidationAutoValidation(x => x.DisableDataAnnotationsValidation = true);

        services.AddScoped<IValidator<EmpresaRequest>, AddEmpresaValidacao>();
        services.AddScoped<IValidator<EnderecoModel>, AddEnderecoModelValidacao>();

        return services;
    }
}
