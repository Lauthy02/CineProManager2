using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class BE_CARTELERA
    {
		public BE_CARTELERA()
        {
            listaDePeliculas = new List<BE_PELICULA>();
        }

		private List<BE_PELICULA> listaDePeliculas;
		public List<BE_PELICULA> ListaDePeliculas
		{
			get { return listaDePeliculas; }
			set { listaDePeliculas = value; }
		}
	}
}
