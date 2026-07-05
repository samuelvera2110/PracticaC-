using Mundial.API.Models;

namespace Mundial.API.Services
{
    public interface ISeleccionService
    {
        Task<List<Seleccion>> ObtenerTodos();
        Task BorrarSeleccion(int id);
        Task CrearSeleccion(Seleccion seleccion);
        Task ActualizarSeleccion(Seleccion seleccion);
    }
}
