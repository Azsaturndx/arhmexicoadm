using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Security;
using arhmexico.Data;
using arhmexico.Models;
using System.Data.SqlClient;
using System.Configuration;


namespace arhmexico.Rules
{
	public partial class Grid_Solicitud_Gasto_VBusinessRules : arhmexico.Rules.SharedBusinessRules
    {
        
        /// <summary>
        /// This method will execute in any view after an action
        /// with a command name that matches "Custom" and argument that matches "ExecCS01".
        /// </summary>
        [Rule("r102")]
        public void r102Implementation(Grid_Solicitud_Gasto_VModel instance)
        {
            // This is the placeholder for method implementation.
            string conStr = ConfigurationManager.ConnectionStrings["arhmexico"].ToString();
            int tipoOperacionId = 5;
            int administracionGastoId = Convert.ToInt32(instance.Administracion_Gasto_Id);
            string solicitudGastoKey = Convert.ToString(instance.Solicitud_Gasto_Key);
            decimal montoAutorizado = Convert.ToDecimal(instance.Monto_Gasto_Autorizado);
            string notasAutorizacion = Convert.ToString(instance.Comentarios_Autorizacion_Rechazo);
            

            using (SqlConnection con = new SqlConnection(conStr))
            {
                using (SqlCommand cmd = new SqlCommand("sp_Administrar_Solicitud_Gasto", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.CommandTimeout = 60 * 10;

                    cmd.Parameters.AddWithValue("@Tipo_Operacion_Id", 5);// ES AUTORIZACIÓN CON CAMBIOS
                    cmd.Parameters.AddWithValue("@Administracion_Gasto_Id", administracionGastoId);
                    cmd.Parameters.AddWithValue("@Solicitud_Gasto_Key", solicitudGastoKey);
                    cmd.Parameters.AddWithValue("@Fecha_Solicitud", DBNull.Value);
                    cmd.Parameters.AddWithValue("@Estatus_Solicitud_Id", 0);
                    cmd.Parameters.AddWithValue("@Fecha_Autorizacion_Rechazo", DBNull.Value);
                    cmd.Parameters.AddWithValue("@Autorizado_Rechazado_Por_Id", UserId);
                    cmd.Parameters.AddWithValue("@Notas_Autorizacion_Rechazo", notasAutorizacion);
                    cmd.Parameters.AddWithValue("@Monto_Gasto_Autorizado", montoAutorizado);
                    cmd.Parameters.AddWithValue("@HTML", DBNull.Value);
                    cmd.Parameters.AddWithValue("@Mensaje_Sistema_Id", 1);
                    cmd.Parameters.AddWithValue("@Debug", 0);

                    cmd.Parameters["@Mensaje_Sistema_Id"].Direction = ParameterDirection.Output;

                    cmd.Parameters["@Mensaje_Sistema_Id"].Size = 4;

                    con.Open();
                    cmd.ExecuteNonQuery();

                    con.Close();

                    if (cmd.Parameters["@Mensaje_Sistema_Id"].Value.ToString() != "1")
                    {
                        Result.ShowAlert("Ha ocurrido un error");
                    }//if (spSql.Parameters["RetVal"].Value.ToString() != "1")
                    else
                    {
                        Result.ShowAlert("Guardado con éxito");
                        Result.Refresh();

                        /*Result.RefreshChildren();
                        Result.Continue();*/
                    }//else if (spSql.Parameters["RetVal"].Value.ToString() != "1")

                }//using (SqlCommand cmd = new SqlCommand("sp_Administrar_Solicitud_Gasto", con))

            }//using (SqlConnection con = new SqlConnection(conStr))


        }
    }
}
