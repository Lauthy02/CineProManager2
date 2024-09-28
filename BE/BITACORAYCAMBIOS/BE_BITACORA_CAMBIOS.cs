using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE.BITACORAYCAMBIOS
{
    public abstract class BE_BITACORA_CAMBIOS
    {        
        private int id;
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        private BE_USUARIO usuarioquemodifica;
        public BE_USUARIO UsuarioQueModifica
        {
            get { return usuarioquemodifica; }
            set { usuarioquemodifica = value; }
        }
        
        private DateTime fechadecambio;
        public DateTime FechaDeCambio
        {
            get { return fechadecambio; }
            set { fechadecambio = value; }
        }

        private bool activo;
        public bool Activo
        {
            get { return activo; }
            set { activo = value; }
        }
    }
}
