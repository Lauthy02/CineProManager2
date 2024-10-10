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
        ABMIdiomas,
        ReservarEntradas,
        PagarEntradas,
        EmitirEntradas,
        MarcarEntradas,
        GestionarBitacoraEventos,
        GestionarBitacoraCambios,
        GestionarBackup,
        GestionarReportes,
    }
}