using Gerenciamento.Funcionarios.Aplicacao.Interfaces;
using Gerenciamento.Funcionarios.Aplicacao.Servicos;
using Microsoft.Extensions.DependencyInjection;

namespace Gerenciamento.Funcionarios.CrossCutting.Servicos;
public static class ServicoExtensions
{
    public static IServiceCollection AddServicos(this IServiceCollection services)
    {

        services.AddScoped<IEmpresaServico, EmpresaServico>();

        return services;
    }
}
