using BE;
using BLL.DIGITOVERIFICADOR;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLL_ENTRADA
    {
        DAL_MAPPER_ENTRADA dalmapperentrada = new DAL_MAPPER_ENTRADA();

        public void GuardarEntrada(BE_ENTRADA beentrada)
        {
            if (beentrada.Id == 0)
            {
                dalmapperentrada.Alta(beentrada);
            }
            else
            {
                dalmapperentrada.Modificacion(beentrada);
            }
        }

        public void BorrarEntrada(BE_ENTRADA beentrada)
        {
            dalmapperentrada.Baja(beentrada);
        }

        public List<BE_ENTRADA> BuscarEntrada(BE_ENTRADA beentrada)
        {
            return dalmapperentrada.Buscar(beentrada);
        }

        public List<BE_ENTRADA> BuscarEntradaPorEstado(string estado)
        {
            return dalmapperentrada.BuscarEstado(estado);
        }

        public List<BE_ENTRADA> ListarEntradas()
        {
            return dalmapperentrada.TraerTodos();
        }
    }
}
