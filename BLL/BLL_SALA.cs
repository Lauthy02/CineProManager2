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
        DAL_CINE_SALA dalcinesala = new DAL_CINE_SALA();
        
        public void GuardarSala(BE_CINE becine, BE_SALA besala)
        {
            if (besala.Id == 0)
            {
                besala.Id = dalmappersala.TraerTodos().OrderByDescending(sala => sala.Id).FirstOrDefault().Id + 1;
                dalmappersala.Alta(besala);
                dalcinesala.Alta(becine, besala);
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
