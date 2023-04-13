namespace Blazor
{
    public class Config
    {
        public string CadenaConexion { get; set; } // lee cadena de conexion de appsettings.json
        public Config(string _cadenaConexion)
        {
            CadenaConexion = _cadenaConexion;
        }
    }
}
