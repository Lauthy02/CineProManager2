using BE;
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

        public int CalcularPrecio(BE_ENTRADA beentrada)
        {
            int precio = 0;
            switch (beentrada.Sala.Formato)
            {
                case BE_SALA_FORMATO_ENUM._2D:
                    precio = 100 * beentrada.Cantidad;
                    break;
                case BE_SALA_FORMATO_ENUM._3D:
                    precio = 150 * beentrada.Cantidad;
                    break;
                case BE_SALA_FORMATO_ENUM._4D:
                    precio = 200 * beentrada.Cantidad;
                    break;
                case BE_SALA_FORMATO_ENUM._XD:
                    precio = 250 * beentrada.Cantidad;
                    break;
                case BE_SALA_FORMATO_ENUM._DBOX:
                    precio = 300 * beentrada.Cantidad;
                    break;
                case BE_SALA_FORMATO_ENUM._PREMIUM:
                    precio = 350 * beentrada.Cantidad;
                    break;
                case BE_SALA_FORMATO_ENUM._COMFORT:
                    precio = 400 * beentrada.Cantidad;
                    break;
                default:
                    precio = 0;
                    break;
            }
            return precio;
        }
    }
}
