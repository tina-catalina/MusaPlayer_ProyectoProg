using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfaz_2._0._01.CLASES
{
    public class MP3
    {
        private String DireccionMP3, DireccionIMG, Nombre, NombreMP3, Autor;
        private Int32 NrRegistro;
        private DateTime Fecha;
        private Boolean EsPublico;

        public String _DireccionMP3 { get { return DireccionMP3; } set { DireccionMP3 = value; } }
        public String _DireccionIMG { get { return DireccionIMG; } set { DireccionIMG = value; } }
        public String _Nombre { get { return Nombre; } set { Nombre = value; } }
        public String _NombreMP3 { get { return NombreMP3; } set { NombreMP3 = value; } }
        public String _Autor { get { return Autor; } set { Autor = value; } }
        public Int32 _NrRegistro { get { return NrRegistro; } set { NrRegistro = value; } }
        public DateTime _Fecha { get { return Fecha; } set { Fecha = value; } }
        public Boolean _EsPublico { get { return EsPublico; } set { EsPublico = value; } }

        public MP3()
        {
            _DireccionMP3 = ""; _DireccionIMG = ""; _Nombre = ""; _NombreMP3 = ""; _Autor = ""; _NrRegistro = 0; _Fecha = DateTime.Now; _EsPublico = true;
        }

        public MP3(string direccionMP3, string direccionIMG, string nombre, string nombreMP3, string autor, Int32 nrRegistro, Boolean espublico)
        {
            _DireccionMP3 = direccionMP3;
            _DireccionIMG = direccionIMG;
            _Nombre = nombre;
            _NombreMP3 = nombreMP3;
            _Autor = autor;
            _NrRegistro = nrRegistro;
            _EsPublico = espublico;
            _Fecha = DateTime.Now;
        }
    }
}
