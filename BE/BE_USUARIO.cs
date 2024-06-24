using BE.MULTIIDOMA;
using BE.PERMISOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class BE_USUARIO
    {
        public BE_USUARIO()
        {
            listaDePermisos = new List<BE_PERMISO>();
            idioma = new BE_IDIOMA();
        }

        private List<BE_PERMISO> listaDePermisos;
        public List<BE_PERMISO> ListaDePermisos
        {
            get { return listaDePermisos; }
            //set { listaDePermisos = value; }
        }

        private int id;
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        private string nombredeusuario;
        public string NombreDeUsuario
        {
            get { return nombredeusuario; }
            set { nombredeusuario = value; }
        }
        
        private string nombre;
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        private string apellido;
        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }
        
        private string contrasenia;
        public string Contrasenia
        {
            get { return contrasenia; }
            set { contrasenia = value; }
        }

        private string correo;
        public string Correo
        {
            get { return correo; }
            set { correo = value; }
        }

        private BE_IDIOMA idioma;
        public BE_IDIOMA Idioma
        {
            get { return idioma; }
            set { idioma = value; }
        }

        public override string ToString()
        {
            return Nombre + " " + Apellido;
        }
    }
}
