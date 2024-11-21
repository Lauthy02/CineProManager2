using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace BE
{
    public class BE_CONFIGURACION
    {
        private bool primeraVez;
        public bool PrimeraVez
        {
            get { return primeraVez; }
            set { primeraVez = value; }
        }

        private int cantidadEntradasGeneradas;
        public int CantidadEntradasGeneradas
        {
            get { return cantidadEntradasGeneradas; }
            set { cantidadEntradasGeneradas = value; }
        }

        public static string Path = "configuracion.json";
    }
}
