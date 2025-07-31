using Gerenciamento.Funcionarios.Aplicacao.Interfaces;
using Gerenciamento.Funcionarios.Aplicacao.Mappers;
using Gerenciamento.Funcionarios.Aplicacao.Models.Requests;
using Gerenciamento.Funcionarios.Aplicacao.Models.Responses;
using Gerenciamento.Funcionarios.Data.Repositorios;
using Gerenciamento.Funcionarios.Dominio.Entidades;
using Gerenciamento.Funcionarios.Dominio.Interfaces;
using MongoDB.Driver;
using MongoDB.Driver.Linq;

namespace Gerenciamento.Funcionarios.Aplicacao.Servicos;
public class FuncionarioServico : IFuncionarioServico
{
    private readonly IFuncionarioRepositorio _funcionarioRepositorio;

    public FuncionarioServico(IFuncionarioRepositorio funcionarioRepositorio)
    {
        _funcionarioRepositorio = funcionarioRepositorio;
    }

    public async Task<FuncionarioResponse?> FindAsync(Guid id)
    {
        var funcionario = await _funcionarioRepositorio.FindOneAsync(id);

        if (funcionario == null)
            return null;

        return funcionario.ToFuncionarioResponse();
    }

    public async Task<FuncionarioResponse?> FindByCpfjAsync(string cpf)
    {
        var funcionario = await _funcionarioRepositorio.FindByCpfAsync(cpf);

        if (funcionario == null)
            return null;

        return funcionario.ToFuncionarioResponse();
    }

    public async Task AddAsync(FuncionarioRequest request)
    {
        var funcionario = request.ToFuncionario();

        await _funcionarioRepositorio.AddOneAsync(funcionario);
    }

    public async Task DeleteAsync(Guid id)
    {
        await _funcionarioRepositorio.DeleteByIdAsync(id);
    }

    public async Task UpdateAsync(FuncionarioRequest request)
    {
        var filter = new FilterDefinitionBuilder<Funcionario>()
          .Where(x => x.Id == request.Id);

        var funcionarioDominio = request.ToFuncionario();
        
        await _funcionarioRepositorio.ReplaceOneAsync(_ => filter.Inject(), funcionarioDominio);
    }
}
