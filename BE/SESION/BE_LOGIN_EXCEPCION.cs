using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE.SESION
{
    public class BE_LOGIN_EXCEPCION : Exception
    {
        public BE_LOGIN_RESULTADO_ENUM Resultado;
        public BE_LOGIN_EXCEPCION(BE_LOGIN_RESULTADO_ENUM resultado)
        {
            Resultado = resultado;
        }
    }
}
