using Gerenciamento.Funcionarios.Dominio.Entidades;

namespace Gerenciamento.Funcionarios.Aplicacao.Models.Requests;
public class FuncionarioRequest
{
    public Guid Id { get; private set; }
    public string Nome { get; private set; }
    public string CPF { get; private set; }
    public string Email { get; private set; }
    public DateTime DataNascimento { get; private set; }
    public string Telefone { get; private set; }
    public Guid EmpresaId { get; private set; }
    public string Cargo { get; private set; }
    public DateTime DataContratacao { get; private set; }
    public DateTime? DataDesligamento { get; private set; }
    public bool Ativo { get; private set; }
    public Endereco Endereco { get; private set; }
    public int Idade => DateTime.Today.Year - DataNascimento.Year -
                          (DateTime.Today.DayOfYear < DataNascimento.DayOfYear ? 1 : 0);

    public FuncionarioRequest(
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

    public FuncionarioRequest(
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
    : this(Guid.NewGuid(),
          nome,
          cpf,
          email,
          dataNascimento,
          telefone,
          empresaId,
          cargo,
          dataContratacao,
          dataDesligamento,
          ativo,
          endereco)
    {

    }
}
