using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class BE_PELICULA
    {
        private int id;
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        private string titulo;
        public string Titulo
        {
            get { return titulo; }
            set { titulo = value; }
        }

        private string autor;
        public string Autor
        {
            get { return autor; }
            set { autor = value; }
        }

        private float duracion;
        public float Duracion
        {
            get { return duracion; }
            set { duracion = value; }
        }

        private string genero;
        public string Genero
        {
            get { return genero; }
            set { genero = value; }
        }

        private int clasificacion;
        public int Clasificacion
        {
            get { return clasificacion; }
            set { clasificacion = value; }
        }
    }
}
