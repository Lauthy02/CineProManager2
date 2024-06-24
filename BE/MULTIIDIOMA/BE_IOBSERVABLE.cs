using BE.MULTIIDOMA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE.MULTIIDIOMA
{
    public interface BE_IOBSERVABLE
    {
        void AgregarObservador(BE_IOBSERVERIDIOMA observador);
        void QuitarObservador(BE_IOBSERVERIDIOMA observador);
        void NotificarObservadores(BE_IDIOMA idioma);
    }
}
