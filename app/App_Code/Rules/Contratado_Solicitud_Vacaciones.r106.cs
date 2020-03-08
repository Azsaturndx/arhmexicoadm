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
        /// with a command name that matches "Custom" and argument that matches "EXECSQL05".
        /// </summary>
        [Rule("r106")]
        public void r106Implementation(Contratado_Solicitud_VacacionesModel instance)
        {
            int diasFinalesAutorizados = Convert.ToInt32(instance.Dias_Autorizados);

            using (SqlProcedure sql = new SqlProcedure("dbo.sp_Revision_De_Solicitud"))
            {
                sql.Command.CommandTimeout = 60 * 10;
                //Definición parametro especial para recibir el RETURN del SP
                sql.AddParameter("RetVal", 0);
                sql.Parameters["RetVal"].Direction = ParameterDirection.ReturnValue;

                sql.AddParameter("@Tipo_Prestacion_Id", 1);// PRESTACION TIPO VACACION
                sql.AddParameter("@Estado_Solicitud_Vacaciones", 3);// 4. Significa RECHAZADO
                sql.AddParameter("@Solicitud_Vacaciones_Key", instance.Solicitud_Vacaciones_Key);
                sql.AddParameter("@Dias_Autorizados", diasFinalesAutorizados);
                //sql.AddParameter("@Contratante_Id", instance.Contratante_Id);
                sql.AddParameter("@Contratado_Id", instance.Contratado_Id);
                sql.AddParameter("@Fecha_Solicitud", instance.Fecha_Solicitud);
                sql.AddParameter("@Dias_Solicitados", instance.Dias_Solicitados);
                sql.AddParameter("@Fecha_Inicio_Vacaciones", instance.Fecha_Inicio_Vacaciones);
                sql.AddParameter("@Fecha_Fin_Vacaciones", instance.Fecha_Fin_Vacaciones);
                sql.AddParameter("@Notas_Autorizacion_Rechazo", "");

                /*Parametros de sistema**/
                sql.AddParameter("@Creado_Por_Id", UserId);
                sql.AddParameter("@Transaccion_Id", DBNull.Value);
                sql.AddParameter("@Fijar_Bitacora", 1);
                sql.AddParameter("@Mostrar_Tablas_Sistema", 0);
                //cmd.Parameters.Add("@Mensaje_Sistema_Id", 1);//.Direction = ParameterDirection.Output;
                sql.AddParameter("@Mensaje_Sistema_Id", 1);
                sql.AddParameter("@Simular", 0);
                sql.AddParameter("@Trace", "");//.Direction = ParameterDirection.Output;
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
            }// using (SqlProcedure sql = new SqlProcedure("dbo.sp_Revision_De_Solicitud"))
        }//public void r106Implementation(Contratado_Solicitud_VacacionesModel instance)
    }//public partial class Contratado_Solicitud_VacacionesBusinessRules : arhmexico.Rules.SharedBusinessRules
}//namespace arhmexico.Rules
