namespace Gerenciamento.Funcionarios.CrossCutting.Model;
public class Settings
{
    public MongoSettings? MongoSettings { get; set; } 
    public AuthenticationSettings? AuthenticationSettings { get; set; }
}
