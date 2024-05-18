using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE.PERMISOS
{
    public abstract class BE_PERMISO
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public BE_PERMISO_TIPO_ENUM PermisoTipoEnum { get; set; }

        public abstract IList<BE_PERMISO> ListaDeHijos { get; }
        public abstract void AgregarHijo(BE_PERMISO bepermiso);
        public abstract void VaciarHijos();

        public override string ToString()
        {
            return Nombre;
        }
    }
}
