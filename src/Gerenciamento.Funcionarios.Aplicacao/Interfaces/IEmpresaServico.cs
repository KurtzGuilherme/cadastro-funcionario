using Gerenciamento.Funcionarios.Aplicacao.Models.Requests;
using Gerenciamento.Funcionarios.Aplicacao.Models.Responses;

namespace Gerenciamento.Funcionarios.Aplicacao.Interfaces;
public interface IEmpresaServico 
{
    Task<EmpresaResponse?> FindByCnpjAsync(string cnpj);
    Task<EmpresaResponse?> FindAsync(Guid id);
    Task AddAsync(EmpresaRequest empresa);
    Task UpdateAsync(EmpresaRequest empresa);
    Task DeleteAsync(Guid id);
}
