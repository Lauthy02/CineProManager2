using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class BE_CINE
    {
		public BE_CINE()
        {
            listaDeSalas = new List<BE_SALA>();
			cartelera = new BE_CARTELERA();
        }

		private int id;
		public int Id
		{
			get { return id; }
			set { id = value; }
		}

		private string nombre;
		public string Nombre
		{
			get { return nombre; }
			set { nombre = value; }
		}

		private string zona;
		public string Zona
		{
			get { return zona; }
			set { zona = value; }
		}

		private string direccion;
		public string Direccion
		{
			get { return direccion; }
			set { direccion = value; }
		}

		private List<BE_SALA> listaDeSalas;
		public List<BE_SALA> ListaDeSalas
		{
			get { return listaDeSalas; }
			set { listaDeSalas = value; }
		}

		private BE_CARTELERA cartelera;
		public BE_CARTELERA Cartelera
		{
			get { return cartelera; }
			set { cartelera = value; }
		}

        public override string ToString()
        {
			return Nombre + " " + Zona;
        }
    }
}
