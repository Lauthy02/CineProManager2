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
			pelicula = new BE_PELICULA();
			listaDeAsientosOcupados = new List<BE_BUTACA>();
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

		private DateTime horario;
		public DateTime Horario
		{
			get { return horario; }
			set { horario = value; }
		}

		private List<BE_BUTACA> listaDeAsientosOcupados;
		public List<BE_BUTACA> ListaDeAsientosOcupados
        {
			get { return listaDeAsientosOcupados; }
			set { listaDeAsientosOcupados = value; }
		}

		public override string ToString()
        {
            return id.ToString() + " - " + pelicula.Titulo + " - " + horario.ToString();
        }
    }
}
