using BE.BITACORAYCAMBIOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.BITACORAYCAMBIOS
{
    public class BLL_BITACORA_EVENTOS
    {
        //DAL_BITACORA dalbitacora = new DAL_BITACORA();

        public List<BE_BITACORA_EVENTOS> retornarBitacoraEventos() //Listar
        {
            return daoBitacora.retornarBitacoraEventos();
        }

        public bool registrarBitacoraEvento(string accion, string Modulo, int Criticidad)
        {
            return daoBitacora.registrarBitacoraEvento(accion, Modulo, Criticidad);
        }
    }
}
