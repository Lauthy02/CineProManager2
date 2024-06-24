using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class BE_BUTACA
    {
		private int fila;
		public int Fila
		{
			get { return fila; }
			set { fila = value; }
		}

		private int columna;
		public int Columna
        {
			get { return columna; }
			set { columna = value; }
		}

		private bool disponible;
		public bool Disponible
		{
			get { return disponible; }
			set { disponible = value; }
		}
	}
}
