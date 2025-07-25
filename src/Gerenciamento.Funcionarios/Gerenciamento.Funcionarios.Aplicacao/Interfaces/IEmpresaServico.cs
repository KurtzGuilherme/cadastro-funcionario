using Gerenciamento.Funcionarios.Aplicacao.Models.Requests;
using Gerenciamento.Funcionarios.Aplicacao.Models.Responses;
using Gerenciamento.Funcionarios.Dominio.Entidades;

namespace Gerenciamento.Funcionarios.Aplicacao.Interfaces;
public interface IEmpresaServico 
{
    Task<EmpresaResponse> FindAsync(Guid id);
    Task AddAsync(EmpresaRequest empresa);
    Task UpdateAsync(EmpresaRequest empresa);
    Task DeleteAsync(Guid id);
}
