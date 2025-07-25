using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Gerenciamento.Funcionarios.Dominio.Entidades;
public class Empresa
{
    [BsonRepresentation(BsonType.String)]
    public Guid Id { get; set; }
    public string Nome { get; set; }
    public string CNPJ { get; set; }
    public IEnumerable<Endereco> Enderecos { get; set; }

    public Empresa(Guid id, string nome, string cnpj, IEnumerable<Endereco> endereco)
    {
        Id = id;
        Nome = nome;
        CNPJ = cnpj;
        Enderecos = endereco;
    }
}
