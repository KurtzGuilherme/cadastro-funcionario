using Gerenciamento.Funcionarios.Data.Repositorios;
using Gerenciamento.Funcionarios.Dominio.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace Gerenciamento.Funcionarios.CrossCutting.Repositorios;

public static class RepositorioExtensions
{
    public static IServiceCollection AddRepositorios(this IServiceCollection services)
    {
        services.AddScoped<IEmpresaRepositorio, EmpresaRepositorio>();
        services.AddScoped<IFuncionarioRepositorio, FuncionarioRepositorio>();

        return services;
    }
}
