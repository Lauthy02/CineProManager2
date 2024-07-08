using BE;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLL_FUNCION
    {
        DAL_MAPPER_FUNCION dalmapperfuncion = new DAL_MAPPER_FUNCION();
        DAL_SALA_FUNCION dalsalafuncion = new DAL_SALA_FUNCION();

        public void GuardarFuncion(BE_SALA besala, BE_FUNCION befuncion)
        {
            if (befuncion.Id == 0)
            {
                befuncion.Id = dalmapperfuncion.TraerTodos().OrderByDescending(funcion => funcion.Id).FirstOrDefault().Id + 1;
                dalmapperfuncion.Alta(befuncion);
                dalsalafuncion.Alta(besala, befuncion);
            }
            else
            {
                dalmapperfuncion.Modificacion(befuncion);
            }
        }

        public void BorrarFuncion(BE_FUNCION befuncion)
        {
            dalmapperfuncion.Baja(befuncion);
        }

        public List<BE_FUNCION> BuscarSala(BE_FUNCION befuncion)
        {
            return dalmapperfuncion.Buscar(befuncion);
        }

        public List<BE_FUNCION> ListarFunciones()
        {
            return dalmapperfuncion.TraerTodos();
        }
    }
}
