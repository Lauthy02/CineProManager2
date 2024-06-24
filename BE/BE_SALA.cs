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
            listaDeAsientos = new List<BE_BUTACA>();
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
			get { return id; }
			//set { numeroDeSala = value; }
		}

		private int capacidad;
		public int Capacidad
		{
			get { return listaDeAsientos.Count; }
			//set { capacidad = value; }
		}

		private BE_SALA_FORMATO_ENUM formato;
		public BE_SALA_FORMATO_ENUM Formato
		{
			get { return formato; }
			set { formato = value; }
		}


		private List<BE_BUTACA> listaDeAsientos;
		public List<BE_BUTACA> ListaDeAsientos
		{
			get { return listaDeAsientos; }
			set { listaDeAsientos = value; }
		}
	}
}
