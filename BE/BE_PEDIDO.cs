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
            cliente = new BE_USUARIO();
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

		private BE_PEDIDO_ESTADO_ENUM estado;
		public BE_PEDIDO_ESTADO_ENUM Estado
		{
			get { return estado; }
			set { estado = value; }
		}

		private float montototal;
		public float MontoTotal
		{
			get { return montototal; }
			set { montototal = value; }
		}

		/*
        public override string ToString()
        {
            return " Pedido N° " + Id + " - Cliente: " + Cliente.NombreDeUsuario + " - Vendedor: " + Vendedor.NombreDeUsuario + " - Fecha: " + Fecha + " - Estado: " + Estado + " - Monto Total: " + MontoTotal;
        }
		*/
    }
}
