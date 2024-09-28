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
        #region MD5
        //https://www.youtube.com/watch?v=H25gXvKqOf4&t=616s
        public string EncriptarMD5(string contrasenia)
        {
            string hash = "contrasenia";
            byte[] encriptado = Encoding.Unicode.GetBytes(contrasenia);
            
            MD5 md5 = MD5.Create();
            TripleDES tripleDES = TripleDES.Create();

            tripleDES.Key = md5.ComputeHash(Encoding.Unicode.GetBytes(hash));
            tripleDES.Mode = CipherMode.ECB;

            ICryptoTransform transform = tripleDES.CreateEncryptor();
            byte[] resultado = transform.TransformFinalBlock(encriptado, 0, encriptado.Length);

            return Convert.ToBase64String(resultado);
        }

        public string DesencriptarMD5(string contraseniaencriptada)
        {
            string hash = "contrasenia";
            byte[] encriptado = Convert.FromBase64String(contraseniaencriptada);
            
            MD5 md5 = MD5.Create();
            TripleDES tripleDES = TripleDES.Create();

            tripleDES.Key = md5.ComputeHash(Encoding.Unicode.GetBytes(hash));
            tripleDES.Mode = CipherMode.ECB;

            ICryptoTransform transform = tripleDES.CreateDecryptor();
            byte[] resultado = transform.TransformFinalBlock(encriptado, 0, encriptado.Length);

            return Encoding.Unicode.GetString(resultado);
        }
        #endregion

        #region SHA256
        public string EncriptarSHA256(string contrasenia)
        {
            string resultado = string.Empty;
            byte[] encriptado = Encoding.Unicode.GetBytes(contrasenia);
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] hash = sha256.ComputeHash(encriptado);
                resultado = Convert.ToBase64String(hash);
            }
            return resultado;
        }

        public string DesencriptarSHA256(string contraseniaencriptada)
        {
            string resultado = string.Empty;
            byte[] desencriptado = Convert.FromBase64String(contraseniaencriptada);
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] hash = sha256.ComputeHash(desencriptado);
                resultado = Encoding.Unicode.GetString(hash);
            }
            return resultado;
        }
        #endregion

        #region SHA512
        public string EncriptarSHA512(string contrasenia)
        {
            string resultado = string.Empty;
            byte[] encriptado = Encoding.Unicode.GetBytes(contrasenia);
            using (SHA512 sha512 = SHA512.Create())
            {
                byte[] hash = sha512.ComputeHash(encriptado);
                resultado = Convert.ToBase64String(hash);
            }
            return resultado;
        }

        public string DesencriptarSHA512(string contraseniaencriptada)
        {
            string resultado = string.Empty;
            byte[] desencriptado = Convert.FromBase64String(contraseniaencriptada);
            using (SHA512 sha512 = SHA512.Create())
            {
                byte[] hash = sha512.ComputeHash(desencriptado);
                resultado = Encoding.Unicode.GetString(hash);
            }
            return resultado;
        }
        #endregion

        #region Base64
        public string CodificarBase64(string contrasenia)
        {
            string resultado = string.Empty;
            byte[] encriptado = Encoding.Unicode.GetBytes(contrasenia);
            resultado = Convert.ToBase64String(encriptado);
            return resultado;
        }

        public string DecodificarBase64(string contraseniaencriptada)
        {
            string resultado = string.Empty;
            byte[] desencriptado = Convert.FromBase64String(contraseniaencriptada);
            resultado = Encoding.Unicode.GetString(desencriptado);
            return resultado;
        }
        #endregion
    }
}
