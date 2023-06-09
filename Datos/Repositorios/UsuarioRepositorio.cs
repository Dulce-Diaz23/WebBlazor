﻿using Dapper;
using Datos.Interfaces;
using Modelos;
using MySql.Data.MySqlClient;

namespace Datos.Repositorios
{
    public class UsuarioRepositorio : IUsuarioRepositorio
    {


        private string CadenaConexion; //recibe la cadena de conexion

        public UsuarioRepositorio(string _cadenaConexion)
        {
            CadenaConexion = _cadenaConexion;
        }

        private MySqlConnection Conexion()
        {
            return new MySqlConnection(CadenaConexion);
        }

        public async Task<bool> ActualizarAsync(Usuario usuario)
        {
            bool resultado = false;
            try
            {
                using MySqlConnection _conexion = Conexion();
                await _conexion.OpenAsync();
                string sql = "UPDATE usuario SET Nombre= @Nombre, Contrasena = @Contrasena,Rol= @Rol, EstaActivo = @EstaActivo, Correo= @Correo, Foto=@Foto, " +
                    "WHERE CodigoUsuario = @CodigoUsuario;"; //Sentencia Sql
                resultado = Convert.ToBoolean(await _conexion.ExecuteScalarAsync<bool>(sql, usuario));
            }
            catch (Exception)
            {
            }
            return resultado;
        }

        public async Task<bool> EliminarAsync(string codigo)
        {
            bool resultado = false;
            try
            {
                using MySqlConnection _conexion = Conexion();
                await _conexion.OpenAsync();
                string sql = "DELETE FROM usuario WHERE CodigoUsuario = @CodigoUsuario;"; //Sentencia Sql
                resultado = Convert.ToBoolean(await _conexion.ExecuteScalarAsync<bool>(sql, new { codigo }));
            }
            catch (Exception)
            {
            }
            return resultado;
        }

        public async Task<IEnumerable<Usuario>> GetListaAsync()
        {
            IEnumerable<Usuario> lista = new List<Usuario>();
            try
            {
                using MySqlConnection _conexion = Conexion();
                await _conexion.OpenAsync();
                string sql = "SELECT * FROM usuario;";
                lista = await _conexion.QueryAsync<Usuario>(sql);
            }
            catch (Exception)
            {
            }
            return lista;

        }

        public async Task<Usuario> GetPorCodigoAsync(string codigo)
        {
            Usuario user = new Usuario();
            try
            {
                using MySqlConnection _conexion = Conexion();
                await _conexion.OpenAsync();
                string sql = "SELECT * FROM usuario WHERE CodigoUsuario = @CodigoUsuario;"; //Sentencia Sql
                user = await _conexion.QueryFirstAsync<Usuario>(sql, new { codigo });
            }
            catch (Exception)
            {
            }
            return user;
        }

        public async Task<bool> NuevoAsync(Usuario usuario)
        {
            bool resultado = false;
            try
            {
                using MySqlConnection _conexion = Conexion();
                await _conexion.OpenAsync();
                string sql = "INSERT INTO  usuario (CodigoUsuario, Nombre, Contrasena,Rol, FechaCreacion, EstaActivo, Correo, Foto)" +
                    "VALUES(@CodigoUsuario, @Nombre, @Contrasena, @Rol, @FechaCreacion, @EstaActivo, @Correo,  @Foto); ";
                resultado = Convert.ToBoolean(await _conexion.QueryFirstAsync<Usuario>(sql, usuario));
            }
            catch (Exception)
            {
            }
            return resultado;
        }


    }
}
