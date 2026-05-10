namespace Microservicio.Clientes.Business.Integrations;

public class UsuarioAppIntegrationResponseDto
{
    public int IdUsuario { get; set; }
    public string Username { get; set; } = null!;
    public string RolAsignado { get; set; } = null!;
}