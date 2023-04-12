using Modelos;

namespace Blazor.Interfaces
{
    public interface ILoginServicio
    {
        Task<bool> ValidarUusarioAsync(Login login);
    }
}
