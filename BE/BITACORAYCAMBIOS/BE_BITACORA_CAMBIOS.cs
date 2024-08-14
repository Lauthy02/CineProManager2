using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE.BITACORAYCAMBIOS
{
    public class BE_BITACORA_CAMBIOS
    {
        //Registro de cambios en entidades
        
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

        private string accion;
        public string Accion
        {
            get { return accion; }
            set { accion = value; }
        }

        private string datoPrevio;
        public string DatoPrevio
        {
            get { return datoPrevio; }
            set { datoPrevio = value; }
        }

        private string datoPosterior;
        public string DatoPosterior
        {
            get { return datoPosterior; }
            set { datoPosterior = value; }
        }
        
        private DateTime fecha;
        public DateTime Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }

        private string consultaEjecutada;
        public string ConsultaEjecutada
        {
            get { return consultaEjecutada; }
            set { consultaEjecutada = value; }
        }

        private string consultaReversa;
        public string ConsultaReversa
        {
            get { return consultaReversa; }
            set { consultaReversa = value; }
        }
    }
}
