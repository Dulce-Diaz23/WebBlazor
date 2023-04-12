using Dapper;
using Datos.Interfaces;
using Modelos;
using MySql.Data.MySqlClient;

namespace Datos.Repositorios
{
    public class LoginRepositorio : ILoginRepositorio
    {
        private string CadenaConexion; //recibe la cadena de conexion

        public LoginRepositorio(string _cadenaConexion)
        {
            CadenaConexion = _cadenaConexion;

        }

        // Conexion MySql

        private MySqlConnection Conexion()
        {
            return new MySqlConnection(CadenaConexion);
        }
        public async Task<bool> ValidarUsuarioAsync(Login login)
        {
            bool valido = false;
            try
            {
                using MySqlConnection _conexion = Conexion();
                await _conexion.OpenAsync();
                string sql = "SELECT 1 FROM USUARIO WHERE CodigoUsuario = @CodigoUsuario AND Contrasena = @Contrasena;"; //Sentencia Sql
                valido = await _conexion.ExecuteScalarAsync<bool>(sql, login);
            }
            catch (Exception)
            {

            }
            return valido;
        }
    }
}
