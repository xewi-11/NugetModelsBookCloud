using NugetModelsBookCloud.Models;

namespace NugetModelsBookCloud.Repositories.Interfaces
{
    public interface IRepositoryLibros
    {
        Task<List<Libro>> GetLibros();
        Task<Libro> GetLibro(int id);
        Task<int> InsertLibro(Libro libro);
        Task UpdateLibro(Libro libro);
        Task DeleteLibro(int id);
    }
}
