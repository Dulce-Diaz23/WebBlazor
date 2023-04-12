namespace Modelos
{
    public class Login
    {
        //Propiedades
        public string CodigoUsuario { get; set; }
        public string Contrasena { get; set; }
        public string Rol { get; set; }

        public Login()
        {

        }

        public Login(string codigoUsuario, string contrasena, string rol)
        {
            codigoUsuario = CodigoUsuario;
            Contrasena = contrasena;
            Rol = rol;
        }
    }
}
