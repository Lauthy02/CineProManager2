using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE.BITACORAYCAMBIOS
{
    public class BE_BITACORA_EVENTOS
    {
        //Registro de eventos

        private int id;
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        private BE_USUARIO usuario;
        public BE_USUARIO Usuario
        {
            get { return usuario; }
            set { usuario = value; }
        }

        private DateTime fecha;
        public DateTime Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }

        private string accion;
        public string Accion
        {
            get { return accion; }
            set { accion = value; }
        }

        private string modulo;
        public string Modulo
        {
            get { return modulo; }
            set { modulo = value; }
        }

        private int criticidad; 
        public int Criticidad
        {
            get { return criticidad; }
            set { criticidad = value; }
        }
    }
}
