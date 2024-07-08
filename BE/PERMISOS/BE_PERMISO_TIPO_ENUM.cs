using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BE
{
    public enum BE_PERMISO_TIPO_ENUM
    {
        //Acá no van roles, van acciones
        SinPermisos,
        GestionarPermisosDeUsuarios,
        GestionarPermisos,
        GestionarCines,
        ABMUsuarios,
        ABMPeliculas,
        ABMCines,
        ABMSalas,
        ABMFunciones,
        ReservarEntradas,
        PagarEntradas,
        EmitirEntradas,
        MarcarEntradas,
    }
}