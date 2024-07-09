using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class BE_SALA
    {
		public BE_SALA()
        {
            listaDeFunciones = new List<BE_FUNCION>();
        }

		private int id;
		public int Id
		{
			get { return id; }
			set { id = value; }
		}

		private int numeroDeSala;
		public int NumeroDeSala
		{
			get { return numeroDeSala; }
			set { numeroDeSala = value; }
		}

		private int capacidad;
		public int Capacidad
		{
			get { return capacidad; }
			set { capacidad = value; }
		}

		private BE_SALA_FORMATO_ENUM formato;
		public BE_SALA_FORMATO_ENUM Formato
		{
			get { return formato; }
			set { formato = value; }
		}

		private List<BE_FUNCION> listaDeFunciones;
		public List<BE_FUNCION> ListaDeFunciones
		{
			get { return listaDeFunciones; }
			set { listaDeFunciones = value; }
		}
	}
}
