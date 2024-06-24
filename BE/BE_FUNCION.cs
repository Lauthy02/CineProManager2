using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class BE_FUNCION
    {
		public BE_FUNCION()
        {
            listaDeAsientos = new List<BE_BUTACA>();
        }

		private int id;
		public int Id
		{
			get { return id; }
			set { id = value; }
		}

		private BE_PELICULA pelicula;
		public BE_PELICULA Pelicula
		{
			get { return pelicula; }
			set { pelicula = value; }
		}

		private BE_SALA sala;
		public BE_SALA Sala
		{
			get { return sala; }
			set { sala = value; }
		}

		private DateTime horario;
		public DateTime Horario
		{
			get { return horario; }
			set { horario = value; }
		}

		private List<BE_BUTACA> listaDeAsientos;
		public List<BE_BUTACA> ListaDeAsientos
		{
			get { return listaDeAsientos; }
			set { listaDeAsientos = value; }
		}
	}
}
