namespace Gerenciamento.Funcionarios.Aplicacao.Models.Requests;
public class EmpresaRequest
{
    public Guid Id { get; set; }
    public string Nome { get; set; }
    public string CNPJ { get; set; }
    public IEnumerable<EnderecoModel> Enderecos  { get; set; }

    public EmpresaRequest(Guid id, string nome, string cnpj, IEnumerable<EnderecoModel> enderecos)
    {
        Id = id;
        Nome = nome;
        CNPJ = cnpj;
        Enderecos = enderecos;
    }
}
