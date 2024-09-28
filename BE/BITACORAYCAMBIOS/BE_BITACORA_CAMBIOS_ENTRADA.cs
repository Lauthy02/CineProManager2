using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE.BITACORAYCAMBIOS
{
    public class BE_BITACORA_CAMBIOS_ENTRADA : BE_BITACORA_CAMBIOS
    {
		private BE_ENTRADA b_entrada;
		public BE_ENTRADA B_Entrada
		{
			get { return b_entrada; }
			set { b_entrada = value; }
		}
    }
}
