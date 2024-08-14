using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.BITACORAYCAMBIOS
{
    public class BLL_BITACORA_CAMBIOS
    {
        public List<BE_BitacoraCambiosProducto> retornarBitacoraCambios() //Listar
        {
            return daoBitacora.retornarBitacoraCambios();
        }

        public bool restaurarCambio(string reverseSQL)
        {
            return daoBitacora.restaurarCambio(reverseSQL);
        }
    }
}
