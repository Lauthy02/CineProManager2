using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class BE_ENTRADA
    {
		public BE_ENTRADA()
		{
            cliente = new BE_USUARIO();
			funcion = new BE_FUNCION();
		}

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

		private BE_BUTACA asientoReservado;
		public BE_BUTACA AsientoReservado
        {
			get { return asientoReservado; }
			set { asientoReservado = value; }
		}

		private DateTime fechaDeReserva;
		public DateTime FechaDeReserva
		{
			get { return fechaDeReserva; }
			set { fechaDeReserva = value; }
		}

		private BE_ENTRADA_ESTADO_ENUM estado;
		public BE_ENTRADA_ESTADO_ENUM Estado
		{
			get { return estado; }
			set { estado = value; }
		}
	}
}
