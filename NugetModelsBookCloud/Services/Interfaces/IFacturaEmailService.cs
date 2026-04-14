namespace NugetModelsBookCloud.Services.Interfaces
{
    public interface IFacturaEmailService
    {
        Task EnviarFacturaPedidoAsync(int pedidoId);
    }
}
