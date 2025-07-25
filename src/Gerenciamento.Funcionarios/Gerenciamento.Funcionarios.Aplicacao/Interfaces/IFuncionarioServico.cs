using Gerenciamento.Funcionarios.Aplicacao.Models.Requests;
using Gerenciamento.Funcionarios.Aplicacao.Models.Responses;

namespace Gerenciamento.Funcionarios.Aplicacao.Interfaces;
public interface IFuncionarioServico
{
    Task<FuncionarioResponse?> FindAsync(Guid id);
    Task<FuncionarioResponse?> FindByCpfjAsync(string cpf);
    Task AddAsync(FuncionarioRequest funcionario);
    Task UpdateAsync(FuncionarioRequest funcionario);
    Task DeleteAsync(Guid id);
}
