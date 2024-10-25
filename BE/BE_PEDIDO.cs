using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class BE_PEDIDO
    {
		public BE_PEDIDO()
		{
			golosinas = new List<BE_GOLOSINA>();
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

		private BE_USUARIO vendedor;
		public BE_USUARIO Vendedor
		{
			get { return vendedor; }
			set { vendedor = value; }
		}

		private DateTime fecha;
		public DateTime Fecha
		{
			get { return fecha; }
			set { fecha = value; }
		}

		private List<BE_GOLOSINA> golosinas;
		public List<BE_GOLOSINA> Golosinas
		{
			get { return golosinas; }
			set { golosinas = value; }
		}
	}
}
