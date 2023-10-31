using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfaz_2._0._01.CLASES
{
    public class Usuario
    {
        private string Nombre, Apellido, Cedula, Nick, Avatar, Correo, Contraseña;
        private DateTime FechaNC;
        private DateTime FechaRegistro;
        private Int32 NrRegistro;
        private bool Activo;
        private List<string> listareproduccion;

        public string _Nombre { get { return Nombre; } set { Nombre = value; } }
        public string _Apellido { get { return Apellido; } set { Apellido = value; } }
        public string _Cedula { get { return Cedula; } set { Cedula = value; } }
        public DateTime _FechaNC { get { return FechaNC; } set { FechaNC = value; } }
        public DateTime _FechaRegistro { get { return FechaRegistro; } set { FechaRegistro = value; } }
        public string _Nick { get { return Nick; } set { Nick = value; } }
        public string _Avatar { get { return Avatar; } set { Avatar = value; } }
        public Int32 _NrRegistro { get { return NrRegistro; } set { NrRegistro = value; } }
        public string _Correo { get { return Correo; } set { Correo = value; } }
        public string _Contraseña { get { return Contraseña; } set { Contraseña = value; } }
        public bool _Activo { get { return Activo; } set { Activo = value; } }
        public List<string> Listareproduccion { get { return listareproduccion; } set { listareproduccion = value; } }

        public Usuario()
        {
            Nombre = ""; Apellido = ""; Cedula = ""; FechaNC = DateTime.Now; Nick = ""; Avatar = "";
            NrRegistro = 0; Correo = ""; Contraseña = ""; Activo = true; listareproduccion = new List<string>();
        }
        public Usuario(string nombre, string apellido, string cedula, DateTime fechaNC, string nick, string fotoreferencia, string correo, string contraseña)
        {
            _Nombre = nombre; _Apellido = apellido; Cedula = cedula; FechaNC = fechaNC; FechaRegistro = DateTime.Now.Date; Nick = nick; _Avatar = fotoreferencia; Correo = correo; Contraseña = contraseña; Activo = true;
        }
        public Usuario(string nombre, string apellido, string cedula, DateTime fechaNC, string nick)
        {
            _Nombre = nombre; _Apellido = apellido; Cedula = cedula; FechaNC = fechaNC; FechaRegistro = DateTime.Now.Date; Nick = nick; Activo = true;
        }
        // falta igualar la direccion de imagen
        //public Usuario(string nombre, string apellido, string cedula, DateTime fechaNC, string nick, string fotoreferencia)
        //{
        //    Nombres = nombre; Apellidos = apellido; Cedula = cedula; FechaNC = fechaNC; Fecharegistro = DateTime.Now.Date; Nick = nick; Fotoreferemcia = fotoreferencia; activo = true;
        //}
    }
}
