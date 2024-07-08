using BE;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLL_SALA
    {
        //agregarFuncion(), obtenerFunciones(), buscarFuncion()
        DAL_MAPPER_SALA dalmappersala = new DAL_MAPPER_SALA();
        
        public void GuardarSala(BE_SALA besala)
        {
            if (besala.Id == 0)
            {
                dalmappersala.Alta(besala);
            }
            else
            {
                dalmappersala.Modificacion(besala);
            }
        }

        public void BorrarSala(BE_SALA besala)
        {
            dalmappersala.Baja(besala);
        }

        public List<BE_SALA> BuscarSala(BE_SALA besala)
        {
            return dalmappersala.Buscar(besala);
        }

        public List<BE_SALA> ListarSalas()
        {
            return dalmappersala.TraerTodos();
        }
    }
}
