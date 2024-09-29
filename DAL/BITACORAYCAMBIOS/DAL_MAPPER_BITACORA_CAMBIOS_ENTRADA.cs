using BE;
using BE.BITACORAYCAMBIOS;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAL.BITACORAYCAMBIOS
{
    public class DAL_MAPPER_BITACORA_CAMBIOS_ENTRADA
    {
        DAL_MAPPER_ENTRADA dalmapperentrada = new DAL_MAPPER_ENTRADA();

        DAL_MAPPER_USUARIO dalusuario = new DAL_MAPPER_USUARIO();
        DAL_MAPPER_FUNCION dalfuncion = new DAL_MAPPER_FUNCION();
        DAL_MAPPER_SALA dalsala = new DAL_MAPPER_SALA();

        internal DAL_ACCESOBD acceso = new DAL_ACCESOBD();

        public DAL_MAPPER_BITACORA_CAMBIOS_ENTRADA()
        {
            acceso.AbrirConexion();
        }

        public int Alta(BE_BITACORA_CAMBIOS_ENTRADA entidad)
        {
            BE_ENTRADA entrada = dalmapperentrada.BuscarFecha(entidad.B_Entrada.FechaDeReserva);

            List<SqlParameter> parametros = new List<SqlParameter>();
            SqlParameter p = acceso.CrearParametro("@idusuarioquemodifica", entidad.UsuarioQueModifica.Id);
            parametros.Add(p);
            p = acceso.CrearParametro("@fechadecambio", entidad.FechaDeCambio);
            parametros.Add(p);
            p = acceso.CrearParametro("@activo", entidad.Activo ? 1 : 0);
            parametros.Add(p);
            p = acceso.CrearParametro("@b_identrada", entrada.Id);
            parametros.Add(p);
            p = acceso.CrearParametro("@b_idusuario", entidad.B_Entrada.Cliente.Id);
            parametros.Add(p);
            p = acceso.CrearParametro("@b_idfuncion", entidad.B_Entrada.Funcion.Id);
            parametros.Add(p);
            p = acceso.CrearParametro("@b_idsala", entidad.B_Entrada.Sala.Id);
            parametros.Add(p);
            p = acceso.CrearParametro("@b_butaca", entidad.B_Entrada.AsientoReservado.ToString());
            parametros.Add(p);
            p = acceso.CrearParametro("@b_precio", entidad.B_Entrada.Precio);
            parametros.Add(p);
            p = acceso.CrearParametro("@b_fechadereserva", entidad.B_Entrada.FechaDeReserva);
            parametros.Add(p);
            p = acceso.CrearParametro("@b_estado", entidad.B_Entrada.Estado.ToString());
            parametros.Add(p);
            p = acceso.CrearParametro("@b_digitohorizontal", entrada.DigitoVerificador);
            parametros.Add(p);

            int res = acceso.Escribir("BITACORA_CAMBIOS_ENTRADA_INSERTAR", parametros);
            return res;
            /*
            --UPDATE BITACORACAMBIOS_ENTRADA SET activo = 0 WHERE b_identrada = @identrada;
            INSERT INTO BITACORACAMBIOS_ENTRADA VALUES (@idusuarioquemodifica, @fechadecambio, @activo, @accion, @b_identrada, @b_idusuario, @b_idfuncion, @b_idsala, @b_butaca, @b_precio, @b_fechadereserva, @b_estado, @b_digitohorizontal)
            */
        }

        public void RecomponerEstado(BE_BITACORA_CAMBIOS_ENTRADA entradaanterior)
        {
            //Modificar la tabla entrada
            BE_ENTRADA entrada = new BE_ENTRADA
            {
                Id = entradaanterior.B_Entrada.Id,
                Cliente = entradaanterior.B_Entrada.Cliente,
                Funcion = entradaanterior.B_Entrada.Funcion,
                Sala = entradaanterior.B_Entrada.Sala,
                AsientoReservado = entradaanterior.B_Entrada.AsientoReservado,
                Precio = entradaanterior.B_Entrada.Precio,
                FechaDeReserva = entradaanterior.B_Entrada.FechaDeReserva,
                Estado = entradaanterior.B_Entrada.Estado,
                DigitoVerificador = entradaanterior.B_Entrada.DigitoVerificador
            };

            dalmapperentrada.Modificacion(entrada);

            //Setear como activo en la bitácora

            //MessageBox.Show(entradaanterior.FechaDeCambio.ToString("yyyy-MM-dd HH:mm:ss.fff"));
            //MessageBox.Show(entradaanterior.FechaDeCambio.Millisecond.ToString());

            List<SqlParameter> parametros = new List<SqlParameter>();
            SqlParameter p = acceso.CrearParametro("@fechadecambio", entradaanterior.FechaDeCambio);
            parametros.Add(p);
            p = acceso.CrearParametro("@activo", 1);
            parametros.Add(p);
            p = acceso.CrearParametro("@b_identrada", entrada.Id);
            parametros.Add(p);

            int res = acceso.Escribir("BITACORA_CAMBIOS_ENTRADA_MODIFICAR", parametros);
            /*
           	--Setear todos los activos en 0
	        UPDATE BITACORACAMBIOS_ENTRADA SET activo = 0 WHERE b_identrada = @b_identrada;

	        --Setear solo el activo en 1
	        UPDATE BITACORACAMBIOS_ENTRADA SET 
		        activo = @activo
	        WHERE fechadecambio = @fechadecambio;
            */
        }

        public List<BE_BITACORA_CAMBIOS_ENTRADA> TraerTodos()
        {
            List<BE_BITACORA_CAMBIOS_ENTRADA> bitacoraentradas = new List<BE_BITACORA_CAMBIOS_ENTRADA>();
            DataTable tabla = acceso.Leer("BITACORA_CAMBIOS_ENTRADA_LISTAR", null);
            //SELECT * FROM BITACORACAMBIOS_ENTRADA
            foreach (DataRow dr in tabla.Rows)
            {
                bitacoraentradas.Add(Convertir(dr));
            }

            foreach (var entrada in bitacoraentradas)
            {
                LlenarUsuario(entrada);
                LlenarFuncion(entrada);
                LlenarSala(entrada);
            }
            return bitacoraentradas;
        }

        internal BE_BITACORA_CAMBIOS_ENTRADA Convertir(DataRow registro)
        {
            string butaca = registro["b_butaca"].ToString();
            string fila = new string(butaca.TakeWhile(c => !char.IsDigit(c)).ToArray());
            string columna = new string(butaca.SkipWhile(c => !char.IsDigit(c)).ToArray());

            BE_BUTACA butacaaux = new BE_BUTACA();
            butacaaux.Fila = (BE_BUTACA_FILA_ENUM)Enum.Parse(typeof(BE_BUTACA_FILA_ENUM), fila);
            butacaaux.Columna = int.Parse(columna);

            BE_BITACORA_CAMBIOS_ENTRADA bitacoraentrada = new BE_BITACORA_CAMBIOS_ENTRADA();

            bitacoraentrada.Id = int.Parse(registro["id"].ToString());
            bitacoraentrada.UsuarioQueModifica.Id = int.Parse(registro["idusuarioquemodifica"].ToString());

            //Hago un tratamiento manual de la fecha porque el DateTime.Parse() no me guarda los milisegundos leídos del registro
            //Estos milisegundos los necesito para la comparación de fechas en la función RecomponerEstado() para saber cuál setear como activo
            object registroFecha = registro["fechadecambio"]; // Valor de SQL Server
            DateTime fechaFinal = ProcesarFechaDesdeSQL(registroFecha);
            bitacoraentrada.FechaDeCambio = fechaFinal;

            bitacoraentrada.Activo = bool.Parse(registro["activo"].ToString());
            bitacoraentrada.B_Entrada = new BE_ENTRADA 
            {
                Id = int.Parse(registro["b_identrada"].ToString()),
                Cliente = new BE_USUARIO { Id = int.Parse(registro["b_idusuario"].ToString()) },
                Funcion = new BE_FUNCION { Id = int.Parse(registro["b_idfuncion"].ToString()) },
                Sala = new BE_SALA { Id = int.Parse(registro["b_idsala"].ToString()) },
                AsientoReservado = butacaaux,
                Precio = float.Parse(registro["b_precio"].ToString()),
                FechaDeReserva = DateTime.Parse(registro["b_fechadereserva"].ToString()),
                Estado = (BE_ENTRADA_ESTADO_ENUM)Enum.Parse(typeof(BE_ENTRADA_ESTADO_ENUM), registro["b_estado"].ToString()),
                DigitoVerificador = registro["b_digitohorizontal"].ToString()
            };

            return bitacoraentrada;
        }

        public DateTime ConstruirFecha(int year, int month, int day, int hour, int minute, int second, int millisecond)
        {
            // Crear un nuevo objeto DateTime con los valores asignados
            DateTime fechaConstruida = new DateTime(year, month, day, hour, minute, second, millisecond);
            return fechaConstruida;
        }

        public DateTime ProcesarFechaDesdeSQL(object registroFecha)
        {
            // Verificar si el valor que viene de la base de datos es un DateTime
            DateTime fechaSQL;

            // Si ya es un DateTime, no necesitamos hacer un parse
            if (registroFecha is DateTime)
            {
                fechaSQL = (DateTime)registroFecha;
            }
            else
            {
                // Si es una cadena, convertirla
                fechaSQL = DateTime.Parse(registroFecha.ToString());
            }

            // Obtener los componentes de la fecha
            int year = fechaSQL.Year;
            int month = fechaSQL.Month;
            int day = fechaSQL.Day;
            int hour = fechaSQL.Hour;
            int minute = fechaSQL.Minute;
            int second = fechaSQL.Second;
            int millisecond = fechaSQL.Millisecond;

            // Usar la función ConstruirFecha para reconstruirla si es necesario
            return ConstruirFecha(year, month, day, hour, minute, second, millisecond);
        }

        //PODRIA HACER UNA FUNCION QUE SEA LENAR ENTRADA. 

        private void LlenarUsuario(BE_BITACORA_CAMBIOS_ENTRADA entidad)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            SqlParameter p = acceso.CrearParametro("@id", entidad.B_Entrada.Cliente.Id);
            parametros.Add(p);

            DataTable tabla = acceso.Leer("USUARIO_BUSCARID", parametros);
            //SELECT * FROM USUARIO WHERE id = @id
            foreach (DataRow dr in tabla.Rows)
            {
                entidad.B_Entrada.Cliente = dalusuario.BuscarConId(int.Parse(dr["id"].ToString()));
            }
        }

        private void LlenarFuncion(BE_BITACORA_CAMBIOS_ENTRADA entidad)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            SqlParameter p = acceso.CrearParametro("@id", entidad.B_Entrada.Funcion.Id);
            parametros.Add(p);

            DataTable tabla = acceso.Leer("FUNCION_BUSCARID", parametros);
            //SELECT * FROM FUNCION WHERE id = @id
            foreach (DataRow dr in tabla.Rows)
            {
                entidad.B_Entrada.Funcion = dalfuncion.BuscarConId(int.Parse(dr["id"].ToString()));
            }
        }

        private void LlenarSala(BE_BITACORA_CAMBIOS_ENTRADA entidad)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            SqlParameter p = acceso.CrearParametro("@id", entidad.B_Entrada.Sala.Id);
            parametros.Add(p);

            DataTable tabla = acceso.Leer("SALA_BUSCARID", parametros);
            //SELECT * FROM SALA WHERE id = @id
            foreach (DataRow dr in tabla.Rows)
            {
                entidad.B_Entrada.Sala = dalsala.BuscarConId(int.Parse(dr["id"].ToString()));
            }
        }
    }
}
