using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class BE_RESERVA
    {
		private int id;
		public int Id
		{
			get { return id; }
			set { id = value; }
		}

		private BE_USUARIO cliente;
		public BE_USUARIO Cliente
		{
			get { return cliente; }
			set { cliente = value; }
		}

		private BE_FUNCION funcion;
		public BE_FUNCION Funcion
		{
			get { return funcion; }
			set { funcion = value; }
		}

		private List<BE_ASIENTO> listaDeAsientosReservados;
		public List<BE_ASIENTO> ListaDeAsientosReservados
		{
			get { return listaDeAsientosReservados; }
			set { listaDeAsientosReservados = value; }
		}

		private DateTime fechaDeReserva;
		public DateTime FechaDeReserva
		{
			get { return fechaDeReserva; }
			set { fechaDeReserva = value; }
		}
	}
}
