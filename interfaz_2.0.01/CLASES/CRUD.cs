using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfaz_2._0._01.CLASES
{
    public class CRUD
    {
        static List<MP3> ListaMP3;
        static List<Usuario> ListaUsuario;
        private Char Separacion = ',';

        public CRUD()
        {
            ListaMP3 = new List<MP3>();
            ListaUsuario = new List<Usuario>();
        }

        public void RegistrarUser(Usuario x)
        {
            if (ListaMP3 == null)
            {
                ListaUsuario = new List<Usuario>();
            }
            ListaUsuario.Add(x);
        }
        public String EscribirRegistroUser(Usuario x)
        {
            StringBuilder sb = new StringBuilder();
            String _Separacion = Separacion.ToString().Trim();
            sb.Append(x._Nombre.ToString());
            sb.Append(_Separacion);
            sb.Append(x._Apellido.ToString());
            sb.Append(_Separacion);
            sb.Append(x._Cedula.ToString());
            sb.Append(_Separacion);
            sb.Append(x._Nick.ToString());
            sb.Append(_Separacion);
            sb.Append(x._Avatar.ToString());
            sb.Append(_Separacion);
            sb.Append(x._Correo.ToString());
            sb.Append(_Separacion);
            sb.Append(x._Contraseña.ToString());
            sb.Append(_Separacion);
            sb.Append(x._FechaNC.ToString("s"));

            return sb.ToString();
        }

        public void RegistrarMP3(MP3 x)
        {
            if (ListaMP3 == null)
            {
                ListaMP3 = new List<MP3>();
            }
            ListaMP3.Add(x);
        }

        //Funcion que sirve para hacer el escrito de los datos en el RegistroMP3.txt
        public String EscribirRegistroMP3(MP3 x)
        {
            StringBuilder sb = new StringBuilder();
            String _Separacion = Separacion.ToString().Trim();
            sb.Append(x._DireccionMP3.ToString());
            sb.Append(_Separacion);
            sb.Append(x._DireccionIMG.ToString());
            sb.Append(_Separacion);
            sb.Append(x._Nombre.ToString());
            sb.Append(_Separacion);
            sb.Append(x._NombreMP3.ToString());
            sb.Append(_Separacion);
            sb.Append(x._Autor.ToString());
            sb.Append(_Separacion);
            sb.Append(x._NrRegistro.ToString());
            sb.Append(_Separacion);
            sb.Append(x._Fecha.ToString("s"));
            sb.Append(_Separacion);
            sb.Append(x._EsPublico.ToString());

            return sb.ToString();
        }

        public Boolean BuscarMP3(Int32 NrRegistro)
        {
            Boolean Encontrado = false;
            foreach (MP3 mp3 in ListaMP3)
            {
                if (mp3._NrRegistro == NrRegistro)
                {
                    Encontrado = true;
                    break;
                }
            }
            return Encontrado;
        }
        public MP3 ConsultarMP3(Int32 NrRegistro)
        {
            MP3 mp3Encontrado = null;
            foreach (MP3 mp3 in ListaMP3)
            {
                if (mp3._NrRegistro == NrRegistro)
                {
                    mp3Encontrado = mp3;
                    break;
                }
            }
            return mp3Encontrado;
        }

        public void ActualizarMP3(MP3 mp3Actualizado)
        {
            for (int i = 0; i < ListaMP3.Count; i++)
            {
                if (ListaMP3[i]._NrRegistro == mp3Actualizado._NrRegistro)
                {
                    ListaMP3[i] = mp3Actualizado;
                    break;
                }
            }
        }

        public void EliminarMP3(MP3 mp3Eliminado)
        {
            for (int i = 0; i < ListaMP3.Count; i++)
            {
                if (ListaMP3[i]._NrRegistro == mp3Eliminado._NrRegistro)
                {
                    ListaMP3.RemoveAt(i);
                    break;
                }
            }
        }

        public void GuardarMP3sEnArchivo(string rutaArchivo)
        {
            using (StreamWriter writer = new StreamWriter(rutaArchivo, false))
            {
                foreach (MP3 mp3 in ListaMP3)
                {
                    writer.WriteLine(EscribirRegistroMP3(mp3));
                }
            }
        }

        public void CargarMP3sDesdeArchivo(string rutaArchivo)
        {
            ListaMP3 = new List<MP3>();
            string[] lineas = File.ReadAllLines(rutaArchivo);
            foreach (string linea in lineas)
            {
                MP3 mp3 = new MP3();
                string[] campos = linea.Split(Separacion);
                mp3._DireccionMP3 = campos[0];
                mp3._DireccionIMG = campos[1];
                mp3._Nombre = campos[2];
                mp3._NombreMP3 = campos[3];
                mp3._Autor = campos[4];
                mp3._NrRegistro = int.Parse(campos[5]);
                mp3._Fecha = DateTime.Parse(campos[6]);
                mp3._EsPublico = bool.Parse(campos[7]);
                ListaMP3.Add(mp3);
            }
        }
    }
}
