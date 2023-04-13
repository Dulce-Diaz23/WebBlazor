using Modelos;

namespace Blazor.Interfaces
{
    public interface IUsuarioServicio
    {
        //Metodos para manipular tabla de usuarios
        Task<Usuario> GetPorCodigoAsync(string codigo);
        Task<bool> NuevoAsync(Usuario usuario);
        Task<bool> ActualizarAsync(Usuario usuario);
        Task<bool> EliminarAsync(string codigo);
        Task<IEnumerable<Usuario>> GetListaAsync();
    }
}
