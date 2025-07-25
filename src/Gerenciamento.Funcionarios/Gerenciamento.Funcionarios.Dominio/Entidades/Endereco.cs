namespace Gerenciamento.Funcionarios.Dominio.Entidades;

public record Endereco
{
    public string Rua { get; set; }
    public string Cidade { get; set; }
    public string Estado { get; set; }
    public string CEP { get; set; }

    public Endereco(string rua, string cidade, string estado, string cep)
    {
        Rua = rua;
        Cidade = cidade;
        Estado = estado;
        CEP = cep;       
    }
}
