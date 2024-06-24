using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE.MULTIIDOMA
{
    public class BE_TRADUCCION
    {
		/*
		private int id;
		public int Id
		{
			get { return id; }
			set { id = value; }
		}
		*/

		private BE_ETIQUETA etiqueta;
		public BE_ETIQUETA Etiqueta
		{
			get { return etiqueta; }
			set { etiqueta = value; }
		}

		private BE_IDIOMA idioma;
		public BE_IDIOMA Idioma
		{
			get { return idioma; }
			set { idioma = value; }
		}

		private string texto;
		public string Texto
		{
			get { return texto; }
			set { texto = value; }
		}
	}
}
