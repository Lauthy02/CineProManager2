using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

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

        private string director;
        public string Director
        {
            get { return director; }
            set { director = value; }
        }

        private int duracion;
        public int Duracion
        {
            get { return duracion; }
            set { duracion = value; }
        }

        private BE_PELICULA_GENERO_ENUM genero;
        public BE_PELICULA_GENERO_ENUM Genero
        {
            get { return genero; }
            set { genero = value; }
        }

        private byte[] imagen;
        public byte[] Imagen
        {
            get { return imagen; }
            set { imagen = value; }
        }

        private string descripcion;
        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }

        public override string ToString()
        {
            return titulo;
        }
    }
}
