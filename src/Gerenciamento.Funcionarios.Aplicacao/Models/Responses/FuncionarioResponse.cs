using Gerenciamento.Funcionarios.Dominio.Entidades;

namespace Gerenciamento.Funcionarios.Aplicacao.Models.Responses;
public class FuncionarioResponse
{
    public Guid Id { get; set; }
    public string Nome { get; set; }
    public string CPF { get; set; }
    public string Email { get; set; }
    public DateTime DataNascimento { get; set; }
    public string Telefone { get; set; }
    public Guid EmpresaId { get; set; }
    public string Cargo { get; set; }
    public DateTime DataContratacao { get; set; }
    public DateTime? DataDesligamento { get; set; }
    public bool Ativo { get; set; }
    public Endereco Endereco { get; set; }
    public int Idade => DateTime.Today.Year - DataNascimento.Year -
                          (DateTime.Today.DayOfYear < DataNascimento.DayOfYear ? 1 : 0);

    public FuncionarioResponse(
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
