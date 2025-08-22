using Gerenciamento.Funcionarios.Aplicacao.Models.Requests;

namespace Gerenciamento.Funcionarios.Aplicacao.Interfaces;
public interface IUsuarioServico
{
    Task AddAsync(UsuarioRequest request);
    Task UpdateAsync(UsuarioRequest funcionario);
    Task DeleteAsync(Guid id);
}
