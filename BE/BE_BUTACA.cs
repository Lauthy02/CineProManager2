using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class BE_BUTACA
    {
        private int columna;
        public int Columna
        {
            get { return columna; }
            set { columna = value; }
        }

        private BE_BUTACA_FILA_ENUM fila;
		public BE_BUTACA_FILA_ENUM Fila
		{
			get { return fila; }
			set { fila = value; }
		}

        public override string ToString()
        {
            return fila.ToString() + columna.ToString();
        }
    }
}
