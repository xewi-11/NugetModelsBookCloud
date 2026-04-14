using NugetModelsBookCloud.Models;

namespace NugetModelsBookCloud.Repositories.Interfaces
{
    public interface IRepositoryPagos
    {
        Task<int> CrearPago(Pago pago);
        Task<Pago> GetPago(int pagoId);
        Task<List<Pago>> GetPagosPorPedido(int pedidoId);
        Task<List<Pago>> GetPagosPorUsuario(int usuarioId);
        Task InsertarStripePagoAsync(StripePago stripePago);
        Task<StripePago> GetStripePagoBySessionIdAsync(string sessionId);
        Task ActualizarEstadoStripeAsync(string sessionId, string nuevoEstado);
    }
}