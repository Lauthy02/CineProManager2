using BE.MULTIIDOMA;
using DAL.MULTIIDIOMA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BLL.MULTIIDIOMA
{
    public class BLL_TRADUCTOR
    {
        DAL_MAPPER_IDIOMA dalmapperidioma = new DAL_MAPPER_IDIOMA();
        BLL_IDIOMA bllidioma = new BLL_IDIOMA();

        public BE_IDIOMA ObtenerIdiomaPorDefecto()
        {
            return dalmapperidioma.TraerTodos().Where(x => x.PorDefecto == true).FirstOrDefault();
        }

        public IDictionary<string, BE_TRADUCCION> ObtenerTraducciones(BE_IDIOMA idioma = null)
        {
            if (idioma == null)
            {
                idioma = ObtenerIdiomaPorDefecto();
            }

            return dalmapperidioma.ObtenerTraducciones(idioma);
        }

        public void CambiarIdiomaEnFormulario(Form formulario, BE_IDIOMA idioma)
        {
            var traducciones = ObtenerTraducciones(idioma);

            foreach (var traduccion in traducciones)
            {
                //RecorrerControles(formulario, traduccion);
            }
        }

        private void RecorrerControles(Control control, BE_TRADUCCION traduccion)
        {
            if (control.Tag != null && control.Tag.ToString() == traduccion.Etiqueta.Nombre)
            {
                if (traduccion.Texto != "-----")
                {
                    control.Text = traduccion.Texto;
                }
            }

            foreach (Control childControl in control.Controls)
            {
                RecorrerControles(childControl, traduccion);
            }
        }

    }
}
