using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public abstract class DAL_MAPPER<T>
    {
        internal DAL_ACCESOBD acceso = new DAL_ACCESOBD();

        public abstract int Alta(T objeto);
        public abstract int Baja(T objeto);
        public abstract int Modificacion(T objeto);
        public abstract List<T> TraerTodos();

        internal abstract T Convertir(DataRow registro);
    }
}
