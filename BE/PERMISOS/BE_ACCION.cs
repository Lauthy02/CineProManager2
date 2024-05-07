using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE.PERMISOS
{
    public class BE_ACCION : BE_PERMISO
    {
        //También conocido como PATENTE

        public override IList<BE_PERMISO> ListaDeHijos
        {
            get
            {
                return new List<BE_PERMISO>();
            }
        }

        public override void AgregarHijo(BE_PERMISO bepermiso)
        {
            throw new NotImplementedException();
        }

        public override void VaciarHijos()
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return Nombre;
        }
    }
}
