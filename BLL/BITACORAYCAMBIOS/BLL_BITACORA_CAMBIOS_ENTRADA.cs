using BE;
using BE.BITACORAYCAMBIOS;
using DAL.BITACORAYCAMBIOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.BITACORAYCAMBIOS
{
    public class BLL_BITACORA_CAMBIOS_ENTRADA
    {
        DAL_BITACORA_CAMBIOS_ENTRADA dalbitacoracambiosentrada = new DAL_BITACORA_CAMBIOS_ENTRADA();

        public int GuardarEntrada(BE_BITACORA_CAMBIOS_ENTRADA bitacoracambiosentrada)
        {
            return dalbitacoracambiosentrada.Alta(bitacoracambiosentrada);
        }

        public void RecomponerEstado(BE_BITACORA_CAMBIOS_ENTRADA entrada)
        {
            dalbitacoracambiosentrada.RecomponerEstado(entrada);
        }

        public List<BE_BITACORA_CAMBIOS_ENTRADA> ListarBitacoraCambios()
        {
            return dalbitacoracambiosentrada.TraerTodos();
        }

        /*
        public bool restaurarCambio(string reverseSQL)
        {
            return dalbitacoracambiosentrada.restaurarCambio(reverseSQL);
        }
        */
    }
}
