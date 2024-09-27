using DAL.DIGITOVERIFICADOR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DIGITOVERIFICADOR
{
    public class BLL_DIGITOVERIFICADOR
    {
        DAL_DIGITOVERIFICADOR daldigitoverificador = new DAL_DIGITOVERIFICADOR();

        public bool VerificarDigito(string nombretabla)
        {
            return daldigitoverificador.VerificarDigito(nombretabla);
        }
    }
}
