using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Security;
using System.Data.SqlClient;
using System.Configuration;
using arhmexico.Data;
using arhmexico.Models;

namespace arhmexico.Rules
{
	public partial class Contratado_Solicitud_VacacionesBusinessRules : arhmexico.Rules.SharedBusinessRules
    {
        
        /// <summary>
        /// This method will execute in any view after an action
        /// with a command name that matches "Custom" and argument that matches "EXECCS06".
        /// </summary>
        [Rule("r107")]
        public void r107Implementation(Contratado_Solicitud_VacacionesModel instance)
        {

            using (SqlProcedure sql = new SqlProcedure("dbo.sp_Administrar_Solicitud_Vacaciones"))
            {
                sql.Command.CommandTimeout = 60 * 10;
                //Definición parametro especial para recibir el RETURN del SP
                sql.AddParameter("RetVal", 0);
                sql.Parameters["RetVal"].Direction = ParameterDirection.ReturnValue;

                sql.AddParameter("@Tipo_Operacion_Id", 1);// 1. Significa INSERT/CREACION NUEVO
                sql.AddParameter("@Contratado_Solicitud_Vacaciones_Id", 0);/// Este es el ID de la tabla de solicitudes.                    
                sql.AddParameter("@Solicitud_Vacaciones_Key", "");
                sql.AddParameter("@Contratado_Id", instance.Contratado_Id);
                sql.AddParameter("@Fecha_Solicitud", instance.Fecha_Solicitud);
                sql.AddParameter("@Dias_Solicitados", instance.Dias_Solicitados);
                sql.AddParameter("@Fecha_Inicio_Vacaciones", instance.Fecha_Inicio_Vacaciones);
                sql.AddParameter("@Fecha_Fin_Vacaciones", instance.Fecha_Fin_Vacaciones);
                sql.AddParameter("@Estatus_Solicitud_Id", instance.Estatus_Solicitud_Id);
                sql.AddParameter("@Fecha_Autorizacion_Rechazo", DateTime.Today);
                sql.AddParameter("@Autorizado_Rechazado_Por_Id", UserId);
                sql.AddParameter("@Notas_Autorizacion_Rechazo", instance.Notas_Autorizacion_Rechazo);
                sql.AddParameter("@Dias_Autorizados", instance.Dias_Autorizados);
                sql.AddParameter("@Fecha_Inicio_Vacaciones_Autorizado ", instance.Fecha_Inicio_Vacaciones);
                sql.AddParameter("@Fecha_Fin_Vacaciones_Autorizado ", instance.Fecha_Fin_Vacaciones);
                sql.AddParameter("@HTML ", "");
                /*Parametros de sistema**/
                sql.AddParameter("@Creado_Por_Id", UserId);
                sql.AddParameter("@Transaccion_Id", DBNull.Value);
                sql.AddParameter("@Fijar_Bitacora", 1);
                sql.AddParameter("@Mostrar_Tablas_Sistema", 0);
                sql.AddParameter("@Mensaje_Sistema_Id", 1);
                sql.AddParameter("@Simular", 0);
                sql.AddParameter("@Trace", "");
                sql.AddParameter("@Debug", 0);

                sql.Parameters["@Mensaje_Sistema_Id"].Direction = ParameterDirection.Output;
                sql.Parameters["@Trace"].Direction = ParameterDirection.Output;

                //Definición de tamaños que soporten los tipos de datos de los parametros del salida del SP                 
                sql.Parameters["@Mensaje_Sistema_Id"].Size = 4;
                sql.Parameters["@Trace"].Size = 8000;

                sql.ExecuteNonQuery();

                if (sql.Parameters["RetVal"].Value.ToString() != "1")
                {
                    String ErrorMessage = SqlText.ExecuteScalar("SELECT Mensaje_Amigable_Usuario FROM dbo.Mensaje_Sistema WHERE Mensaje_Sistema_Id=" + sql.Parameters["@Mensaje_Sistema_Id"].Value.ToString()).ToString();
                    Result.ShowAlert(ErrorMessage);
                }
                else
                {
                    Result.Continue();
                }
            }// using (SqlProcedure sql = new SqlProcedure("dbo.sp_Administrar_Solicitud_Vacaciones"))

        }// public void r107Implementation(Contratado_Solicitud_VacacionesModel instance)
    }//public partial class Contratado_Solicitud_VacacionesBusinessRules : arhmexico.Rules.SharedBusinessRules
}//namespace arhmexico.Rules
