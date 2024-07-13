using BE.MULTIIDOMA;
using DAL.MULTIIDIOMA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace BLL.MULTIIDIOMA
{
    public class BLL_TRADUCTOR
    {
        DAL_MAPPER_IDIOMA dalmapperidioma = new DAL_MAPPER_IDIOMA();

        public BE_IDIOMA ObtenerIdiomaPorDefecto()
        {
            return dalmapperidioma.TraerTodos().Where(x => x.PorDefecto == true).FirstOrDefault();
        }

        public List<BE_TRADUCCION> ObtenerTraducciones(BE_IDIOMA idioma = null)
        {
            if (idioma == null || idioma.Id == 0)
            {
                idioma = ObtenerIdiomaPorDefecto();
            }

            return dalmapperidioma.ObtenerTraducciones(idioma);
        }

        public void CambiarIdiomaEnFormulario(Form formulario, BE_IDIOMA idioma)
        {
            List<BE_TRADUCCION> traducciones = ObtenerTraducciones(idioma);

            foreach (BE_TRADUCCION traduccion in traducciones)
            {
                RecorrerControles(formulario, traduccion);
            }
        }

        private void RecorrerControles(Control control, BE_TRADUCCION traduccion)
        {
            Type tipodecontrol = control.GetType();

            if (tipodecontrol.Equals(typeof(MenuStrip)))
            {
                foreach (ToolStripMenuItem menuitem in ((MenuStrip)control).Items)
                {
                    if (menuitem.Tag != null && menuitem.Tag.ToString() == traduccion.Etiqueta.Nombre)
                    {
                        if (traduccion.Texto != "-----")
                        {
                            menuitem.Text = traduccion.Texto;
                        }
                    }

                    if (menuitem.DropDownItems.Count != 0)
                    {
                        foreach (ToolStripDropDownItem menudownitem in menuitem.DropDownItems)
                        {
                            if (menudownitem.Tag != null && menudownitem.Tag.ToString() == traduccion.Etiqueta.Nombre)
                            {
                                if (traduccion.Texto != "-----")
                                {
                                    menudownitem.Text = traduccion.Texto;
                                }
                            }
                        }
                    }
                }
            }

            if (tipodecontrol.Equals(typeof(Button)))
            {
                if (((Button)control).Tag != null && ((Button)control).Tag.ToString() == traduccion.Etiqueta.Nombre)
                {
                    if (traduccion.Texto != "-----")
                    {
                        ((Button)control).Text = traduccion.Texto;
                    }
                }
            }

            if (tipodecontrol.Equals(typeof(Label)))
            {
                if (((Label)control).Tag != null && ((Label)control).Tag.ToString() == traduccion.Etiqueta.Nombre)
                {
                    if (traduccion.Texto != "-----")
                    {
                        ((Label)control).Text = traduccion.Texto;
                    }
                }
            }

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
