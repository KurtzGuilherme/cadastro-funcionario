using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System.ComponentModel.DataAnnotations;

namespace Gerenciamento.Funcionarios.Dominio.Entidades;
public class Funcionario
{
    [BsonId]
    [BsonRepresentation(BsonType.String)]
    public Guid Id { get; private set; }

    public string Nome { get; private set; }

    public string CPF { get; private set; }

    public string Email { get; private set; }

    [DataType(DataType.Date)]
    public DateTime DataNascimento { get; private set; }

    public string Telefone { get; private set; }

    [BsonId]
    [BsonRepresentation(BsonType.String)]
    public Guid EmpresaId { get; private set; }

    public string Cargo { get; private set; }

    [BsonRepresentation(BsonType.DateTime)]
    public DateTime DataContratacao { get; private set; }

    [BsonRepresentation(BsonType.DateTime)]
    public DateTime? DataDesligamento { get; private set; }

    public bool Ativo { get; private set; }

    public Endereco Endereco { get; private set; }

    [BsonIgnore]
    public int Idade => DateTime.Today.Year - DataNascimento.Year -
                          (DateTime.Today.DayOfYear < DataNascimento.DayOfYear ? 1 : 0);

    public Funcionario(
        Guid id,
        string nome,
        string cpf,
        string email,
        DateTime dataNascimento,
        string telefone,
        Guid empresaId,
        string cargo,
        DateTime dataContratacao,
        DateTime? dataDesligamento,
        bool ativo,
        Endereco endereco)
    {
        Id = id;
        Nome = nome;
        CPF = cpf;
        Email = email;
        DataNascimento = dataNascimento;
        Telefone = telefone;
        EmpresaId = empresaId;
        Cargo = cargo;
        DataContratacao = dataContratacao;
        DataDesligamento = dataDesligamento;
        Ativo = ativo;
        Endereco = endereco;
    }
}
