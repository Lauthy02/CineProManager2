using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE.MULTIIDOMA
{
    public class BE_IDIOMA
    {
        private int id;
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        private bool pordefecto;
        public bool PorDefecto
        {
            get { return pordefecto; }
            set { pordefecto = value; }
        }

        private BE_IDIOMA_NOMBRE_ENUM nombre;
        public BE_IDIOMA_NOMBRE_ENUM Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
    }
}
