using Gerenciamento.Funcionarios.Aplicacao.Interfaces;
using Gerenciamento.Funcionarios.Aplicacao.Mappers;
using Gerenciamento.Funcionarios.Aplicacao.Models.Requests;
using Gerenciamento.Funcionarios.Aplicacao.Models.Responses;
using Gerenciamento.Funcionarios.Dominio.Entidades;
using Gerenciamento.Funcionarios.Dominio.Interfaces;
using MongoDB.Driver;
using MongoDB.Driver.Linq;

namespace Gerenciamento.Funcionarios.Aplicacao.Servicos;
public class EmpresaServico : IEmpresaServico
{
    private readonly IEmpresaRepositorio _empresaRepositorio;

    public EmpresaServico(IEmpresaRepositorio empresaRepositorio)
    {
        _empresaRepositorio = empresaRepositorio;
    }

    public async Task<EmpresaResponse?> FindByCnpjAsync(string cnpj)
    {
        var empresa = await _empresaRepositorio.FindByCnpjAsync(cnpj);

        if (empresa == null)
            return null;

        return empresa.ToEmpresaResponse();
    }

    public async Task<EmpresaResponse?> FindAsync(Guid id)
    {
        var empresaDominio = await _empresaRepositorio.FindOneAsync(id);

        if (empresaDominio == null)
            return null;

        return empresaDominio.ToEmpresaResponse();
    }

    public async Task AddAsync(EmpresaRequest empresa)
    {
        var empresaDominio = empresa.ToEmpresa();

        

        await _empresaRepositorio.AddOneAsync(empresaDominio);
    }

    public async Task DeleteAsync(Guid id)
    {
        await _empresaRepositorio.DeleteByIdAsync(id);
    }

    public async Task UpdateAsync(EmpresaRequest request)
    {
        var filter = new FilterDefinitionBuilder<Empresa>()
           .Where(x => x.CNPJ == request.CNPJ);

        var empresaDominio = request.ToEmpresa();

        await _empresaRepositorio.ReplaceOneAsync(_ => filter.Inject(), empresaDominio);
    }   
}
