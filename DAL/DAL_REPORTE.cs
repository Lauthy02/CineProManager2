using BE;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_REPORTE
    {
        internal DAL_ACCESOBD acceso = new DAL_ACCESOBD();

        public DAL_REPORTE()
        {
            acceso.AbrirConexion();
        }

        public void GenerarReporteTodosLosCines(BE_CINE cine)
        {
            //Generar reporte de un cine
            NotImplementedException ex = new NotImplementedException();
        }

        public void GenerarReporteTodosLosCinesConFechas(DateTime fechaInicio, DateTime fechaFin)
        {
            //Generar reporte de todos los cines con fechas
            NotImplementedException ex = new NotImplementedException();
        }

        public DataTable GenerarReporteCine(BE_CINE cine)
        {
            //Generar reporte de un cine
            List<SqlParameter> parametros = new List<SqlParameter>();
            SqlParameter p = acceso.CrearParametro("@idcine", cine.Id);
            parametros.Add(p);

            DataTable tabla = acceso.Leer("REPORTE_CINE", parametros);
            /*  SELECT CINE.Id AS IdCine, CINE.Nombre AS NombreCine, COUNT(ENTRADA.Id) AS CantidadEntradasVendidas
	            FROM CINE
	            INNER JOIN CINE_SALA ON CINE.Id = CINE_SALA.IdCine
	            INNER JOIN SALA ON CINE_SALA.IdSala = SALA.Id
	            INNER JOIN SALA_FUNCION ON SALA.Id = SALA_FUNCION.IdSala
	            INNER JOIN FUNCION ON SALA_FUNCION.IdFuncion = FUNCION.Id
	            INNER JOIN ENTRADA ON FUNCION.Id = ENTRADA.IdFuncion
	            WHERE CINE.Id = @idcine
	            AND ENTRADA.Estado = 'Pagada'
	            GROUP BY CINE.Id, CINE.Nombre;
            */
            return tabla;
        }

        public void GenerarReporteCineConFechas(BE_CINE cine, DateTime fechaInicio, DateTime fechaFin)
        {
            //Generar reporte de un cine con fechas
            NotImplementedException ex = new NotImplementedException();
        }
    }
}
