using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_ENCRIPTADOR
    {
        public string Encriptar(string contrasenia)
        {
            string resultado = string.Empty;
            byte[] encriptado = Encoding.Unicode.GetBytes(contrasenia);
            resultado = Convert.ToBase64String(encriptado);
            return resultado;
        }

        public string Desencriptar(string contraseniaencriptada)
        {
            string resultado = string.Empty;
            byte[] desencriptado = Convert.FromBase64String(contraseniaencriptada);
            resultado = Encoding.Unicode.GetString(desencriptado);
            return resultado;
        }
    }
}
