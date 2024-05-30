using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class BE_ASIENTO
    {
		private int numeroDeAsiento;
		public int NumeroDeAsiento
		{
			get { return numeroDeAsiento; }
			set { numeroDeAsiento = value; }
		}

		private int numeroDeFila;
		public int NumeroDeFila
		{
			get { return numeroDeFila; }
			set { numeroDeFila = value; }
		}

		private bool disponible;
		public bool Disponible
		{
			get { return disponible; }
			set { disponible = value; }
		}
	}
}
