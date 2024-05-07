using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE.PERMISOS
{
    public class BE_ROL : BE_PERMISO
    {
        //También conocido como FAMILIA

        private IList<BE_PERMISO> listaDeHijos;

        public BE_ROL()
        {
            listaDeHijos = new List<BE_PERMISO>();
        }

        public override IList<BE_PERMISO> ListaDeHijos
        {
            get
            {
                return listaDeHijos.ToArray();
            }
        }

        public override void AgregarHijo(BE_PERMISO bepermiso)
        {
            listaDeHijos.Add(bepermiso);
        }

        public override void VaciarHijos()
        {
            listaDeHijos.Clear();
        }

        public override string ToString()
        {
            return Nombre;
        }
    }
}
