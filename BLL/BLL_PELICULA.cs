using BE;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLL_PELICULA
    {
        DAL_MAPPER_PELICULA dalmapperpelicula = new DAL_MAPPER_PELICULA();

        public void GuardarPelicula(BE_PELICULA bepelicula)
        {
            if (bepelicula.Id == 0)
            {
                dalmapperpelicula.Alta(bepelicula);
            }
            else
            {
                dalmapperpelicula.Modificacion(bepelicula);
            }
        }

        public void BorrarPelicula(BE_PELICULA bepelicula)
        {
            dalmapperpelicula.Baja(bepelicula);
        }

        public List<BE_PELICULA> BuscarPelicula(BE_PELICULA bepelicula)
        {
            return dalmapperpelicula.Buscar(bepelicula);
        }

        public List<BE_PELICULA> ListarPeliculas()
        {
            return dalmapperpelicula.TraerTodos();
        }
    }
}
