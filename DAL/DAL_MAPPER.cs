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

        public abstract int Alta(T entidad);
        public abstract int Baja(T entidad);
        public abstract int Modificacion(T entidad);
        public abstract List<T> TraerTodos();

        internal abstract T Convertir(DataRow registro);
    }
}
