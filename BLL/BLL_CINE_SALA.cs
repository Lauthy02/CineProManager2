using BE;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BLL
{
    public class BLL_CINE_SALA
    {
        DAL_CINE_SALA dalcinesala = new DAL_CINE_SALA();

        public void GuardarCineSala(BE_CINE becine, BE_SALA besala)
        {
            if (becine.Id == 0)
            {
                dalcinesala.Alta(becine, besala);
            }
            else
            {
                //dalcinesala.Modificacion(becine);
                MessageBox.Show("No se puede modificar");
            }
        }
    }
}
