using Gerenciamento.Funcionarios.Aplicacao.Interfaces;
using Gerenciamento.Funcionarios.Aplicacao.Models.Requests;

namespace Gerenciamento.Funcionarios.Aplicacao.Servicos;
public class UsuarioServico : IUsuarioServico
{
    public UsuarioServico()
    {
        
    }
    public Task AddAsync(UsuarioRequest request)
    {
        throw new NotImplementedException();
    }

    public Task DeleteAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task UpdateAsync(UsuarioRequest funcionario)
    {
        throw new NotImplementedException();
    }
}
