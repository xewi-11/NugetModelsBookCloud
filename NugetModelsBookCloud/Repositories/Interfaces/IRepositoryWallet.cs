using NugetModelsBookCloud.Models;

namespace NugetModelsBookCloud.Repositories.Interfaces
{
    public interface IRepositoryWallet
    {
        Task<decimal> GetSaldoUsuario(int usuarioId);
        Task<List<SaldoMovimiento>> GetMovimientos(int usuarioId, int limit = 20);
        Task RecargarSaldo(int usuarioId, decimal monto, string descripcion);
        Task DescontarSaldo(int usuarioId, int pedidoId, decimal monto, string descripcion);
        Task<bool> TieneSaldoSuficiente(int usuarioId, decimal monto);
        
        // ? Nuevo método para transferir saldo a vendedores
        Task TransferirSaldoAVendedores(int pedidoId, int compradorId);
    }
}
