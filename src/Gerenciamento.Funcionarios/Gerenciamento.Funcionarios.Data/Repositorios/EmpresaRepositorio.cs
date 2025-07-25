using Gerenciamento.Funcionarios.Dominio.Entidades;
using Gerenciamento.Funcionarios.Dominio.Interfaces;
using MongoDB.Driver;

namespace Gerenciamento.Funcionarios.Data.Repositorios;
public class EmpresaRepositorio : BaseRepositorio<Empresa>, IEmpresaRepositorio
{
    public EmpresaRepositorio(IMongoDatabase mongoDb) 
        : base(mongoDb, "Empresas")
    {
    }
}
