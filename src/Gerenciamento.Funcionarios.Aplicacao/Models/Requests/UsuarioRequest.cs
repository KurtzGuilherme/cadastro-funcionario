namespace Gerenciamento.Funcionarios.Aplicacao.Models.Requests;
public class UsuarioRequest
{
    public string Email { get; private set; }
    public string Password { get; private set; }
    
    public UsuarioRequest(
        string email,
        string password)
    {
        Email = email;
        Password = password;
    }    
}
