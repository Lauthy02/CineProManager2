using BE.BITACORAYCAMBIOS;
using DAL.BITACORAYCAMBIOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.BITACORAYCAMBIOS
{
    public class BLL_BITACORA_EVENTOS
    {
        DAL_MAPPER_BITACORA_EVENTOS dalbitacoraeventos = new DAL_MAPPER_BITACORA_EVENTOS();

        public int GuardarBitacoraEvento(BE_BITACORA_EVENTOS bebitacoraeventos)
        {
            return dalbitacoraeventos.Alta(bebitacoraeventos);
        }

        public List<BE_BITACORA_EVENTOS> ListarBitacoraEvento()
        {
            return dalbitacoraeventos.TraerTodos();
        }
    }
}
