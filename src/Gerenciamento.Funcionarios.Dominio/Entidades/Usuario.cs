using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Gerenciamento.Funcionarios.Dominio.Entidades;

public class Usuario
{
    [BsonId]
    [BsonRepresentation(BsonType.String)]
    public Guid Id { get; private set; }
    public string Nome { get; private set; }
    public string Email { get; private set; }
    public byte[] PasswordHash { get; private set; }
    public byte[] PasswordSalt { get; private set; }

    [BsonId]
    [BsonRepresentation(BsonType.String)]
    public Guid FuncionarioId { get; private set; }

    [BsonRepresentation(BsonType.DateTime)]
    public DateTime DataRegistro { get; private set; }

    public Usuario(
        Guid id,
        string nome,
        string email,
        byte[] passwordHash,
        byte[] passwordSalt,
        Guid funcionarioId,
        DateTime dataRegistro)
    {
        Id = id;
        Nome = nome;
        Email = email;
        PasswordHash = passwordHash;
        PasswordSalt = passwordSalt;
        FuncionarioId = funcionarioId;
        DataRegistro = dataRegistro;
    }

    public Usuario(
        string nome,
        string email,
        byte[] passwordHash,
        byte[] passwordSalt, 
        Guid funcionarioId)
        : this(Guid.NewGuid(), nome, email, passwordHash, passwordSalt, funcionarioId, DateTime.UtcNow)
    {
        
    }

}
