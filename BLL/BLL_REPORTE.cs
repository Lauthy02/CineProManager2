using DAL;
using BE;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLL_REPORTE
    {
        DAL_REPORTE dalreporte = new DAL_REPORTE();

        public void GenerarReporteTodosLosCines(BE_CINE cine)
        {
            //Generar reporte de un cine
        }

        public void GenerarReporteTodosLosCinesConFechas(DateTime fechaInicio, DateTime fechaFin)
        {
            //Generar reporte de todos los cines con fechas
        }

        public DataTable GenerarReporteCine(BE_CINE cine)
        {
            //Generar reporte de un cine
            return dalreporte.GenerarReporteCine(cine);
        }

        public void GenerarReporteCineConFechas(BE_CINE cine, DateTime fechaInicio, DateTime fechaFin)
        {
            //Generar reporte de un cine con fechas
        }
    }
}
