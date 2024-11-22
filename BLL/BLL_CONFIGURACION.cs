using BE;
using DAL;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace BLL
{
    public class BLL_CONFIGURACION
    {
        DAL_SERIALZIAR dalserializar = new DAL_SERIALZIAR();

        public BE_CONFIGURACION CargarConfiguracion()
        {
            if (File.Exists(BE_CONFIGURACION.Path))
            {
                return dalserializar.Deserializar<BE_CONFIGURACION>(BE_CONFIGURACION.Path);
            }
            else
            {
                return new BE_CONFIGURACION { PrimeraVez = true, CantidadEntradasGeneradas = 0 };
            }
        }

        public void GuardarConfiguracion(BE_CONFIGURACION beconfiguracion)
        {
            dalserializar.Serializar<BE_CONFIGURACION>(beconfiguracion, BE_CONFIGURACION.Path);
        }
    }
}
