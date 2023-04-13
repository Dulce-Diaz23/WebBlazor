using Modelos;

namespace Datos.Interfaces
{
    public interface IUsuarioRepositorio
    {
        //Metodos para manipular tabla de usuarios
        Task<Usuario> GetPorCodigoAsync(string codigo);
        Task<bool> NuevoAsync(Usuario usuario);
        Task<bool> ActualizarAsync(Usuario usuario);
        Task<bool> EliminarAsync(string codigo);
        Task<IEnumerable<Usuario>> GetListaAsync();
    }
}
