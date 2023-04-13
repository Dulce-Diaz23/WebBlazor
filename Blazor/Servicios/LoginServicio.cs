using Blazor.Interfaces;
using Modelos;

namespace Blazor.Servicios
{
    public class LoginServicio : ILoginServicio
    {
        private readonly Config _config;
        private ILoginRepositorio;
        public Task<bool> ValidarUusarioAsync(Login login)
        {
            throw new NotImplementedException();
        }
    }
}
